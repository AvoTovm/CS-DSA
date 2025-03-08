using System;

namespace SinglyLinkedList
{
    public class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class SinglyLinkedList
    {
        private Node head;

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if(head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while(temp.Next != null) temp = temp.Next;
            
            temp.Next = newNode;
        }

        public void Remove(int value)
        {
            if(head == null) return;
            if(head.Value.Equals(value))
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while(temp.Next != null && !temp.Next.Value.Equals(value))
            {
                temp = temp.Next;
            }
            if(temp.Next != null)
            {
                temp.Next = temp.Next.Next;
            }
        }

        public void PrintList()
        {
            Node curr = head;

            while(curr != null)
            {
                Console.Write(curr.Value + " ");
                curr = curr.Next;
            }
            Console.WriteLine("null");

        }
    }

    internal class Program
    {
        static void Main(string[] args){
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddFirst(4);
            list.AddFirst(5);

            Console.WriteLine("Linked list ");
            list.PrintList();

            list.Remove(3);
            Console.WriteLine("linked list after removing 3 ");
            list.PrintList();
        }
    }
}
