using _07_repositoryPattern_repository;
using _08_streamingContent_inheritance.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_streamingContent_inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                // another more readble way to write it:
                // if (content is Show && ... )
                if (content.GetType() == typeof(Show) && content.Title == title)
                {
                    return (Show) content; //cast 'type' of Show onto content
                }
            }
            return null; // return null if no matches found

            // fancy way with LINQ
            // .FirstOrDefault loops thru list
            // returns first value that matches Lambda expression, or default if it finds nothing (which will return null)
            // return (Show)_contentDirectory.FirstOrDefault(s = > s is Show && s.Title == title);
        }

        public Movie GetMovieByTitle(string title)
        {
            return (Movie)_contentDirectory.FirstOrDefault(s => s is Movie && s.Title == title);
        }


        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;


            // LINQ way
            // 1 - searches content directory for all content that is a Show
            // 2 - cast Show over list to convert to Show type // cast - converts a type to another compatible type
            // 3 - put content in a list

            //        // 1                                  // 2        // 3
            return _contentDirectory.Where(s => s is Show).Cast<Show>().ToList();
        }

        public List<Movie> GetAllMovies()
        {
            return _contentDirectory.Where(s => s is Movie).Cast<Movie>().ToList();
        }

        



        // CHALLENGES:

        // Get Movies by Star Rating

        public List<Movie> GetMoviesByStarRating(double stars)
        {
            return GetAllMovies().Where(m => m.StarRating >= stars).ToList();
        }

        // Get Shows by Star Rating
        public List<Show> GetShowsByStarRating(double stars)
        {
            return GetAllShows().Where(s => s.StarRating >= stars).ToList();
        }




        // Get Movies by Maturity Rating
        public List<Movie> GetMoviesByMaturityRating(MaturityRating rating)
        {
            
            return GetAllMovies().Where(m => m.MaturityRating <= rating).Cast<Movie>().ToList();
        } 


        // Get Shows by Maturity Rating
        public List<Show> GetShowsByMaturityRating(MaturityRating rating)
        {

            return GetAllShows().Where(s => s.MaturityRating <= rating).Cast<Show>().ToList();
        }





        // Get Movies by Genre
        public List<Movie> GetMoviesByGenre(GenreType genre)
        {
            return GetAllMovies().Where(m => m.GenreType == genre).Cast<Movie>().ToList();
        }



        // Get Shows by Genre
        public List<Show> GetShowsByGenre(GenreType genre)
        {
            return GetAllShows().Where(s => s.GenreType == genre).Cast<Show>().ToList();
        }

    }
}
