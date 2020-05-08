using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern_Repository
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }
        public string Studio { get; set; }
        public double BoxOfficeTake { get; set; }

        public Movie() { }

        public Movie(
            string title,
            string description,
            double starRating,
            double runTime,
            double boxOffice,
            MaturityRating maturityRating,
            GenreType genre
        )
            : base(title, description, starRating, maturityRating, genre)
        {
            RunTime = runTime;
            BoxOfficeTake = boxOffice;
        }

        /*
        public Movie(blah blah blah)
        {
            Title = title;
            Description = description;
            etc...
        }
        */
    }
}
