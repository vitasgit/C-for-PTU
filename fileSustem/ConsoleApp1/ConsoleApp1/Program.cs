using System;
using System.Collections.Generic;
using System.IO;
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
            string maxLine = " ";

            string[] lines = File.ReadAllLines("file.txt");

            Console.WriteLine(lines[0]);

            foreach (string line in lines)
            {
                if (line.Length > maxLine.Length)
                {
                    maxLine = line;
                }
            }

            Console.WriteLine(maxLine + " " + maxLine.Length);
            
            Console.ReadKey();
        }
    }
}
