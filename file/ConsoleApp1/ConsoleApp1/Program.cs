using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fileIn = new FileStream("fileIn.txt", FileMode.OpenOrCreate);
            FileStream fileOut = new FileStream("fileOut.txt", FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader("fileIn.txt");
            StreamWriter sw = new StreamWriter("fileOut.txt");

            //string line;

            //line = sr.ReadToEnd();

            //sw.WriteLine(line);

            //fileIn.Close();
            //fileOut.Close();

            //sr.Close();
            //sw.Close();
        }
    }
}
