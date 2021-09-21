using System;

namespace Classes_and_Related_Things
{
    // Initialize a struct called Point containing an x and y variable
    struct Point
    {
        // An invalid state here would be if either or
        // Both variables are not decalred
        public int x;
        public int y;
        // 

        // If this was a class, you could use the following to set the
        // default values. Structs cannot contain methods without
        // parameters
        //public Point()
        //{
        //    x = 0;
        //    y = 0;
        //}

        // Methods within structs must be EXPLICITELY initialized
        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        // Overrides the default "ToString()" method, replacing it
        // with our own code
        // Roughly equivalent to Python's "__str__"
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    // "readonly" makes the struct immutible so its values
    // cannot be changed
    readonly struct Location
    {
        // These variables can be set once by the program
        // And then can't be changed. If you try to change them
        // You will get a compiler error
        public readonly int x;
        public readonly int y;

        // They're set once by the contructor and never again
        public Location(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string world = "World";
            //Console.WriteLine($"Hello {world}!");

            // You don't have to write it as
            // Point p1 = new Point() because we're not using
            // a constructor
            Point p1;
            p1.x = 4;
            p1.y = 5;
            // String interpolation. It's amazing.
            Console.WriteLine($"The point is at ({p1.x}, {p1.y})");

            // this does use the "new" initializer
            // because we're initializing default values
            Point p2 = new Point(10, 20);
            Console.WriteLine($"The point is at ({p2.x}, {p2.y})");

            // Even with default initialized values, you
            // must use the new Point() method to initialize the
            // default values
            Point p3 = new Point();
            // Both of these methods end up calling ToString()
            Console.WriteLine($"The point is at {p3.ToString()}");
            Console.WriteLine($"The point is at {p3}");

            // Initializes only the y variable,
            // keeps x as the default value
            Point p4 = new Point(y: 34);
            Console.WriteLine($"The point is at {p4}");

            Location l1 = new Location(0, 5);
            Console.WriteLine($"The location is at {l1}");

            // Must assign a readonly struct with the
            // Constructor
            //Location l2;
            //l2.x = 10;
            //ll2.y = 4;
        }
    }
}
