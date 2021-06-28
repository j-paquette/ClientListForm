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
        public List<PublicationTitle> Titles { get; set; } 
        public DateTime InventoryDate { get; set; }

        //GetByServiceName in ClientListReport
        public IEnumerable<PublicationTitle> GetTitlesByLanguageName(string languageName)
        {
            IEnumerable<PublicationTitle> filterByLanguageName = this.Titles.Where(t => t.PublicationLanguages.Any(l => l.Name.Equals(languageName)));

            return filterByLanguageName;
        }
    }
}
