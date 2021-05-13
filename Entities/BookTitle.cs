using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Where the book title details object is stored.
    /// Similar to EWSUserDetails.Entities.CientEntry
    /// What is the difference between an object property versus a list property? 
    /// For example, ClientEntry in AccountWebServiceStatsInfo versus ClientEntry in ClientData?
    /// </summary>
    public class BookTitle
    {
        public string Title { get; set; }
        public Audience Audience { get; set; }
        public string Author { get; set; }
        public Language Language { get; set; }
        public Format Format { get; set; }
        public Subject Subject { get; set; } 
        public List<Availability> AvailabilityOptions { get; set; } = new List<Availability>();
    }
}
