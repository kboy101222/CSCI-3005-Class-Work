using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Related_Things
{
    public class Person
    {
        private string name;
        public Person(String name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
    class Object_Reference
    {
        Person steve = new("Steve");
        //Person steve_ref = steve;
    }
}
