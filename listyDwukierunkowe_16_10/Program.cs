using System;

namespace listyDwukierunkowe_16_10
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List myList = new List();
            myList.AddLast(5); // 5
            myList.AddFirst(2); // 2 5
            myList.RemoveFirst(); // 5
            myList.AddLast(7); // 5 7
            myList.RemoveLast(); // 5
            myList.AddLast(9); // 5 9
            Console.WriteLine(myList.ToStringg());
            Console.WriteLine(myList.GetNode(1).data);
        }
    }
}