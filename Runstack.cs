using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackimplementation
{
     class Runstack
    {
        static void Main(string[] args)
        {
            NodeStack<int> Stack = new NodeStack<int>();
            Stack.Push(1);
            Stack.Push(2);
            Stack.Push(3);
            Stack.Push(4);
            Stack.Display();
            Console.WriteLine("top element");
           Stack.Peek();
            Console.WriteLine("after pop ");
            Stack.Pop();
            Stack.Display();
            
        }
    }
}
