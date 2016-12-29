using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicStack<T>:DynamicArray<T>
    {


        //  DynamicArray<T> dynamicArray = new DynamicArray<T>();
        //private int Stacksize;

        public DynamicStack(int capacity) : base(capacity)
        {
        }



        //*******************************************************//
        // push method;
        //*******************************************************//
        public void Push(T put)
        {
            Add(put);

        }

        //*******************************************************//
        // pop method;
        //*******************************************************//
        public void Pop()
        {
            
           size = size - 1;
           Remove(size - 1);
           //return size;

        }
        //*******************************************************/
        // peek method;
        //*******************************************************//

        public void Peek()
        {

            size = size - 1;
            //size = size - 1;
            //return this.size;


        }



    }





}
