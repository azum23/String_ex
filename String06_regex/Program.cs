using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace String06_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "True democracy is a project that’s much bigger than any one of us";
            Console.WriteLine($"\"{text}\"");

            string pattern = "demo";

            bool a = Regex.IsMatch(text, pattern);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
