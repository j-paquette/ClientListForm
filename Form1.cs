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
            publicationProvider.GetLibraryData();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            publicationProvider.GetLibraryData();
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
