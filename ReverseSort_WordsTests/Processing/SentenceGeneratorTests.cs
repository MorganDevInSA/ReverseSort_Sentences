using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections;

namespace ReverseSort_Words.Input.Tests
{
    [TestClass()]
    public class SentenceGeneratorTests
    {
        [TestMethod]
        public void ProcessSentence_AddsToArrayList()
        {
            ArrayList sentenceList = new ArrayList();
            string caseDesignator = "Case: ";

            string inputSentence = "This is a test sentence";
            string reversedSentence = "Case:  sentence test a is This";

            using (System.IO.StringReader sr = new System.IO.StringReader(inputSentence + Environment.NewLine))
            {
                Console.SetIn(sr);
                SentenceGenerator.ProcessSentence(sentenceList, caseDesignator);
            }

            Assert.AreEqual(1, sentenceList.Count);

            string[] words = (string[])sentenceList[0];
            string processedSentence = string.Join(" ", words);

            Assert.AreEqual(reversedSentence, processedSentence);
            Assert.IsTrue(processedSentence.StartsWith(caseDesignator));
        }

        [TestMethod]
        public void ProcessSentence_EmptyInput_DoesNotAddToArrayList()
        {
            ArrayList sentenceList = new ArrayList();
            string[] firstArray = new string[] { "This", "is", "the", "first", "array" };
            string[] secondArray = new string[] { "Another", "array", "of", "strings" };

            sentenceList.Add(firstArray);
            sentenceList.Add(secondArray);

            string caseDesignator = "Case: ";

            string inputSentence = ""; 
            int initialCount = 3;

            using (System.IO.StringReader sr = new System.IO.StringReader(inputSentence + Environment.NewLine))
            {
                Console.SetIn(sr);
                SentenceGenerator.ProcessSentence(sentenceList, caseDesignator);
            }

            Assert.AreEqual(initialCount, sentenceList.Count);
        }
    }
}