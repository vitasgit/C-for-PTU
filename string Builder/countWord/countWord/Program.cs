using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int count = 0;
            int flag = 0;

            for (int i = 0; i > str.Length; i++)
            {
                if (str[i] != ' ' && flag == 0)
                {
                    count++;
                    flag = 1;
                }
                else if (str[i] == ' ')
                {
                    flag = 0;
                }
            }

            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
