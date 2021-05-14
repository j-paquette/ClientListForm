using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Where the PublicationTitle details are stored.
    /// </summary>
    public class Library
    {
        public List<PublicationTitle> Titles { get; set; } = new List<PublicationTitle>();
        public DateTime InventoryDate { get; set; }
    }
}
