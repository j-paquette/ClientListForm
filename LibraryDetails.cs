using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientListForm.Entities;

namespace ClientListForm
{
    public class LibraryDetails : LibraryProvider
    {
        public override Library GetLibraryData()
        {
            List<PublicationTitle> publicationTitles = new List<PublicationTitle>();
        }

        public void UpdateListWithPublicationTitle(List<PublicationTitle> publicationTitleList)
        {
            PublicationTitle publications;

            publications = new PublicationTitle()
            {
                Title = "Where'd You Go, Bernadette",
                TargetAudience = Audience.GeneralContent,
            }
        }
    }
}
