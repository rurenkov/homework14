using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public abstract class Dynamic<T>
    {



        public abstract void Insert(T addValue, int IndexToInsert);
        public abstract void Add(T addValue);
        public abstract void Remove(int IndexToInser);
        public abstract T Get(int IndexToInsert);
        public T[] Array;
        public int size;
        public T addValue;
        public const int gFactor = 2;
        public int capacity=1;
        public int maxSize = 1000000;
        public int IndexToInsert;

        public  Dynamic(int capacity)
        {
            Array = new T[capacity];
            //capacity = array.Length;
        }
        


    }
}
