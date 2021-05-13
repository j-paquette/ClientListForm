using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Reader will choose their preferred reading language. 
    /// </summary>
    public class Language
    {
        public string English { get; set; }
        public string French { get; set; }
        public string Inuktitut { get; set; }
        public string Any { get; set; }
    }
}
