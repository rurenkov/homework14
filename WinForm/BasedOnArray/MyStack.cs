using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasedOnArray
{
    public class MyStack<T> : Buffer<T>, IMyStack<T>

    {

        public int top;

        public MyStack(int size) : base(size)
        {

        }
        public override bool IsEmpty()
        {
            if (top == 0)
            {
           //     Console.WriteLine("stack is empty");
            }
            return true;
        }
        //*******************************************************//
        // is FULL  stack;
        //*******************************************************//

        public override bool IsFull()
        {

            if (top > Array.Length)
            {
             //   Console.WriteLine("Stack is full");
            }
            return true;
        }



        //*******************************************************//
        // push method;
        //*******************************************************//
        public void Push(T put)
        {

            if (top != Array.Length)
            {
                Array[top] = put;
                top++;

            }



        }

        //*******************************************************//
        // pop method;
        //*******************************************************//
        public T Pop()
        {

            if (top > 0)
            {
                Array[top - 1] = Array[0];
                top--;
            }

        //    Console.WriteLine("top_pop_" + top);
            return Array[top];

        }
        //*******************************************************//
        // peek method;
        //*******************************************************//

        public T Peek()
        {


            return Array[top - 1];

        }


        public override void Print()
        {

        //    Console.WriteLine("[{0}]", string.Join(", ", Array));

        }


    }
}
