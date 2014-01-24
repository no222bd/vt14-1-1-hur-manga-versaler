using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1DV406_S1_L1._1.Model
{
    public static class TextAnalyser
    {
        public static int GetNumberOfCapitals(string text)
        {
            int counter = 0;
            
            foreach (char c in text)
            {
                if (Char.IsLetter(c) && c == Char.ToUpper(c))
                    counter += 1;
            }

            return counter;
        }
    }
}