using System;

namespace StackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40); // should cause exception

            //myStack.PrintStack();
            //myStack.Peek();

            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            //myStack.PrintStack();

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }

    internal class Stack
    {
        static readonly int MAX = 3; // elements count 
        int top;
        int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }

        public Stack()
        {
            top = -1;
        }

        internal bool Push(int data)
        {
            if (top + 1 >= MAX)
            {
                Console.WriteLine("Stack Overflow. {0} not inserted", data);
                return false;
            }
            else
            {
                //stack[++top] = data;
                top = top + 1;
                stack[top] = data;
                Console.WriteLine("{0} inserted", data);
                return true;
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
