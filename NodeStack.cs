using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Stackimplementation
{
    public class NodeStack<T> 
    {
        private Node top;
        private int size = 0;

        public int Size => size;

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(T element)
        {
            Node node = new Node(element, top);
            top = node;
            size++;
        }

        public void Display()
        {
            Node current = top;
            while (current != null)
            {
                Console.WriteLine(current.Element);
                current = current.Next;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return default(T); // or throw an exception
            }
            else
            {
                var temp = top.Element;
                top = top.Next;
                size--;
                return temp;
            }
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                //return default(T); // or throw an exception
            }
            else
            {
                Console.WriteLine( top.Element);
            }
        }

        private class Node
        {
            public Node(T element, Node next) 
            {
                this.Element = element;
                this.Next = next;
            }
            public T Element { get;  set; }
            public Node Next { get; set; }
        }
    }
    
    
}
