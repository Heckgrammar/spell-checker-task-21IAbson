using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System;

namespace SpellCheckerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = createDictionary();
            //1. Take a user input of a word an check if it has been spelled correctly

            //2. Take a string of words as a user input and check they have all been spelled correctly

            //3.Create a spelling score based on the percentage of words spelled correctly            

            //4.Create a new list of words that have been spelled incorrectly and save it in a new file

            //Challenge - Hard task

            //Try to work out which words the user is trying to spell by looking for similarities in
            //the spelling and ask the user did they mean that.

            //Add these suggested words to a spelling list that the user can save as a file to work on
            //their own spelling

            Console.WriteLine("Please write a word");
            string[] UserWords = Console.ReadLine().Split(' ');
            int correct = 0;
            int wrong = 0;
            //string path = "IncorrectWords.txt";

            for (int i = 0; i < UserWords.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (UserWords[i].ToUpper() == words[j])
                    {
                        correct++;
                        
                    }
                    else
                    {
                        wrong++;
                        File.WriteAllText('C:\Users\isobe\Source\Repos\Heckgrammar\spell-checker-task-21IAbson\SpellCheckerTask\IncorrectWords.txt', UserWords[i]);     
                    }
                }

            }
            if (correct == 2)
            {
                Console.WriteLine("word is correct");
            }
            else
            {
                Console.WriteLine("word  is wrong");
            }


            //Percentage

            double percentage = correct/UserWords.Length * 100;
            Console.WriteLine(percentage + "%");
















        }
        static string[] createDictionary()
        {
            using StreamReader words = new("WordsFile.txt");
            int count = 0;
            string[] dictionaryData = new string[178636];
            while (!words.EndOfStream)
            {

                dictionaryData[count] = words.ReadLine();
                count++;
            }
            words.Close();
            return dictionaryData;
        }
    }
}
