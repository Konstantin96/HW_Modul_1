using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMODUL1
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
        }
        static void task1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите ваше ФИО: ");
            string FIO=Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Приветствую тебя - "+FIO);
        }
        static void task2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введи число а: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введи число б: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(a+" + "+b+" = "+(a+b));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
