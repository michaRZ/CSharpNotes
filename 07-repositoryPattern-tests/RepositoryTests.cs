using _07_repositoryPattern_repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_repositoryPattern_tests
{
    [TestClass]
    public class RepositoryTests
    {
        // create field to hold onto repo, so all test methods can refer back to this field if desired
        private StreamingContentRepository _repo;
        // create field to hold onto content, so we can access it anywhere in tests
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();

            StreamingContent _content = new StreamingContent("Inglorious Basterds", "Tarantino masterpiece", 5.0, MaturityRating.R, GenreType.Comedy);

            _repo.AddContentToDirectory(_content);
        }



        [TestMethod]
        public void AddContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent();
            content.Title = "Harry Potter and the Sorcerer's Stone";

            // Act
            bool addResult = repo.AddContentToDirectory(content);

            // Assert
            Assert.IsTrue(addResult);
        }



        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // Create new repo
            StreamingContentRepository repo = new StreamingContentRepository();

            // Create new content for repo
            StreamingContent content = new StreamingContent();
            content.Title = "Old Yeller";

            // Add content to repo
            repo.AddContentToDirectory(content);

            // Make list of contents to hold each content
            List<StreamingContent> contents = repo.GetContents();

            // Check whether content is in contents list
            bool directoryHasContent = contents.Contains(content);

            // Push result in test
            Assert.IsTrue(directoryHasContent);
        }



        [TestMethod]
        public void GetContentByTitle_ShouldGetCorrectContent()
        {
            StreamingContent content = _repo.GetContentByTitle("Inglorious Basterds");

            // Assert to test output if expected == actual
            Assert.AreEqual(_content, content);
        }


        [TestMethod]
        public void GetFamilyFriendlyContent_ShouldAllBeFamilyFriendly()
        {
            // create a couple new StreamingContent items
            StreamingContent safeItem = new StreamingContent();
            StreamingContent unsafeItem = new StreamingContent("Taken", "Liam Neeson kicking butt to save his daughter", 5.0, MaturityRating.TVMA, GenreType.Action);

            // Give safeItem a family-friendly rating
            safeItem.MaturityRating = MaturityRating.G;

            _repo.AddContentToDirectory(safeItem);
            _repo.AddContentToDirectory(unsafeItem);

            List<StreamingContent> familyFriendlyContents = _repo.GetFamilyFriendlyContent();


            // bool hasUnsafeContent = false;
            // Loop thru list
            //    if not family friendly
            //      hasUnsafeContent = true;
            //      break;
            // Assert hasUnsafeContent is false


            // create var to store number of unsafe items from familyFriendlyContents list
            // there should be no movies in unsafeItems, because the list supposed to only have movies that passed the family-friendly requirements
            // the code below checks that the GetFamilyFriendlyContent method works correctly
            int unsafeItems = familyFriendlyContents.Where(s => !s.IsFamilyFriendly).ToList().Count;
            Assert.AreEqual(0, unsafeItems);
        }



        [TestMethod]
        public void UpdateExistingContent_ShouldUpdate()
        {
            StreamingContent newData = new StreamingContent("Inglorious Basterds", "Correction: 2nd best movie from Tarantine", 4.5, MaturityRating.R, GenreType.Action);

            _repo.UpdateExistingContent("Inglorious Basterds", newData);


            // check if it updated
            var expected = GenreType.Action;
            var actual = _content.GenreType;
            Assert.AreEqual(expected, actual);
        }
    }
}
