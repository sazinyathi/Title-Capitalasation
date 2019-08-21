using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love to LIVE with my parent but there are to far away";
            if (CheckIfSentenceHasValue(sentence) == null)
                Console.WriteLine("Please add the sentence");
            else
            {
                var sentenceSplit = sentence.ToLower().Split(' ');
                    
                for (int i = 0; i < sentenceSplit.Length; i++)
                {
                    if (DefaultRule().Contains(sentenceSplit[i]))
                    {
                        sentenceSplit[i] = sentenceSplit[i];
                    }
                    else
                    {
                        sentenceSplit[i] = UpperCaseTheFirstLetter(sentenceSplit[i]);
                    }
                }
                string results = string.Join(" ", sentenceSplit);
                Console.WriteLine(results);
            }

            Console.ReadLine();
        }
      
        private static string UpperCaseTheFirstLetter(string word)
        {
            return word.Trim().Substring(0, 1).ToUpper() + word.Trim().Substring(1);
        }

        private static List<string> DefaultRule()
        {
            return new List<string> { "the", "to", "in", "with", "and", "but", "or" };
        }
        private static string CheckIfSentenceHasValue(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return null;
            return sentence;
        }

    }
}
