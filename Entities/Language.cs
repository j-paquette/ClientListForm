using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Reader will choose their preferred reading language.
    /// TODO: Add a hard-coded list of languages by name and the code assigned to it.
    /// Similar to ClientListReport.Entities.WebServiceEntry??
    /// </summary>
    public class Language
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
