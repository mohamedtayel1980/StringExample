using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    public class Utilities
    {
        public void UsingEscapeCharacters()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            // Create a greeting message using escape characters
            string greeting = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(greeting);
        }

        public void FilePathExample()
        {
            // Correct file path representation using escape characters
            string correctPath = "C:\\data\\employees.xlsx";
            Console.WriteLine(correctPath);
        }

        public void VerbatimStringExample()
        {
            // Using verbatim string for a file path
            string filePath = @"C:\data\employees.xlsx";
            Console.WriteLine(filePath);
        }

        public void VerbatimStringWithQuotes()
        {
            string message = @"Bethany said, ""Baking the best pies ever.""";
            Console.WriteLine(message);
        }

        public void UsingStringEquality()
        {
            string name1 = "Alice";
            string name2 = "ALICE";

            // Using == operator
            bool isEqual = (name1 == "Alice"); // Returns true
            Console.WriteLine($"Is name1 equal to 'Alice' using ==: {isEqual}");

            bool isEqualLower = (name1 == "alice"); // Returns false
            Console.WriteLine($"Is name1 equal to 'alice' using ==: {isEqualLower}");

            // Using Equals() method
            bool isEqualMethod = name2.Equals("ALICE"); // Returns true
            Console.WriteLine($"Is name2 equal to 'ALICE' using Equals(): {isEqualMethod}");

            // Case-insensitive comparison using ToLower()
            bool isCaseInsensitiveEqual = name1.ToLower().Equals(name2.ToLower()); // Returns true
            Console.WriteLine($"Is name1 equal to name2 (case-insensitive) using ToLower(): {isCaseInsensitiveEqual}");

            // Case-insensitive comparison using StringComparison.OrdinalIgnoreCase
            bool areEqualIgnoreCase = name1.Equals(name2, StringComparison.OrdinalIgnoreCase); // Returns true
            Console.WriteLine($"Is name1 equal to name2 (case-insensitive) using StringComparison.OrdinalIgnoreCase: {areEqualIgnoreCase}");
        }
    }
}
