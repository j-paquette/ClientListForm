using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientListForm.Entities;

namespace ClientListForm
{
    /// <summary>
    /// Creates an empty list called publicationTitles and populates it with hard-coded values.
    /// The list will be used to display the results to the Windows form Listview.
    /// </summary>
    public class LibraryDetails : LibraryProvider
    {
        public string LanguageCode { get; set; }

        public string LanguageName { get; set; }

        public LibraryDetails() : this(new Language(), "1", "English")
        {

        }

        public LibraryDetails(Language language, string languageCode, string languageName)
        {
            Language languageDetails = new Language();

            this.LanguageCode = languageCode;
            this.LanguageName = languageName;
        }

        /// <summary>
        /// Returns a list publicationTitles which is populated by hard-coded values from method UpdateListWithPublicationTitle.
        /// </summary>
        /// <returns></returns>
        public override Library GetLibraryData()
        {
            List<PublicationTitle> publicationTitles = new List<PublicationTitle>();

            UpdateListWithPublicationTitle(publicationTitles);

            //A more detailed example to show the process
            //var data = new Library();
            //data.Titles = publicationTitles;
            //return data;
            return new Library { Titles = publicationTitles };
        }

        /// <summary>
        /// This method populates publicationTitleList with hard-coded values
        /// </summary>
        /// <param name="publicationTitleList"></param>
        public void UpdateListWithPublicationTitle(List<PublicationTitle> publicationTitleList)
        {
            PublicationTitle publications;

            publications = new PublicationTitle()
            {
                Title = "Where'd You Go, Bernadette",
                TargetAudience = Audience.GeneralContent,
                Author = "Maria Semple",
                this.LanguageCode = "1",
                this.LanguageName,
                MainSubject = Subject.Fiction,
                Available = true,
                PublicationDate = DateTime.Now,
            }

            publicationTitleList.Add(publications);

            publications.Formats.Add(new FormatEntry()
            {
                BookFormat = Format.Ebook,
                BorrowedCount = 1
            });

            publications.PublicationLanguageAdd(new Language()
            {

            })
        }
    }
}
