using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class MyStack
    {
        private List<int> stack;

        public MyStack()
        {
            stack = new List<int>();
        }

        public void Push(int x)
        {
            stack.Add(x);
        }
        public int Pop()
        {
            if(stack.Count <= 0)
            {
                throw new Exception("No integers to pop");
            }
            else
            {
                int popNum = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return popNum;
            }
        }
        public int Peek()
        {
            if (stack.Count <= 0)
            {
                throw new Exception("there is no peak");
            }
            else
            {
                return stack[stack.Count - 1];
            }
        }


        public void Enqueue(int n)
        {
            stack.Add(n);
        }
        public int Dequeue()
        {
            if (stack.Count <= 0)
            {
                throw new Exception("No integers to dequeue");
            }
            else
            {
                int last = stack[0];
                stack.RemoveAt(0);
                return last;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            myStack.Push(1);
            myStack.Push(5);
            myStack.Push(15);

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
        }
    }
}
