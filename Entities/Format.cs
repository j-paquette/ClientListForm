using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// The type of format the reader chooses to download the book title.
    /// </summary>
    public class Format
    {
        public string Ebook { get; set; }
        public string Audiobook { get; set; }
        public string Magazines { get; set; }
    }
}
