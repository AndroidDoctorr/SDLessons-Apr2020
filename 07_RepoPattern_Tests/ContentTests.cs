using System;
using _07_RepoPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepoPattern_Tests
{
    [TestClass]
    public class ContentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // A A A Test Pattern

            // Arrange
            StreamingContent streamingContent = new StreamingContent();

            // Act
            streamingContent.Title = "Freaked!";

            string expected = "Freaked!";
            string actual = streamingContent.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FamilyFriendlyTest()
        {
            // Arrange
            StreamingContent content = new StreamingContent();

            // Act
            content.Title = "Freaked!";
            content.MaturityRating = MaturityRating.PG_13;

            bool expected = false;
            bool actual = content.IsFamilyFriendly;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.R, false)]
        [DataRow(MaturityRating.TV_G, true)]
        [DataRow(MaturityRating.TV_PG, true)]
        [DataRow(MaturityRating.TV_MA, false)]
        [DataRow(MaturityRating.NC_17, false)]
        [DataRow(MaturityRating.PG_13, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(
            MaturityRating rating,
            bool expectedFamilyFriendly
        )
        {
            StreamingContent content = new StreamingContent();
            content.MaturityRating = rating;

            bool actual = content.IsFamilyFriendly;

            Assert.AreEqual(expectedFamilyFriendly, actual);
        }
    }
}
