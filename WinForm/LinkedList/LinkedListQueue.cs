using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class LinkedListQueue<T>: MyLinkedList<T>
    {
        public LinkedListQueue(T size) : base(size)
        {
        }

        public void Equeue(T put)
        {

           Add(put);

        }


     

    }
}
