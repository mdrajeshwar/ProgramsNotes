using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayAndArrayList
{
    public class ArrayAndArrayList
    {
        public static void Main(string[] args)
        {
            // Example of using an array
            int[] numbersArray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array elements:");
            foreach (int number in numbersArray)
            {
                Console.WriteLine(number);
            }

            // Example of using a List (ArrayList equivalent in C#)
            List<string> namesList = new List<string>();
            namesList.Add("Alice");
            namesList.Add("Bob");
            namesList.Add("Charlie");

            Console.WriteLine("\nList elements:");
            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}

/*
Difference between Array and ArrayList (List in C#):

Array:
- Fixed size (cannot change after creation)
- Can store only one data type
- Faster access and less memory overhead
- Good for storing a known number of items

List (ArrayList):
- Dynamic size (can grow or shrink)
- Can store any type (ArrayList), but List<T> is type-safe
- Easier to add, remove, and manage items
- Slightly more overhead than arrays

Pros and Cons:
Array Pros: Fast, simple, less memory, type-safe
Array Cons: Fixed size, less flexible
List Pros: Flexible size, easy to use, type-safe (List<T>)
List Cons: Slightly slower, more memory overhead
*/