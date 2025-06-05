using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class ArrayStack : IStack
    {
        private int[] stack;
        private int stackCount;
        private bool containsValue;

        public int Count { get { return stackCount; } }

        public bool IsEmpty { get { return stackCount == 0; } }

        public ArrayStack(int stackLength)
        {
            this.stack = new int[stackLength];
            this.stackCount = 0;
        }


        public bool Contains(int value)
        {
            //true if stack has item false otherwise
            for (int i = 0; i < stackCount; i++)
            {
                if (stack[i] != value) {
                    containsValue = false; 
                }
                else { 
                    containsValue = true;
                    break;
                }
            }
            return containsValue;
        }

        public int Pop()
        {
            //gives last item pushed on stack then 'removes' it
            int popValue = stack[stackCount - 1];
            
            try
            {
                this.stackCount--;
                return popValue;
            }
            catch (Exception e)
            {
                if (this.IsEmpty)
                {
                    Console.WriteLine("stack is empty");
                }
                else {
                    Console.WriteLine(e.Message);
                }
            }
            return popValue;
        }

        public void Push(int value)
        {
            //new item onto stack
            try
            {
                this.stackCount++;
                stack[stackCount - 1] = value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
