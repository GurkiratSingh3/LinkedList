using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Node myNode = new Node(7);
            myNode.next = new Node(5);
            myNode.print();
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void print()
        {
            Console.WriteLine("| " + data + " | ->");
            Console.ReadLine();
        }
    }
}