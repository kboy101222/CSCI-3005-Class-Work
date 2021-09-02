using System;
using Supernatural;
//using Animal;
// You can use the "using" statement to import a namespace from 
// within the same file

namespace Object_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.SayHello();

            // There is no Dog in the Object_Examples namespace,
            // So you need to use the full Animal.Dog to use the object
            Animal.Dog d = new Animal.Dog();
            d.Speak();

            // See Alien.cs for the information on this class
            // Alien objects can be created because Program.cs and
            // Alien.cs share a namespace, despite not being in the
            // same files
            Alien a = new Alien();
            a.Warble();

            // Monster has a different namespace, so it has to be
            // called using the full name
            Supernatural.Monster m = new Supernatural.Monster();
            m.Growls();

            // Because we called "using Supernatural" at the beginning,
            // we no longer need to use the full name to create a
            // new vampire object        
            Vampire v = new Vampire();
            v.Speak();
        }
    }

    class Person
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}

namespace Animal
{
    class Dog
    {
        public void Speak()
        {
            Console.WriteLine("Bark, Bark!");
        }
    }
}