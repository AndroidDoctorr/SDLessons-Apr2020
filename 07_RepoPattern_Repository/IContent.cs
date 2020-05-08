using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern_Repository
{
    public interface IContent
    {
        string Title { get; }
        string Description { get; }
        double StarRating { get; }
        MaturityRating MaturityRating { get; }
        bool IsFamilyFriendly { get; }
        GenreType Genre { get; }
    }
}
