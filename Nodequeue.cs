using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueimplementation
{
    public class Nodequeue<T>
    {
        private Node head;
        private Node tail;

        public void Enqueue(T element)
        {
            var temp = new Node(element);

            if(head == null)
            {
                head = tail = temp;
            }
            else
            {
               tail.Next = temp;
              tail = temp;  
            }
        }

        public T Dequeue()
        {
            if(head== null)
            {
                Console.WriteLine("queue empty");
            }
            var temp = head.Element;
            head=(Node)head.Next;
            return temp;
        }

        public void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                //return default(T); // or throw an exception
            }

             Console.WriteLine(head.Element);
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Element);
                current = current.Next;
            }
        }


        private class Node
        {
            public Node(T element)
            {
                this.Element = element;
                this.Next = null; // Initialize Next to null for the last node in the queue
            }

            public T Element { get; set; }
            public Node Next { get; set; }
        }

    }
}
