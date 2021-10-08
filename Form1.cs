using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientListForm.Entities;
using Microsoft.Extensions.DependencyModel;
using Library = ClientListForm.Entities.Library;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace ClientListForm
{
    public partial class Form1 : Form
    {
        private PublicationProvider publicationProvider;

        private readonly BackgroundWorker worker;

        private Library library;




        public Form1()
        {
            InitializeComponent();
            this.publicationProvider = new PublicationProvider();

            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false; //no progress reports
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            // Connect the ListView.ColumnClick event to the ColumnClick event handler.
            this.lv_Library.ColumnClick += new ColumnClickEventHandler(ColumnClick);
        }



        private void displayButton_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
            btn_display.Enabled = false;

            this.UseWaitCursor = true;

            //TODO: Where do I put the DoWorkEventArgs section of the code?
            //Same as in ClientListReport.CacheRecordProvider.GetClientData() line 83-87
            //TODO: add multithreading handling here
            //event handler runs the UI thread
            //call GetLibrary should be called using a separate thread
            //this.PopulateListView(GetLibrary());
        }

        public Library GetLibrary()
        {
            
            //Separates business layer 
            Library library = this.publicationProvider.GetLibraryData();

            return library;
        }

        public void PopulateListView(Library library)
        {
            //start here: https://visualstudiomagazine.com/Articles/2010/11/18/Multithreading-in-WinForms.aspx?m=1&Page=1
            //Clear any exising records, not to duplicate them
            lv_Library.Items.Clear();

            IEnumerable<PublicationTitle> filteredTitles;

            //if slected All, don't apply the filter
            if (this.cbo_Languages.SelectedItem.Equals("All"))
            {
                filteredTitles = library.Titles;
            }
            else
            {
                filteredTitles = library.GetTitlesByLanguageName(this.cbo_Languages.SelectedItem.ToString());
            }

            foreach (PublicationTitle title in filteredTitles)
            {
                ListViewItem row = new ListViewItem(title.Title);
                row.SubItems.Add(title.Author);
                row.SubItems.Add(title.TargetAudience.ToString());

                //TODO: instead of var, IEnumerable<string>
                //Select is a functional programming
                var languages = title.PublicationLanguages.Select(l => l.Name);

                string languagesText = string.Join(", ", languages);

                row.SubItems.Add(languagesText);
                //Add Format records from the list
                var formats = title.Formats.Select(f => f.BookFormat);
                string formatText = string.Join(", ", formats);
                row.SubItems.Add(formatText);

                //Add the remaining columns
                row.SubItems.Add(title.MainSubject.ToString());
                row.SubItems.Add(title.Available.ToString());
                row.SubItems.Add(title.PublicationDate.ToString("yyyy-MM-dd"));
                
                //add the column as a clickable Url
                row.SubItems.Add(title.GetUrl.ToString());
                

                //Add the row for each of the records in PublicationProvider to the list view
                this.lv_Library.Items.Add(row);
            }

            //set HotTracking to true, to enable the Url
            //this.lv_Library.HotTracking = true;

            this.lv_Library.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lbl_UpdatedValue.Text = library.InventoryDate.ToString();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
           this.library = this.GetLibrary();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_display.Enabled = true;
            this.UseWaitCursor = false;

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString(), "Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.PopulateListView(this.library);            
        }

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer object.
            // Setting this property immediately sorts the ListView (lv_Library using the ListViewItemComparer object.
            this.lv_Library.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //Selects All by default
            this.cbo_Languages.SelectedIndex = 0;
        }

        private void lbl_UpdatedValue_Click(object sender, EventArgs e)
        {
            
        }

        private void cbo_Languages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.library == null)
            {
                worker.RunWorkerAsync();
                btn_display.Enabled = false;

                this.UseWaitCursor = true;
            }
            else
            {
                this.PopulateListView(this.library);
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            this.ExportListView();
        }

        private void lv_Library_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = lv_Library.HitTest(e.Location);

            if (hit.SubItem != null && (hit.Item.SubItems[8] == hit.SubItem || hit.Item.SubItems[7] == hit.SubItem))
            {
                lv_Library.Cursor = Cursors.Hand;
            }
            else
            {
                lv_Library.Cursor = Cursors.Default;
            }
        }


        /// <summary>
        /// Export button that exports records displayed in UI to a .csv file
        /// Clicking the button shows a fileSaveDialog to let user choose where to save
        /// user click ok
        /// Exceptions are displayed to user in a MessageBox.Show
        /// This method exports the records from the UI, not the library. 
        /// If the records displayed need to be limited in case of too many records to display in UI, not all records would be exported.
        /// </summary>
        public void ExportListView()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter streamWriter = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            //Rewrite above line as foreach below. To avoid hard-coded columnHeaders, in case columns are removed, renamed, new ones added, etc

                            //Display the column headers in the first line
                            foreach (ColumnHeader column in lv_Library.Columns)
                            {
                                stringBuilder.Append($"{CsvConversion.SimpleConvert(column.Text)},");
                            }
                            stringBuilder.AppendLine();

                            //Displays each row
                            foreach (ListViewItem item in lv_Library.Items)
                            {
                                //Displays data in each column
                                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                                {
                                    //Print the data
                                    //Note: if this was a web app, use Streamwriter.writeline so as not to save the whole record in memory before saving.
                                    stringBuilder.Append($"{CsvConversion.SimpleConvert(subItem.Text)},");
                                }
                                stringBuilder.AppendLine();
                            }
                            streamWriter.WriteLine(stringBuilder.ToString());
                            MessageBox.Show("Your data has been successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lv_Library_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = lv_Library.HitTest(e.Location);
            try 
            { 
            if (e.Button != MouseButtons.Left || hit.SubItem == null || string.IsNullOrWhiteSpace(hit.SubItem.Text))
            {
                return;
            }

            if (hit.SubItem == hit.Item.SubItems[8])
            {
                Uri url = new Uri(hit.SubItem.Text);

                //Keep for troubleshooting opening multiple MoveUp events
                //System.Diagnostics.Debug.WriteLine(url.ToString() + " " + e.Button.ToString() + " " + e.Clicks);

                //starts process.start in another thread, otherwise Process.Start somehow triggers multiple MouseUp events
                Task t1 = new Task(() => Process.Start(url.ToString()));

                t1.Start();
            }
            else if (hit.SubItem == hit.Item.SubItems[7])
            {
                Task t1 = new Task(() => Process.Start("mailto:josee.n.paquette@hrsdc-rhdcc.gc.ca"));
                    //for not hardcoding email address, use Process.Start("mailto:" + hit.SubItem.Text)

                    t1.Start();

            }
            else if (hit.SubItem == hit.Item.SubItems[6])
            {
                Clipboard.SetText(hit.SubItem.Text);
                MessageBox.Show(this,"Your text has been copied to clipboard.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
