using System;

namespace reyhane_rajaee1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int a = 2, b = 5;

            if (a >= b && b != a || a < b)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadKey();


        }
    }
}
