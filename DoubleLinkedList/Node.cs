﻿using System;

namespace DoubleLinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int value)
        {
            data = value;
            next = null;
            prev = null;
        }
    }
}
