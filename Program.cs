using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love to with my dad and mom but they are far away me";
            if (checkIfSentenceHasValue(sentence) != null)
            {
                var lowercase = LowerCaseAllWordInSentence(sentence);
                var sentenceSplit = BreakSentenceBySpaces(lowercase);
                sentenceSplit[0] = UpperCaseTheFirstLetter(sentenceSplit.First());
                sentenceSplit[sentenceSplit.Length - 1] = UpperCaseTheFirstLetter(sentenceSplit.Last());
                for (int i = 1; i < sentenceSplit.Length - 1; i++)
                {
                    if (lowerList.Contains(sentenceSplit[i]))
                    {
                        sentenceSplit[i] = LowerCaseAllWordInSentence(sentenceSplit[i]);
                    }
                    else
                    {
                        sentenceSplit[i] = UpperCaseTheFirstLetter(sentenceSplit[i]);
                    }
                }
                string results = string.Join(" ", sentenceSplit);
                Console.WriteLine(results);
            }
            else
            {
                Console.WriteLine("Please add the sentence");

            }
            Console.ReadLine();
        }
        private static List<string> lowerList = new List<string> { "the", "to", "in", "with", "and", "but", "or" };
        private static string UpperCaseTheFirstLetter(string word)
        {
            return word.Trim().Substring(0, 1).ToUpper() + word.Trim().Substring(1);

        }

        private static string LowerCaseAllWordInSentence(string sentence)
        {
            return sentence.ToLower();
        }

        private static string checkIfSentenceHasValue(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return null;
            return sentence;
        }

        private static string[] BreakSentenceBySpaces(string sentence)
        {
            return sentence.Split(' ');
        }
    }
}
