using System;
using System.Linq;

namespace MyApp
{
    public class StringFiller
    {
        public string GetString(string textIn, int length)
        {
            var output = "";
            var text = textIn.ToList();
            for (var j = 0; j < text.Count(); j++)
            {
                for (var i = 0; i < (length >= text.Count()
                                          ? length / text.Count()
                                          : 1); i++)
                {
                    output = AppendIfNotTooLong(length, output, text, j);
                }
            }
            return output;
        }

        private static string AppendIfNotTooLong(int length, string output, System.Collections.Generic.List<char> text, int j)
        {
            if (output.Count() <= length)
            {
                output += text[j];
            }

            return output;
        }
    }
}