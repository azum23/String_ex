using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "winter is comming dear friends";

            char[] chars = s.ToCharArray();
            int start = s.IndexOf("friends");
            string replacer = "enemy";
            Console.WriteLine(start);


            // TODO: проверка длинны слов

            if (start != -1)
            {
                for (int i = start, j = 0; i < start + replacer.Length; i++, j++)
                {
                    chars[i] = replacer[j];
                }
            }

            s = new string(chars);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
