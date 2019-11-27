using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputStr = Console.ReadLine();

            string[] str = inputStr.Split(new Char[] { ' ', ','});

            int maxLen = 0, index = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxLen)
                {
                    maxLen = str[i].Length;
                    index = i;
                }
            }

            Console.Write("Самое длинное слово: {0}", str[index]);

            Console.ReadLine();
        }
    }
}
