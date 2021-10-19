using System;
using System.Collections.Generic;

namespace dll_library_example
{
    public class DataCollection
    {
        // private const int MAX_SIZE = 10; // Maximum size of the _currentIndex array
        private int _currentIndex; // current index of the array
        private List<int> _data; // an array of intergers

        public DataCollection()
        {
            _currentIndex = 0;
            _data = new List<int>();
        }

        // Method to append an int to the end of the list
        public void Add(int x)
        {
            _currentIndex++;
            _data.Add(x);           
        }

        // prints = i[0] = i[1] = ...
        public override string ToString()
        {
            string s = " | ";
            for (int i = 0; i < _data.Count; i++)
            {
                s += $"{_data[i]} | ";
            }
            return s;
        }
    }
}
