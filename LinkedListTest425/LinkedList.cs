using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest425
{

    public class LinkedList
    {
        List<int> listOfValuesOne = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



        public LinkedList()
        {
            Console.WriteLine("LinkedList created from a list:");
            Console.WriteLine("");
            Node aNode = new Node();
            aNode = aNode.CreateLinkedList(listOfValuesOne);
            aNode.PrintLinkedList(aNode);
            Console.WriteLine("");
        }



        //public void AddLinkedLists(List<int> aList, List<int> bList)
        //{
        //    Node linkedOne = new Node();
        //    linkedOne = linkedOne.CreateLinkedList(aList);

        //    Node linkedTwo = new Node();
        //    linkedTwo = linkedTwo.CreateLinkedList(bList);

        //    for (int i = ; )
        //}
    }


}
