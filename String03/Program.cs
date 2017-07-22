using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String03
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = @"d:\Temp\";
            string root2 = @"d:\temp\";

            bool result = root.Equals(root2, StringComparison.OrdinalIgnoreCase);
           
            


            string a = "hello my dear beauty";
            string b = "hello my dear beauty";

            Console.WriteLine(String.ReferenceEquals(a,b));

            string c = String.Copy(a);

            Console.WriteLine(String.ReferenceEquals(a,c));

            Console.ReadLine();
        }
    }
}
