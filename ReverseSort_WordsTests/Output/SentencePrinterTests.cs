using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections;

namespace ReverseSort_Words.Output.Tests
{
    [TestClass]
    public class SentencePrinterTests
    {
        [TestMethod]
        public void Print_NoSentences_DoesNotPrintAnything()
        {
            ArrayList emptyList = new ArrayList();

            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                SentencePrinter.Print(emptyList);
                Assert.AreEqual("", sw.ToString().Trim()); 
            }
        }

        [TestMethod]
        public void Print_OneSentence_PrintsCorrectly()
        {
            ArrayList sentenceList = new ArrayList { new string[] { "Hello", "world!" } };
            string expectedOutput = "Hello world!";
            
            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                SentencePrinter.Print(sentenceList);
                Assert.AreEqual(expectedOutput, sw.ToString().Trim()); 
            }
        }

        [TestMethod]
        public void Print_MultipleSentences_PrintsAllCorrectly()
        {
            ArrayList sentenceList = new ArrayList
        {
            new string[] { "This", "is", "sentence", "1" },
            new string[] { "Another", "sentence", "2" },
            new string[] { "And", "a", "third", "sentence", "3" }
        };
            string expectedOutput = "This is sentence 1\r\nAnother sentence 2\r\nAnd a third sentence 3";

            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                SentencePrinter.Print(sentenceList);
                Assert.AreEqual(expectedOutput, sw.ToString().Trim()); 
            }
        }
    }
}