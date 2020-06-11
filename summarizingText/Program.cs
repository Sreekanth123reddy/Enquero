using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really amazig";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);

        }
    }
}
