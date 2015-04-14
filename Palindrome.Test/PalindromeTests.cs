using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeCLib;

namespace Palindrome.Test
{
    [TestClass]
    public class PalindromeTests
    {
        private PalindromeFinder _palindromeFinder = null;
        [TestInitialize]
        public void InitTest()
        {
            _palindromeFinder = new PalindromeFinder();
        }
        #region Positive Cases
        [TestMethod]
        public void IsPalindromeReturnFalse()
        {
            // Arrange
            string value = "222145";
            bool expected = false;
            // Act
            bool actual = _palindromeFinder.IsPalindrome(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsPalindromeReturnTrue()
        {
            // Arrange
            string value = "rotator";
            bool expected = true;
            // Act
            bool actual = _palindromeFinder.IsPalindrome(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsNumberReturnTrue()
        {
            // Arrange
            string value = "8851588";
            bool expected = true;
            // Act
            bool actual = _palindromeFinder.IsNumber(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsNumberReturnFalse()
        {
            // Arrange
            string value = "word";
            bool expected = false;
            // Act
            bool actual = _palindromeFinder.IsNumber(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CharacterCountReturnCount()
        {
            // Arrange
            string value = "8851588";
            int expected = 7;
            // Act
            int actual = _palindromeFinder.CharacterCount(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion Positive Cases

        #region Negative Cases
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindromeThrowsArgumentNullException()
        {
            // Arrange
            string value = null;
            //  Act
            bool actual = _palindromeFinder.IsPalindrome(value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsPalindromeThrowsArgumentException()
        {
            // Arrange
            string value = "a";
            // Act
            bool actual = _palindromeFinder.IsPalindrome(value);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IsPalindromeThrowsException()
        {
            // Arrange
            string value = "222 145";
            // Act
            bool actual = _palindromeFinder.IsPalindrome(value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsNumberThrowArgumentNullException()
        {
            // Arrange
            string value = null;
            // Act
            bool actual = _palindromeFinder.IsNumber(value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CharacterCountThrowArgumentNullException()
        {
            // Arrange
            string value = null;
            // Act
            int actual = _palindromeFinder.CharacterCount(value);
        }
        #endregion Negative Cases

        #region Impossible Cases
        [TestMethod]
        public void impossibleTestWillFail()
        {
            
            // Assert
            Assert.AreEqual(0, 1);
        }
        #endregion
    }
}
