using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace String01
{
    class Program
    {
        string searchFor;
        string replaceWith;

        static void Main(string[] args)
        {
            Program app = new Program();
            string s = "All mountains are blue but table behind";
            Console.WriteLine(s);

            // замена
            Console.WriteLine("\n" + new string('-', 10) + "Замена" + new string('-', 10));
            s = s.Replace("mountains", "cats");
            Console.WriteLine(s);

            // замена с регулярками
            Console.WriteLine("\n" + new string('-', 10) + "Замена с регулярками" + new string('-', 10));
            app.searchFor = "blue";
            app.replaceWith = "red";
            s = Regex.Replace(s, app.searchFor, app.replaceWith, RegexOptions.IgnoreCase);
            Console.WriteLine(s);

            //
            Console.WriteLine("\n" + new string('-', 10) + "Char replace" + new string('-', 10));
            s = s.Replace(' ', '_');
            Console.WriteLine(s);

            //
            Console.WriteLine("\n" + new string('-', 10) + "Cut substring" + new string('-', 10));
            string sForCut = "cat";
            int i = s.IndexOf(sForCut);
            if (i >= 0)
            {
                s = s.Remove(i, sForCut.Length);
            }
            Console.WriteLine(s);

            //
            Console.WriteLine("\n" + new string('-', 10) + "Trim string" + new string('-', 10));
            string s2 = "    My car is black but rain cold    ";
            string temp = s2.Trim();
            Console.WriteLine(temp);

            Console.ReadKey();
        }
    }
}
