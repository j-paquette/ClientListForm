using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Where the reader type object is stored.
    /// Similar to EWSUserDetails.Entities.WebServiceEntry
    /// </summary>
    public class Audience
    {
        public string Juvenile { get; set; }
        public string YoungAdult { get; set; }
        public string GeneralContent { get; set; }
        public string MatureContent { get; set; }
    }
}
