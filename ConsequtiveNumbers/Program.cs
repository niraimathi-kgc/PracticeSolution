using System;

namespace ConsequtiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b, c;
            LinqNamespace linqNamespace = new LinqNamespace();
            //Console.WriteLine("enter the value to use \'console.read()' : ");
            //a = Console.Read();
            //Console.WriteLine("value of a using console.read() : " + a);
            //Console.WriteLine("enter the value to use \'console.readline()' : ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("value of a using console.readline() : " + b);
            //Console.WriteLine("press any key to use \'Console.ReadKey()' : ");
            //ConsoleKeyInfo k = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("You pressed the key : " + k.Key);
            linqNamespace.LinqSpace();
        }
    }
}