using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneraicsCollectionSample
{
    
    public class GeneraicsCollectionSample
    {
        List<int> datam = new List<int>();

        public GeneraicsCollectionSample()
        {
            datam.Add(10);
            datam.Add(20);
            datam.Add(30);
        }
        public void DisplayData()
        {
            Console.WriteLine("Generic List elements:");
            foreach (int item in datam)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            GeneraicsCollectionSample sample = new GeneraicsCollectionSample();
            sample.DisplayData();
        }
    } 
}

// Notes on Generics in C#
// Generics allow you to define classes, methods, and data structures with a placeholder for the data type. This enables type safety, code reusability, and performance improvements by avoiding boxing/unboxing and runtime type checks.
// Advantages:
// 1. Type Safety: Errors are caught at compile time, reducing runtime errors.
// 2. Code Reusability: Write code that works with any data type.
// 3. Performance: Avoids boxing/unboxing for value types and reduces casting overhead.
// 4. Maintainability: Cleaner and more readable code.
// Disadvantages:
// 1. Increased Complexity: Can make code harder to understand for beginners.
// 2. Type Constraints: Sometimes you need to use constraints, which can complicate design.
// 3. Limited Reflection: Some generic type information is erased at runtime (type erasure).