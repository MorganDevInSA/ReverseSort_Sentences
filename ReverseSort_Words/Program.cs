using ReverseSort_Words.Input;
using ReverseSort_Words.Output;

using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int userInput;
        ArrayList sentenceList = new ArrayList();

        bool tryAgain;
        do
        {
            Console.Clear();

            userInput = UserInputValidator.GetValidNumberInput(1, 25, "Please enter a number between 1 and 25, this will specify the number of sentences to sort: ");
            ArrayList sentenceListString = SentenceGenerator.GenerateSentenceList(userInput, sentenceList);
            tryAgain = SentencePrinter.PrintSentences(sentenceListString);

        } while (tryAgain);

        Console.Clear();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); 
    }
}