using ClientListForm.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientListForm
{
    
        // Implements the manual sorting of items by columns.
        class ListViewItemComparer : IComparer
        {
            [System.ComponentModel.Browsable(false)]
            public System.Collections.IComparer ListViewItemSorter { get; set; }

            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    
}

