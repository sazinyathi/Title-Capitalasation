using System;
using System.Collections.Generic;
using System.Linq;
using Title_Capitalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitalasation.Sentences = "I love to LIVE with my parent but there are to far away";
          
            if (Capitalasation.CheckIfSentenceHasValue(Capitalasation.Sentences) == null)
                Console.WriteLine("Please add the sentence");
            else
            {
                var sentenceSplit = Capitalasation.Sentences.ToLower().Split(' ');
                    
                for (int i = 0; i < sentenceSplit.Length; i++)
                {
                    if (Capitalasation.DefaultRule().Contains(sentenceSplit[i]))
                    {
                        sentenceSplit[i] = sentenceSplit[i];
                    }
                    else
                    {
                        sentenceSplit[i] =Capitalasation.UpperCaseTheFirstLetter(sentenceSplit[i]);
                    }
                }
                string results = string.Join(" ", sentenceSplit);
                Console.WriteLine(results);
            }

            Console.ReadLine();
        }
      
       

    }
}
