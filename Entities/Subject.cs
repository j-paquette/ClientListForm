using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Reader chooses which subject to filter their search. 
    /// </summary>
    public class Subject
    {
        public string Fiction { get; set; }
        public string Nonfiction { get; set; }
        public string Mystery { get; set; }
        public string Humour { get; set; }
    }
}
