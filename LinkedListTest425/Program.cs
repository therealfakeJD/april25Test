using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest425
{
    class Program
    {
        static void Main(string[] args)
        {
            Node starter = new Node(0);
            Node current = new Node(1);
            starter = current;
            current.next = new Node(2);
            current = current.next;
            current.next = new Node(3);
            current = current.next;
            current.next = new Node(4);
            current = current.next;
            current.next = new Node(5);

            Console.WriteLine("Linked List Added One by One:");
            Console.WriteLine("");
            starter.PrintLinkedList(starter);
            Console.WriteLine("");
            Console.WriteLine("=======================================");

            List<int> listOfValuesOne = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> listOfValuesTwo = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("NodeList One:");
            Console.WriteLine("-->");
            Node aList = new Node();
            aList = aList.CreateLinkedList(listOfValuesOne);
            aList.PrintLinkedList(aList);
            Console.WriteLine("<--");

            Console.WriteLine("NodeList Two:");
            Console.WriteLine("-->");
            Node bList = new Node();
            bList = bList.CreateLinkedList(listOfValuesTwo);
            bList.PrintLinkedList(bList);
            Console.WriteLine("<--");
            Console.WriteLine("======================================");
            Console.WriteLine("");


            LinkedList<int> cList = new LinkedList<int>();

           foreach(Node node in aList)
            {
                foreach(Node nod in bList)
                {
                    int result;
                    result = aList.value += bList.value;
                    Console.WriteLine(result);
                }
            }




        }


    }
}
