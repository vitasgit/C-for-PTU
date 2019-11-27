﻿using System;
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

            Console.Write("слово из строки:");
            Regex myRegex = new Regex(Console.ReadLine(), RegexOptions.IgnoreCase);

            MatchCollection myMatch = myRegex.Matches(myLine);

            Console.Write("встречается: ");
            Console.WriteLine(myMatch.Count.ToString());

            Console.ReadLine();
        }
    }
}
