using System.Collections;
using System.Text.RegularExpressions;

namespace ReverseSort_Words.Input
{
    public class SentenceGenerator
    {
        public static ArrayList ProcessSentence(ArrayList sentenceList, string caseDesignator)
        {
            string sentence = Console.ReadLine();
            sentence = Regex.Replace(sentence, @"\s+", " ").Trim();
            string[] words = sentence.Split(' ');

            Array.Reverse(words);

            List<string> wordsList = words.ToList();
            wordsList.Insert(0, caseDesignator);
            words = wordsList.ToArray();

            sentenceList.Add(words);

            return sentenceList;
        }

        public static ArrayList GenerateSentenceList(int userInput, ArrayList sentenceList)
        {
            Console.Clear();

            for (int i = 1; i <= userInput; i++)
            {
                string caseDesignator = "Case " + i + ": ";
                Console.WriteLine($"Please enter sentence number {i} using only single spaces between words");
                Console.WriteLine("");

                sentenceList = ProcessSentence(sentenceList, caseDesignator);

                Console.Clear();
            }

            return sentenceList;
        }
    }
}