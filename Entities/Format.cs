using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm.Entities
{
    /// <summary>
    /// The reader can only choose from the list of formats listed.
    /// Where the format type object is stored.
    /// Creates a new object with type Format, but this is still a class.
    /// </summary>
    public enum Format
    {
        Ebook,
        Audiobook,
        Magazine
    }
}
