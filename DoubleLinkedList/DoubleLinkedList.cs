using System;
using System.Data;

namespace DoubleLinkedList
{
    public class DoubleLinkedList
    {
        private Node head;
        private Node tail;

        public void Traverse()
        {
            Node curr = head;
            while(curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.next;
            }
            Console.WriteLine("null ");
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            if(head == null)
            {
                head = tail = newNode;
                return;
            }
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if(tail == null)
            {
                tail = head = newNode;
                return;
            }

            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }

        public void AddAtPos(int value, int pos)
        {   
            if(pos < 1) throw new Exception("position is out of range");
            if(pos == 1) AddFirst(value);

            Node newNode = new Node(value);
            Node curr = head;

            for(int i = 0; i < pos - 1 && curr != null; i++)
            {
                curr = curr.next;
            }

            if(curr == null) throw new Exception("out of bounds");

            newNode.next = curr.next;
            newNode.prev = curr;

            if(curr.next != null) curr.next.prev = newNode;
            curr.next = newNode;

            if(curr == tail) tail = newNode;
        }

        public void RemoveAtBegin()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node temp = head;
            if(head == tail && head != null)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
        }

        public void RemoveAtEnd()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node node = tail;
            if(tail == head && tail != null)
            {
                tail = head = null;
            }
            else{
                tail = tail.prev;
                tail.next = null;
            }
        }

        public void RemoveAtPos(int pos)
        {
            if(pos < 1) throw new Exception("position is out of range");
            if(pos == 1)
            {
                RemoveAtBegin();
                return;
            }

            Node temp = head;
            for(int i = 0; i < pos - 1 && temp != null; i++) temp = temp.next;

            if(temp == null) throw new Exception("position is out of bounds");

            if(temp.next != null) temp.next.prev = temp.prev;
            if(temp.prev != null) temp.prev.next = temp.next;

            if(temp == tail) tail = temp.prev;
        }
    }
}
