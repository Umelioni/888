using Lab6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MyList<int> ===\n");
            MyList<int> myList = new MyList<int>();
            myList.Add(4);
            Console.WriteLine(myList[0]);
            myList.Add(2);
            Console.WriteLine(myList[1]);
            Console.WriteLine($"Count myList: {myList.Count}");

            Console.WriteLine("\n\n=== MyDictionary<int, string>() ===\n");
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "One");
            Console.WriteLine(myDictionary[1]);
            myDictionary.Add(2, "Two");
            Console.WriteLine(myDictionary[2]);
            Console.WriteLine($"Count myDictionary: {myDictionary.Count}");


            Console.WriteLine("\n\n=== Extension MyList GetArray() ===\n");
            int[] myArrayFromList = myList.GetArray();
            Console.WriteLine("Array: ");
            for (int i = 0; i < myArrayFromList.Length; i++)
            {
                Console.WriteLine("\t" + myArrayFromList[i]);
            }

            Console.WriteLine("\n\n=== MyClass FacrotyMethod ===\n");
            Console.WriteLine(MyClass<MyList<int>>.FacrotyMethod().Count);

            Console.ReadKey();
        }
    }
}
