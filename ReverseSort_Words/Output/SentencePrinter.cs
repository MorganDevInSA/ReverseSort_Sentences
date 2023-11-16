using System.Collections;

namespace ReverseSort_Words.Output
{
    public class SentencePrinter
    {
        public static void Print(ArrayList sentenceListString)
        {
            foreach (string[] wordsArray in sentenceListString)
            {
                string sentence = string.Join(" ", wordsArray);
                Console.WriteLine(sentence);
            }
        }

        public static bool PrintSentences(ArrayList sentenceListString)
        {
            Print(sentenceListString);

            Console.WriteLine("");
            Console.WriteLine("Would you like to try again? (yes/no)");
            Console.WriteLine("");

            string userReply = Console.ReadLine();
            bool tryAgain = userReply.ToLower() == "yes";

            return tryAgain;
        }
    }
}
