using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_repositoryPattern_repository
{
    public class StreamingContent
    {

        //Properties

        private string _title; // backing field for Title property
    public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value.ToUpper();
            }
        }
    public string Description { get; set; }
    public double StarRating { get; set; }
    public MaturityRating MaturityRating { get; set; }
    public bool IsFamilyFriendly {
            get
            {
                switch(MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG13:
                    case MaturityRating.TVG:
                    case MaturityRating.TVY:
                        return true;
                    default:
                        return false;
                }
                 
            }
        }
    public GenreType GenreType { get; set; }




        // Constructors

        public StreamingContent() { }

        public StreamingContent(string title, string description, double stars, MaturityRating maturityRating, GenreType genre)
        {
            /* if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Content needs a title!")
            } */ 
            Title = title;
            Description = description;
            StarRating = stars;
            MaturityRating = maturityRating;
            // IsFamilyFriendly = familyFriendly; // don't need this anymore, only setting value based on MaturityRating
            GenreType = genre;
        }


    }


}

public enum MaturityRating { G = 1, PG, PG13, NC17, R, TVG, TVY, TVMA }

public enum GenreType { SciFi = 1, Comedy, Horror, RomCom, Documentary, Western, Action}
