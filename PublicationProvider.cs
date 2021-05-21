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
    public class PublicationProvider : LibraryProvider
    {
        public List<Language> Languages { get; set; }

        public PublicationProvider() //: this(new List<Language>())
        {
            this.Languages = new List<Language>();
            this.Languages.Add(new Language()
            {
                Code = "1",
                Name = "English"
            });
            this.Languages.Add(new Language()
            {
                Code = "2",
                Name = "French"
            });
        }

        public PublicationProvider(List<Language> languages)
        {
            this.Languages = languages;
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
            return new Library { Titles = publicationTitles, InventoryDate = DateTime.Now };
        }

        /// <summary>
        /// This method populates publicationTitleList with hard-coded values
        /// </summary>
        /// <param name="publicationTitleList"></param>
        public void UpdateListWithPublicationTitle(List<PublicationTitle> publicationTitleList)
        {
            PublicationTitle publication;

            publication = new PublicationTitle()
            {
                Title = "Where'd You Go, Bernadette",
                TargetAudience = Audience.GeneralContent,
                Author = "Maria Semple",
                MainSubject = Subject.Fiction,
                Available = true,
                PublicationDate = DateTime.Now,
            };

            publication.Formats.Add(new FormatEntry()
            {
                BookFormat = Format.Ebook,
                BorrowedCount = 1
            });

            publication.PublicationLanguages.Add(this.Languages[0]);

            publicationTitleList.Add(publication);

            //add new record
            publication = new PublicationTitle()
            {
                Title = "Found her!",
                TargetAudience = Audience.GeneralContent,
                Author = "Maria Semple",
                MainSubject = Subject.Fiction,
                Available = true,
                PublicationDate = DateTime.Now,
            };

            publication.Formats.Add(new FormatEntry()
            {
                BookFormat = Format.Ebook,
                BorrowedCount = 2
            });

            publication.PublicationLanguages.Add(this.Languages[0]);
            publication.PublicationLanguages.Add(this.Languages[1]);

            publicationTitleList.Add(publication);

            //TODO: add more records with different selections (ie, languages, etc in the wrong sorting order to test the sort
            //TODO: after previous TODO add filter for records
        }
    }
}
