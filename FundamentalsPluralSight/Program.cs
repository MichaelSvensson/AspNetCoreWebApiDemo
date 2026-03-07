// See https://aka.ms/new-console-template for more information

using System;

namespace FundamentalsPluralSight
{
    public class Program
    {
        static string StringManipulationWithStringBuilder(string text)
        {
            var result = new System.Text.StringBuilder();
            for (int index = text.Length - 1; index >= 0; index--)
            {
                result.Append(text[index]); // Append adds the character to the StringBuilder without creating a new string each time
            }
            return result.ToString();   // Convert StringBuilder to string
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please enter your first name: ");
            string? fName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string? lName = Console.ReadLine();
            Console.WriteLine("Hej " + fName + " " + lName);

            // Different ways to check not nullable
            // The code defines a method which return a string based on a id.
            string? TryGetMessage(int id) => ""; // TryGetMessage är definierad som en metod som tar en int och returnerar en string
                                                 //string? msg = TryGetMessage(42);  // Allow nullable assignment.
                                                 //string msg = TryGetMessage(42) ?? "Unknown message id: 42"; // Expression on the right-hand-side could be null-checked before assignment
            string msg = TryGetMessage(42)!; // Add the null forgiving operator, !

            // Method TryGetMessage2, return bool
            bool TryGetMessage2(int id, out string message)
            {
                message = "Failure";  // Standardvärde vid misslyckande
                                      // Här skulle du typiskt hämta meddelandet från en databas/cache etc.
                                      // Om det lyckas: return true; annars return false;
                if (id < 0) return false;
                message = $"Meddelande {id}";
                return true;   // Exempel: lyckas alltid här
            }

            // Användning
            if (TryGetMessage2(1, out string msg2))
            {
                // msg2 är giltig och kan användas säkert
                Console.WriteLine(msg2);
            }

            else
            {
                // Hantera misslyckande
                Console.WriteLine("Meddelande hittades inte");
            }

            bool flag = TryGetMessage2(1, out msg2);
            if (flag)
            {
                Console.WriteLine("Successfully");
            }

            else
            {
                Console.WriteLine("Not Successfully");
            }

            // Reverse a string using a loop
            string text = "sirap";
            string reversedText = StringManipulationWithStringBuilder(text);
            Console.WriteLine(reversedText); // Paris
        }
    }
}



