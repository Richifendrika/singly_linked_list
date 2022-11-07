using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    //each node consist of the information part and link to the next node
    class node
    {
        public int rollnumber;
        public string name;
        public node next;
    }
    class list
    {
        node START;

        public list()
        {
            START = null;
        }
        public void addNote()
        {
            int rollNo;
            string nm;
            Console.Write();
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            node.newnode = new node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
