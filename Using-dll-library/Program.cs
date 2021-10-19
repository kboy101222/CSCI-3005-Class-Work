using dll_library_example;
using System;

namespace Using_dll_library
{
    class Program
    {
        static void Main(string[] args)
        {
            DataCollection d = new DataCollection();

            Random rand = new Random();
            for (int i = 0; i <= 15; i++)
            {
                d.Add(rand.Next(0, 1000));
            }
            Console.WriteLine($"d = {d}");

            string multiLines = @$"
I'm testing multiline
stirngs and hoping
this just works
{d}
            ";
            Console.Write(multiLines);
        }
    }
}
