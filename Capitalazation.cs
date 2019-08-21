using System;
using System.Collections.Generic;
using System.Text;

namespace Title_Capitalization
{
   public class Capitalasation
    {
        public static string Sentences { get; set; }

        public static string UpperCaseTheFirstLetter(string word)
        {
            return word.Trim().Substring(0, 1).ToUpper() + word.Trim().Substring(1);
        }

        public static List<string> DefaultRule()
        {
            return new List<string> { "the", "to", "in", "with", "and", "but", "or" };
        }
        public static string CheckIfSentenceHasValue(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return null;
            return sentence;
        }
    }
}
