using System;
using System.Text.RegularExpressions;

namespace Properties_Example
{
    class Person
    {
        private string _firstName;
        private string _lastName;

        public uint Age { set; get; }
        public bool Alive { set; get; }
        public string FirstName
        {
            get { return _firstName; }
            set {
                if (value == null)
                {
                    throw new ArgumentException("Cannot be null!");
                }
                value = value.Trim();

                if (value == "")
                    throw new ArgumentException("Cannot have an empty or null string!");

                _firstName = value;
                    
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("LastName cannot be null!");
                }
                value = value.Trim();             

                _lastName = value;

            }
        }

        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("LastName cannot be null!");
                }
                value = value.Trim();

                if (value == "")
                    throw new ArgumentException("Cannot have an empty or null string!");

                string[] fields = Regex.Split(value, " +");
                if (fields.Length == 1)
                {
                    _firstName = fields[0];
                    _lastName = "";
                } 
                else
                {
                    _firstName = fields[0];
                    _lastName = fields[fields.Length - 1];
                }
            }
        }

        public override string ToString()
        {
            return FirstName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 55;
            p1.Alive = true;
            p1.FullName = "Cher";

            Console.WriteLine($"p1 = {p1}, age = {p1.Age}, alive = {p1.Alive}");
        }
    }
}
