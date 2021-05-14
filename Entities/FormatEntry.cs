using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// The type of format the reader chooses to download the book title.
    /// Where the publication's format type is stored.
    /// Where the total count of how many publications are borrowed is stored.
    /// </summary>
    public class FormatEntry
    {
        public Format BookFormat { get; set; }
        public int BorrowedCount { get; set; }
    }
}
