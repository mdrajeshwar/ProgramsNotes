using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace charcount 

{
    public class CharCount 
    // Define a public class named CharCount to count character occurrences
    {
        public void CountChars(string input) 
        // Method to count the frequency of each character in the input string
        {
            var charCount = new Dictionary<char, int>(); 
            // Create a dictionary to store character as key and its count as value

            foreach (var c in input) 
            // Iterate through each character in the input string
            {
                if (charCount.ContainsKey(c)) 
                // Check if the current character already exists in the dictionary
                {
                    charCount[c]++; 
                    // If character exists, increment its count by 1
                }
                else 
                // If character does not exist in dictionary
                {
                    charCount[c] = 1;
                     // Add the character with count value of 1
                }
            }

            foreach (var kvp in charCount) 
            // Iterate through each key-value pair in the dictionary
            {
                Console.WriteLine($"Character: {kvp.Key}, Count: {kvp.Value}"); 
                // Display each character and its count
            }
        }
        public static void Main(string[] args) { 
        // Main entry point method for the program
        System.Console.WriteLine("Hello World!"); 
        // Print "Hello World!" message to console
        CharCount chr = new CharCount(); 
        // Create a new instance of CharCount class
        chr.CountChars("hello world"); 
        // Call CountChars method with "hello world" string to count character frequencies
    }
    }
}