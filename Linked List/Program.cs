using System;
using System.Linq;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
           
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            linkedList.Remove("Alice");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");

         
            linkedList.AppendFirst("Bill");
        }
    }
}
