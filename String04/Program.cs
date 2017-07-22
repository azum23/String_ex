using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String04
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] spliterChars = { ' ', '.', ',', ':', '\t' };

            string text = "One\ttwo, three. four:five six seven";

            string[] words = text.Split(spliterChars, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in words)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
