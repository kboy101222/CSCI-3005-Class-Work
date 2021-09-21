using System;
using System.Text.RegularExpressions;

namespace Java_Style_Class
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private uint _age;
        private bool _isAlive;

        public Person(bool isAlive, uint age, string firstName, string lastName = null)
        {
            if (firstName == null || firstName.Trim() == "")
            {
                throw new ArgumentException("firstName cannot be empty or null!");
            }

            _firstName = firstName.Trim();
            _isAlive = isAlive;
            _age = age;
            
            if (lastName == null)
            {
                _lastName = "";
            } else
            {
                lastName = lastName.Trim();
                string[] parts = Regex.Split(lastName, " +");
                _lastName = parts[parts.Length];
            }
        }

        public override string ToString()
        {
            if (_lastName != "")
                return $"{_firstName} {_lastName}";
            else
                return _firstName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person steve = new(true, 43, "Steve");
            Console.WriteLine(steve);

            Person mary = new(true, 34, "Mary", "LiLamb");
            Console.WriteLine(mary);
        }
    }
}
