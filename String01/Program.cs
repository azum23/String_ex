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
            string s = "All mountains are blue";

            // замена
            Console.WriteLine("\n" + new string('-',10) + "Замена" + new string('-', 10));
            s = s.Replace("mountains", "cats");
            Console.WriteLine(s);

            // замена с регулярками
            Console.WriteLine("\n" + new string('-', 10) + "Замена с регулярками" + new string('-', 10));
            app.searchFor = "blue";
            app.replaceWith = "red";
            s = Regex.Replace(s, app.searchFor, app.replaceWith, RegexOptions.IgnoreCase);
            Console.WriteLine(s);

            //
        }
    }
}
