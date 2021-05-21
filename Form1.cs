using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientListForm;
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
            Library library = publicationProvider.GetLibraryData();
            //TODO: add clear, so I don't add multiple records
            //TODO: check properties for sorting
            //TODO: move the event handler to load records into a separate method.
            foreach (PublicationTitle title in library.Titles)
            {
                //TODO: create a ListViewItem
                ListViewItem row = new ListViewItem(title.Title);
                row.SubItems.Add(title.Author);
                row.SubItems.Add(title.TargetAudience.ToString());

                //TODO: instead of var, IEnumerable<string>
                //Select is a functional programming
                var languages = title.PublicationLanguages.Select(l => l.Name);
                //TODO: lookup "Join" docs, and add explanation later
                string languagesText = string.Join(", ", languages);

                row.SubItems.Add(languagesText);

                this.lv_Library.Items.Add(row);
                
            }

            this.lv_Library.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //TODO: set the Updated label value to library.InventoryDate
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
