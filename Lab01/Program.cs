using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;

            Console.WriteLine("Enter a value for a");
            a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a value for b");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} + {b} equals to {AddNumbers(a,b)}");
        }

        public static int AddNumbers(int a, int b)
        {
            return a-b;
        }
    }
}
