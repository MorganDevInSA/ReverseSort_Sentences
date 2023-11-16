using Microsoft.VisualStudio.TestTools.UnitTesting;

using ReverseSort_Words.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSort_Words.Input.Tests
{
    [TestClass()]
    public class UserInputValidatorTests
    {
        [TestMethod]
        public void ValidateInput_ValidInput_ReturnsTrueAndValue()
        {
            string input = "15";
            int minValue = 10;
            int maxValue = 20;

            (bool isValid, int userInput) result = UserInputValidator.ValidateInput(input, minValue, maxValue);

            Assert.IsTrue(result.isValid);
            Assert.AreEqual(15, result.userInput);
        }

        [TestMethod]
        public void ValidateInput_InvalidInput_ReturnsFalseAndZeroValue()
        {
            string input = "abc";
            int minValue = 10;
            int maxValue = 20;

            (bool isValid, int userInput) result = UserInputValidator.ValidateInput(input, minValue, maxValue);

            Assert.IsFalse(result.isValid);
            Assert.AreEqual(0, result.userInput);
        }

        [TestMethod]
        public void ValidateInput_OutOfRange_ReturnsFalseAndValue()
        {
            string input = "25";
            int minValue = 10;
            int maxValue = 20;

            (bool isValid, int userInput) result = UserInputValidator.ValidateInput(input, minValue, maxValue);

            Assert.IsFalse(result.isValid);
            Assert.AreEqual(25, result.userInput);
        }
    }
}