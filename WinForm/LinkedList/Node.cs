﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node<T>
    {

        public Node<T> Next { get; set; }
        public T NodeValue { get; set; }
    }
}
