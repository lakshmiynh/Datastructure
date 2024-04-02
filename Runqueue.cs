using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueimplementation
{
    public  class Runqueue
    {
        static void Main(string[] args)
        {
            Nodequeue<int> queue = new Nodequeue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Display();
            Console.WriteLine("after Dequeue");
            queue.Dequeue();
            queue.Display();
            Console.WriteLine("first element in queue");
            queue.Peek();
        }
        
        
          
    }
}
