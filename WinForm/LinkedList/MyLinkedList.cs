﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList<T>
    {

        public Node<T> head = null;   //init empty head of node
        private T size;


        public MyLinkedList(T size)
        {
            this.size = size;
        }



        public void Add(T value)
        {
            Node<T> node = new Node<T>();

            if (head == null)
            {
                node.NodeValue = value;
                head = node;
            }

            else if (head != null)
            {
                node.NodeValue = value;
                node.Next = head;
                head = node;    // previos head == current node
            }
        }

        public void Delete()
        {
            if (head != null)
            {
                head = head.Next;

            }
            else if (head == null)
            {
      //          Console.WriteLine("Nothing to delete");
            }

        }

     


        public void Print()
        {
            Node<T> temp = head;

            while (temp != null)
            {
           //     Console.WriteLine(temp.NodeValue);
                temp = temp.Next;

            }
        }


    }
}
