using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetExamples
{
    class EnumTypes
    {

        // An "enum" is an emunerator
        // It's making 7 classes, all of which are Weebday objects
        enum Weekday
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday, 
            Thursday,
            Friday,
            Saturday
        }
        static void Main(String[] args)
        {
            PrintDay(Weekday.Tuesday);
            PrintDay(Weekday.Saturday);
        }

        static void PrintDay(Weekday wd)
        {
            Console.WriteLine("Today is " + wd);
            Weekday tomorrow;
            // Check if "tomorrow" is a valid value within the
            // Weekday enum
            if (! Enum.IsDefined(typeof(Weekday), wd + 1))
            {
                // Set "tomorrow" to Sunday if tomorrow isn't defined
                tomorrow = Weekday.Sunday;
            }
            else
            {
                tomorrow = wd + 1;
            }
            Console.WriteLine("Tommorow is " + tomorrow);
        }
    }
}
