using System;

namespace LinkedListDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose what program u want in a linked list");
            Console.WriteLine("1.creating a simple linkedlist");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    LinkedList myList = new LinkedList();

                    myList.Insert(56);
                    myList.Insert(30);
                    myList.Insert(70);

                    myList.Display();
                    break;

            }

        }
    }
}