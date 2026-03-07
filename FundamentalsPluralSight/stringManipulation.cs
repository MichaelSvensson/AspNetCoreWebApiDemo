using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsPluralSight
{
    public class StringManipulation
    {
        public static void Main(string[] args)
        {
            // Reverse a string using a loop
            string text = "sirap";
            string reversedText = StringManipulationWithStringBuilder(text);
            Console.WriteLine(reversedText); // Paris

            string reversedTextWithoutStringBuilder = StringManipulationEasy(text);
            Console.WriteLine(reversedTextWithoutStringBuilder); // Paris

            // Receive an array of integers from the console
            // One row with space-separated integers, e.g. "1 2 3 4 5"
            int[] receivedArrNumbers = ReadIntArrayFromConsole();
            foreach (var number in receivedArrNumbers)
            {
                Console.Write(number);
            }
            Console.WriteLine(string.Join(" ", receivedArrNumbers));
            //Console.WriteLine(receivedArr);

        }
        static string StringManipulationEasy(string text)
        {
            var result = "";
            for (int index = text.Length - 1; index >= 0; index--)
            {
                result += text[index];
            }
            return result;
        }

        static string StringManipulationWithStringBuilder(string text)
        {
            var result = new StringBuilder();   
            for (int index = text.Length - 1; index >= 0; index--)
            {
                result.Append(text[index]); // Append adds the character to the StringBuilder without creating a new string each time
            }
            return result.ToString();   // Convert StringBuilder to string
        }

        // Read an array from the console
        static int[] ReadIntArrayFromConsole()
        {
            Console.WriteLine("Enter space-separated integers:");   
            string? input = Console.ReadLine(); // Read input as a string, allowing for null input
            if (input == null)  // Handle null input case
            {
                return Array.Empty<int>(); // Return an empty array if input is null
            }
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);   // Split the input string into parts based on spaces, removing empty entries
            int[] numbers = new int[parts.Length];  // Create an array to hold the parsed integers
            for (int i = 0; i < parts.Length; i++)
            {
                if (int.TryParse(parts[i], out int number)) // Try to parse each part as an integer
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine($"Invalid integer: {parts[i]}");  // Inform the user about the invalid input
                    numbers[i] = 0; // Default value for invalid integers
                }
            }
            return numbers; // Return the array of parsed integers
        }
    }
}
