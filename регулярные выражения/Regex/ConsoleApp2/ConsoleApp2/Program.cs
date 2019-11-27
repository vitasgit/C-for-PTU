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

            string result = new Regex("привет").Replace(myLine, "bonjour");
            //string result = new Regex(@"\s").Replace(myLine, ""); /*убрать все пробелы*/
            //string result = new Regex(Console.ReadLine()).Replace(myLine, Console.ReadLine());

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
