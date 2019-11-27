using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace countLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char a = char.Parse(Console.ReadLine());
            int k = 0;

            foreach (String s in File.ReadAllLines("text.txt"))
            {
                if (s != null && s.Length > 0 && s[0] == a)
                    k++;
            }

            Console.WriteLine("кол-во строк: " + k);
            Console.ReadKey();

            /*
            Console.Write("Введите заданную букву: ");
            char a = char.Parse(Console.ReadLine());

            StreamReader fileIn = new StreamReader("text.txt");

            string text = fileIn.ReadToEnd();

            fileIn.Close();

            int k = 0;
            
            string[] newText = Regex.Split(text, "[ ,.:;]+");

            for (int i = 0; i < newText.Length; i++)
            {
                if (newText[i][0] == a)
                {
                    k++;
                }
            }

            Console.WriteLine("k= " + k);
            Console.ReadKey();
            */
        }
    }
}
