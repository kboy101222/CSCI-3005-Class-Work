using System;
using System.Collections.Generic;

namespace CSharp_Crash_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int badVariable;
                List<int> testData = new List<int>();
                testData.Add(5);
                // testData.Add("Moo") <-- Invalid, wrong data type
                for (int i = 0; i < 10; i++)
                {
                    testData.Add(i * 4);
                    Console.WriteLine("i * 4 =" + i * 4);
                }
                Console.Write("Enter anything that isn't a number: ");
                badVariable = int.Parse(Console.ReadLine());
                Console.WriteLine("If this line is shown, you're bad at following instructions");
            }
            catch (FormatException)
            {
                Console.WriteLine("Had a format exception that I expected to happen!");
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error!");
                Console.WriteLine(e);
            }

            int a = 10;
            int b = 24;
            int current = a;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(current);
                // Ternary
                // variable = condition ? if true : if false;
                current = current == a ? current = b : current = a;
            }
        }
    }
}
