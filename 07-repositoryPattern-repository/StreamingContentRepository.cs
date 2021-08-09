using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_repositoryPattern_repository
{
    public class StreamingContentRepository
    {
        // Simulate a database

        // Repository pattern - database or list + CRUD methods (just a way of setting up code)
        // CRUD: 
        // Create
        // Read
        // Update
        // Delete


        // Reference repository
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();



        // 1 - Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content); // will increase count by 1 if added

            bool wasAdded = _contentDirectory.Count > startingCount; // will tell whether content was added
            return wasAdded;
        }
        


        // 2 - Read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }


        public StreamingContent GetContentByTitle(string title)
        {
            // Loop through the list
            //      If content item has correct title
            //          return the item
            //  return null or throw error if no item found
            foreach(StreamingContent item in _contentDirectory)
            {
                if (item.Title == title)
                {
                    return item;
                }
            }
            return null;
        }


        // Create a method that returns only family-friendly content in a list
        public List<StreamingContent> GetFamilyFriendlyContent()
        {
            // get all contents
            // make empty list
            // loop through
            //      if friendly
            //          add to list
            // return the list

            List<StreamingContent> contents = GetContents(); // make full list of contents, then loop thru it
            List<StreamingContent> familyFriendlyContents = new List<StreamingContent>(); // make empty list, add relevant content to make it family-friendly list

            foreach (StreamingContent item in contents)
            {
                if (item.IsFamilyFriendly)
                {
                    familyFriendlyContents.Add(item); // syntax for adding items
                }
            }
            return familyFriendlyContents; // return the completed new list


            // fancy methods using LINQ
            // long version above is what .Where() is doing
            //                            // => is a lambda expression 
            // return GetContents().Where(s => s.IsFamilyFriendly).ToList();
            // return _contentDirectory.Where(s => s.IsFamilyFriendly).ToList();
        }


        // Challenge:
        // Create a method to return movies by genre (GetContentsByGenre)
        public List<StreamingContent> GetContentsByGenre(GenreType genre)
        {

            // get full list of contents
            // loop thru contents
            //      if content is genre, add to genretype list
            //          add to the list
            // return the list


            // LINQ quick and fancy way to pull lists of genre types
            return GetContents().Where(s => s.GenreType == genre).ToList();
        }




        // 3 - Update
        // we'll pass in 2 parameters
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;

                return true;
            }
            else
            {
                return false;
            }
        }




        // 4 - Delete
        //                           // we'll require this parameter passed in for this method
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
