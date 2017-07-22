using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String05
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "True democracy is a project that’s much bigger than any one of us";
            Console.WriteLine($"\"{text}\"");

            bool a = text.StartsWith("true", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(a);

            bool b = text.EndsWith("of use");
            Console.WriteLine(b);

            int first = text.IndexOf("i");
            int last = text.LastIndexOf("i");
            string text2 = text.Substring(first, last - first);
            Console.WriteLine(text2);


            Console.ReadKey();
        }
    }
}
