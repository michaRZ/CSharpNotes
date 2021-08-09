using _07_repositoryPattern_repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_repositoryPattern_tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            StreamingContent movie = new StreamingContent();
            Console.WriteLine($"{movie.Title} is a {movie.GenreType} movie about {movie.Description}, rated {movie.MaturityRating}.");
        }


        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            // AAA Pattern - 3 Part Test Process

            // Arrange
            StreamingContent content = new StreamingContent();
            // Act
            content.Title = "Kill Bill";
            // Assert - 'Assert' class comes built-in with TestMethods
            string expected = "Kill Bill";
            string actual = content.Title;
            Assert.AreEqual(expected, actual); // this test should fail bc actual and expected are different
        }



        [DataTestMethod] // This allows you to pass in parameters and test individually for those
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG13, true)]
        [DataRow(MaturityRating.NC17, false)]
        [DataRow(MaturityRating.TVG, true)]
        [DataRow(MaturityRating.TVMA, false)]
        [DataRow(MaturityRating.TVY, false)] // ex. this one will FAIL bc the TVY rating should qualify as IsFamilyFriendly = true;
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldGetCorrectFamilyFriendly(MaturityRating rating, bool expected) // good practive to give detailed test names
        {
            // AAA Pattern
            // Arrange
            StreamingContent content = new StreamingContent("Lord of the Rings", "A hobbit takes a fateful adventure", 5.0, rating, GenreType.Action);

            // Act
            bool actual = content.IsFamilyFriendly;
            // bool expected = true; // this is now defined DataTestMethod as parameter

            // Assert
            Assert.AreEqual(expected, actual);
            // Assert.IsTrue(actual); // another way to test the above if expecting true every time (which we aren't)

        }
    }
}
