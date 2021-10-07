using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// Where the book title details object is stored.
    /// Similar to EWSUserDetails.Entities.ClientData?? Or EWSUserDetails.Entities.ClientEntry??
    /// TODO: research What is the difference between an object property versus a list property. Look up: difference between class and object.
    /// For example, ClientEntry in AccountWebServiceStats
    /// Info versus ClientEntry in ClientData?
    /// </summary>
    public class PublicationTitle
    {
        public string Title { get; set; }
        public Audience TargetAudience { get; set; }
        public string Author { get; set; }
        public List<Language> PublicationLanguages { get; set; } = new List<Language>();
        public List<FormatEntry> Formats { get; set; } = new List<FormatEntry>();
        public Subject MainSubject { get; set; } 
        public bool Available { get; set; }
        public DateTime PublicationDate { get; set; }
        public Uri GetUrl { get; set; }

        public bool HotTracking { get; set; }
    }
}
