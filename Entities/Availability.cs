using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Whether the book title selected is available or not.
    /// Where the Availability details object is stored.
    /// Similar to EWSUserDetails.Entities.WebServiceEntry
    /// </summary>
    public class Availability
    {
        public bool AvailableNow { get; set; }
        public bool Everything { get; set; }
    }
}
