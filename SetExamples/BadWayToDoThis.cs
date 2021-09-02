using System;

namespace SetExamples
{
    class BadWayToDoThis
    {
        const int SUNDAY = 0;
        const int MONDAY = 1;
        const int TUESDAY = 2;
        const int WEDNESDAY = 3;
        const int THURSDAY = 4;
        const int FRIDAY = 5;
        const int SATURDAY = 6;

        static void ThisIsBad()
        {
            Console.Write("Please enter a date (0-6): ");
            String tmp = Console.ReadLine();
            PrintDay(int.Parse(tmp));
        }

        static void PrintDay(int day)
        {
            Console.Write("Today is ");
            if (day == SUNDAY)
            {
                Console.WriteLine("Sunday");
            }
            else if (day == MONDAY)
            {
                Console.WriteLine("Monday");
            }
            // You can keep doing this for everyday but I'm lazy

        }
    }
}
