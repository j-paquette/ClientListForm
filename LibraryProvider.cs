using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientListForm.Entities;

namespace ClientListForm
{
    /// <summary>
    /// LibraryProvider is the base class for the method GetLibraryData
    /// </summary>
    public abstract class LibraryProvider
    {
        public abstract Library GetLibraryData();
    }
}
