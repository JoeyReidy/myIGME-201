using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class MyQueue
    {
        private List<int> queue;
        public MyQueue()
        {
            queue = new List<int>();
        }


        public void Enqueue(int n)
        {
            queue.Add(n);
        }
        public int Dequeue()
        {
            if (queue.Count <= 0)
            {
                throw new Exception("No integers to dequeue");
            }
            else
            {
                int last = queue[0];
                queue.RemoveAt(0);
                return last;
            }
        }

        public int Peek()
        {
            if(queue.Count <= 0)
            {
                throw new Exception("queue is empty");
            }
            else { return queue[0]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
