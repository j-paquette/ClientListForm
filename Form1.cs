using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientListForm.Entities;

namespace ClientListForm
{
    public partial class Form1 : Form
    {
        PublicationProvider publicationProvider = new PublicationProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //TODO: Click events don't need a Delegate? Or are they only used when you need to create a custom Event Handler?
            //Explanation here: https://docs.microsoft.com/en-us/dotnet/standard/events/
            //Examples here: https://docs.microsoft.com/en-us/dotnet/standard/events/how-to-raise-and-consume-events
            this.PopulateListView();
        }

        public void PopulateListView()
        {
            Library library = publicationProvider.GetLibraryData();
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
            //FilterDescriptor typeFilter = new FilterDescriptor("Type", FilterOperator.Contains, "Title");
            //lv_Library.EnableFiltering = true;
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
            //Clear any exising records, not to duplicate them
            lv_Library.Items.Clear();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            this.ExportListView();
        }

        /// <summary>
        /// TODO: add a new button called Export that will export to a .csv file
        /// when you click the button, it will show a fileSaveDialog to let user choose where to save
        /// user click ok
        /// foreach (PublicationTitle title in filteredTitles)
        /// { file.writeline) or something like this
        /// similar to writeline. check my old code in ClientListReport
        /// use try catch to catch any exceptions "messageBox.Show" to display the message to the user
        /// </summary>
        public async void ExportListView()
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
                                //escape any text including commas, backslash, next line in order to convert it to .csv
                                //CsvConversion.ConvertStringToCsv(item.ToString());

                                stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                                    item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text,
                                    item.SubItems[6].Text, item.SubItems[7].Text));

                                //stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                                //    item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text,
                                //    item.SubItems[6].Text, item.SubItems[7].Text));
                            }
                            
                            await streamWriter.WriteLineAsync(stringBuilder.ToString());
                            MessageBox.Show("Your data has been successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
