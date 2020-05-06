using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern_Repository
{
    public enum GenreType { Horror = 1, Comedy, SciFi, Documentary, Drama, Action, Bromance, Christmas }
    public enum MaturityRating { G, PG, PG_13, R, NC_17, TV_Y, TV_G, TV_PG, TV_MA, U }

    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch(MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public string Director { get; set; }
        public GenreType Genre { get; set; }

        public StreamingContent() { }
        public StreamingContent(
            string title,
            string description,
            double starRating,
            MaturityRating maturityRating,
            GenreType genre
        )
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = maturityRating;
            Genre = genre;
        }
    }
}
