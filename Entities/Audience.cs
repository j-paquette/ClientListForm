using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// The reader can choose the book they want filtered by content type.
    /// Where the reader type object is stored.
    /// Similar to EWSUserDetails.Entities.WebServiceEntry
    /// </summary>
    public enum Audience
    {
        Juvenile,
        YoungAdult,
        GeneralContent,
        MatureContent
    }
}
