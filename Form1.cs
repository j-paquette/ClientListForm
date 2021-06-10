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

namespace ClientListForm
{
    public partial class Form1 : Form
    {
        //public Library Library { get; set; }
        //public PublicationProvider PublicationProvider {get; set; }

        PublicationProvider publicationProvider = new PublicationProvider();

        //public Form1(PublicationProvider publicationProvider)
        //{
        //    InitializeComponent();
        //    this.PublicationProvider = publicationProvider;
        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            this.PopulateListView();
        }

        public Library GetLibrary()
        {
            Library library = publicationProvider.GetLibraryData();

            return library;
        }

        public void PopulateListView()
        {
            //TODO: split this to a separate method
            //business layer. 
            Library library = publicationProvider.GetLibraryData();

            //Library library = this.PublicationProvider.GetLibraryData();

            //TODO: keep this in this method
            //application layer
            //get the library as a parameter
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
                //TODO: move library.Titles.Where to Library.cs
                //This can be used in different scenarios
                //name method GetTitlesByLanguageName(string languageName)
                //returns an IEnumerable<PublicationTitle>
                filteredTitles = library.Titles.Where(t => t.PublicationLanguages.Any(l => l.Name.Equals(this.cbo_Languages.SelectedItem)));
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

                this.lv_Library.Items.Add(row);
            }

            this.lv_Library.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lbl_UpdatedValue.Text = library.InventoryDate.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
            this.PopulateListView();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            this.ExportListView();
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
                            stringBuilder.AppendLine("Title,Author,TargetAudience,PublicationLanguages,BookFormat,MainSubject,Available,PublicationDate");
                            foreach (ListViewItem item in lv_Library.Items)
                            {
                                //Note: if this was a web app, use STreamwriter.writeline so as not to save the whole record in memory before saving.
                                stringBuilder.AppendLine($"{CsvConversion.SimpleConvert(item.SubItems[0].Text)},{CsvConversion.SimpleConvert(item.SubItems[1].Text)},{CsvConversion.SimpleConvert(item.SubItems[2].Text)},{CsvConversion.SimpleConvert(item.SubItems[3].Text)},{CsvConversion.SimpleConvert(item.SubItems[4].Text)},{CsvConversion.SimpleConvert(item.SubItems[5].Text)},{CsvConversion.SimpleConvert(item.SubItems[6].Text)},{CsvConversion.SimpleConvert(item.SubItems[7].Text)}");
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
    }
}
