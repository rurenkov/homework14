using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace BasedOnArray
{
    public abstract class Buffer<T> : IBuffer<T>
    {

        public T[] Array;
        public int head;
        public int free;
        public T put;

        public Buffer(int size)
        {
            Array = new T[size];
            free = Array.Length - head;
        }
        
        public abstract bool IsFull();
        public abstract bool IsEmpty();
        public abstract void Print();


    }
}
