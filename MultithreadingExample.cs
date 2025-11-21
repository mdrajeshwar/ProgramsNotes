using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultithreadingExample
{
    public class MultithreadingExample
    {
        // This method will be executed on a separate thread
        public void PrintNumbers()
        {
            // Loop to print numbers from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                // Print the current thread ID and the number
                Console.WriteLine($"Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}: {i}");
                // Pause the thread for 0.5 seconds to simulate work
                System.Threading.Thread.Sleep(500);
            }
        }

        public static void Main(string[] args)
        {
            // Create an instance of the class
            MultithreadingExample example = new MultithreadingExample();

            // Create a new thread and assign the PrintNumbers method to it
            System.Threading.Thread thread1 = new System.Threading.Thread(new System.Threading.ThreadStart(example.PrintNumbers));
            // Start the new thread
            thread1.Start();

            // Main thread also runs PrintNumbers
            example.PrintNumbers();

            // Wait for thread1 to finish before exiting
            thread1.Join(); // Ensures main thread waits for thread1
        }
    }
}
// Definition:
// Multithreading is a programming technique that allows multiple parts of a program to run at the same time.
// It helps make better use of CPU resources and can improve performance for tasks that can be done concurrently.
// Advantages:
// 1. Improved Performance: Tasks can be completed faster by running them in parallel.  