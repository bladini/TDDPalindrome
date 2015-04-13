using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeCLib;
namespace Palindrome.IntegrationTest
{
    [TestClass]
    public class PalindromeIntegrationTests
    {
        private PalindromeValidator _pValidator = null;
        [TestInitialize]
        public void TestInit()
        {
            _pValidator = new PalindromeValidator();
        }
        [TestMethod]
        public void ValidatePalindromeNumberValueTest()
        {
            // Arrange
            string value = "9547459";
            string expected = "Value is Palindrome and it is 7 digits number.";
            // Act
            string actual = _pValidator.ValidateValue(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePalindromeWordValueTest()
        {
            // Arrange
            string value = "abcdcba";
            string expected = "Value is Palindrome and it is 7 characters word.";
            // Act
            string actual = _pValidator.ValidateValue(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotPalindromeValueTest()
        {
            // Arrange
            string value = "5d8a4d";
            string expected = "Value is not Palindrome.";
            // Act
            string actual = _pValidator.ValidateValue(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Negative cases
        [TestMethod]
        public void ValidatePalindromeInputLengthLessThanRequiredTest()
        {
            // Arrange
            string value = "a";
            string expected = "Error: Input number/word must have more than 1 digits/characters.";
            // Act
            string actual = _pValidator.ValidateValue(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePalindromeWithNullValueTest()
        {
            // Arrange
            string value = null;
            string expected = "Value cannot be null.";
            // Act
            string actual = _pValidator.ValidateValue(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePalindromeWithSpaceInValueTest()
        {
            // Arrange
            string value = "123 321";
            string expected = "Error: Input number/word must not have space.";
            // Act
            string actual = _pValidator.ValidateValue(value);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
