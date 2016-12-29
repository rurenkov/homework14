using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicQueue<T>:DynamicArray<T>

    {

    //  DynamicQueue<T> dynamicQueue = new DynamicQueue<T>();

        public DynamicQueue(int capacity) : base(capacity)
        {

        }


        public void Equeue(T put)
        {
         
            Add(put);

        }
        

        public void Dequeue(int IndexToInsert)

        {
            Get(IndexToInsert);
            Remove(IndexToInsert);


        }

        public bool IsFull()
        {

            if (size == maxSize)
            {
                Console.WriteLine("QUEUE is full");
            }
            return true;

        }


        public bool IsEmpty()
        {

            if (size == 0)
            {
                Console.WriteLine("QUEUE is empty");
            }
            return true;
        }











    }
}
