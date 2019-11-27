using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("строка: ");
            string myLine = Console.ReadLine();

            Console.Write("кол-во звезд");
            int n = int.Parse(Console.ReadLine());

            string mySymbol = new string('*', n);

            Console.WriteLine(mySymbol + myLine + mySymbol);

            Console.ReadLine();
        }
    }
}
