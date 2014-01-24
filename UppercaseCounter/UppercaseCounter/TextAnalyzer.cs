using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UppercaseCounter
{
    public class TextAnalyzer
    {
        static public int GetNumberOfCapitals(string text)
        {
            return text.Count(c => char.IsUpper(c));
        }
    }
}