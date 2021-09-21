using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Related_Things
{
    // This is visible to everyone and can be implemented
    // Even though it shouldn't
    class Node
    {
        int value;
        Node next;
        Node previous;
    }
    class LinkedList
    {
        // This is hidden within LinkedList and can only be accessed by
        // the LinkedList class
        private class Node
        {
            int value;
            Node next;
            Node prev;
        }
        //private struct Node
        //{
        //    int value;
        //    // You can hide the implementation of a linked list
        //    // using Structs
        //    //Node next;
        //    // (Doesn't actually work here, just an example)
        //}
    }
}
