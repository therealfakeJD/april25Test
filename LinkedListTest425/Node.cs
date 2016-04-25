using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest425
{
    public class Node : IEnumerable
    {
       
        public int value { get; set; }

        public Node next { get; set; }

        public Node()
        {
            
        }

        public Node(int value)
        {
            this.value = value;
        }

        

        public Node CreateLinkedList(List<int> list)
        {
            Node headNode = new Node(list[0]);
            Node currentNode = headNode;

            for (int i = 1; i < list.Count; i++)
            {
                currentNode.next = new Node(list[i]);
                currentNode = currentNode.next;
            }
            return headNode;
        }

        //public Node AddTwoLinkedLists(List<int> aList, List<int> bList)
        //{
        //    Node result = new Node(cList[0]);
        //    Node resultTwo = result;
        //    //List<int> cList = new List<int>();
        //    Node headOne = new Node(aList[0]);
        //    Node currentOne = headOne;
        //    Node headTwo = new Node(bList[0]);
        //    Node currentTwo = headTwo;
        //    for(int i = 1; i < aList.Count + bList.Count + cList.Count; i++)
        //    {
        //        currentOne.next = new Node(aList[i]);
        //        currentOne = currentOne.next;
        //        currentTwo.next = new Node(bList[i]);
        //        currentTwo = currentTwo.next;
        //        resultTwo.next = new Node(cList[i]);
        //        resultTwo.value = currentOne.next.value += currentTwo.next.value;
        //        resultTwo = resultTwo.next;
        //    }
        //    return result;
        //}

        public void PrintLinkedList(Node headNode)
        {
            Node currentNode = headNode;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.value);
                currentNode = currentNode.next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            yield return value;
        }
    }
}
