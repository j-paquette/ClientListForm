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
            }); ; ;
            this.Languages.Add(new Language()
            {
                Code = "2",
                Name = "French"
            });
            this.Languages.Add(new Language()
            {
                Code = "3",
                Name = "Inuktut"
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
            //TODO: find a simple way to add multithreading for when getting records from db takes along time
            //uncomment to simulate the app taking a long time to run
            //System.Threading.Thread.Sleep(45000);

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

            //add new record
            publication = new PublicationTitle()
            {
                Title = "Where'd You Go, Bernadette",
                TargetAudience = Audience.GeneralContent,
                Author = "Maria Semple",
                MainSubject = Subject.Fiction,
                Available = true,
                PublicationDate = new DateTime(2012, 08, 13),
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
                PublicationDate = new DateTime(2013, 04, 22),
            };

            publication.Formats.Add(new FormatEntry()
            {
                BookFormat = Format.Ebook,
                BorrowedCount = 2
            });

            publication.PublicationLanguages.Add(this.Languages[0]);
            publication.PublicationLanguages.Add(this.Languages[1]);

            publicationTitleList.Add(publication);

            //add new record
            publication = new PublicationTitle()
            {
                Title = "Grasp",
                TargetAudience = Audience.GeneralContent,
                Author = "Sanjay Sarma",
                MainSubject = Subject.Nonfiction,
                Available = false,
                PublicationDate = new DateTime(2020, 08, 18),
            };

            publication.Formats.Add(new FormatEntry()
            {
                BookFormat = Format.Audiobook,
                BorrowedCount = 1
            });

            publication.PublicationLanguages.Add(this.Languages[0]);

            publicationTitleList.Add(publication);

            //add new record
            publication = new PublicationTitle()
            {
                Title = "Arsene Lupin, gentleman-cambrioleur",
                TargetAudience = Audience.GeneralContent,
                Author = "Maurice Leblanc",
                MainSubject = Subject.Fiction,
                Available = true,
                PublicationDate = new DateTime(1907, 06, 10),
            };

            publication.Formats.Add(new FormatEntry()
            {
                BookFormat = Format.Ebook,
                BorrowedCount = 1
            });

            publication.PublicationLanguages.Add(this.Languages[1]);

            publicationTitleList.Add(publication);

            //add new record
            publication = new PublicationTitle()
            {
                Title = "Squeeze Me",
                TargetAudience = Audience.YoungAdult,
                Author = "Carl Hiaasen",
                MainSubject = Subject.Mystery,
                Available = false,
                PublicationDate = new DateTime(2020, 08, 24),
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
                Title = "Protegez-vous",
                TargetAudience = Audience.GeneralContent,
                Author = "Québec ex.",
                MainSubject = Subject.Nonfiction,
                Available = true,
                PublicationDate = new DateTime(1973, 03, 10),
            };

            publication.Formats.Add(new FormatEntry()
            {
                BookFormat = Format.Magazine,
                BorrowedCount = 1
            });

            publication.PublicationLanguages.Add(this.Languages[1]);
            publication.PublicationLanguages.Add(this.Languages[2]);


            publicationTitleList.Add(publication);
        }
    }
}
