using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sb.Append("asdasd");
            StringBuilder sb = new StringBuilder("bonjour le monde");

            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");

            /* *****Методы********************************************** */
            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            Console.WriteLine(sb);

            // заменяем слово
            sb.Replace("мир", "world");
            Console.WriteLine(sb);

            // удаляем 13 символов, начиная с 7-го
            sb.Remove(7, 13);
            Console.WriteLine(sb);

            // получаем строку из объекта StringBuilder
            string s = sb.ToString();
            Console.WriteLine(s);


            Console.ReadLine();
        }
    }
}
