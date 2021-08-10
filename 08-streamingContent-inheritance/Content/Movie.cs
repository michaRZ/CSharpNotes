using _07_repositoryPattern_repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_streamingContent_inheritance.Content
{
    public class Movie : StreamingContent // now Movie has all properties of StreamingContent
    {
        // PROPERTIES
        public double RunTime { get; set; }


        // CONSTRUCTORS
        public Movie() { }


        // overloaded constructor
        // Constructors can inhereit, too!
        // using ': base()' after new constructor with all constructor values from inherited class will save with the original constructor class
        public Movie(string title, string description, double stars, MaturityRating rating, GenreType genre, double runTime) : base(title, description, stars, rating, genre)
        {
            RunTime = runTime; // since all other properties values are inherited, we only need to set new movie class property of RunTime
        }
    }
}
