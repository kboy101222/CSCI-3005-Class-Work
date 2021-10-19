using System;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Fraction f1 = new(1, 2);
            Fraction f2 = new(1, 4);

            Console.WriteLine(f1 + f2);
        }
    }
}
