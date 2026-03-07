using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsPluralSight
{
    public class PracticeDebugging
    {
        public static void Main(string[] args)
        {
            var person = new PersonDebugging("Alice", 30);    // Breakpoint HÄR
            Console.WriteLine($"Namn: {person.Namn}, Ålder: {person.Ålder}");   // Breakpoint HÄR
            person.SkrivUtInfo();   // Breakpoint HÄR
        }
    }

    public class PersonDebugging    
    {
        public PersonDebugging(string? namn, int ålder)
        {
            Namn = namn;
            Ålder = ålder;
        }

        public string? Namn { get; set; }
        public int Ålder { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Hej, jag heter {Namn} och är {Ålder} år.");  // Breakpoint HÄR
            Ålder++;  // Breakpoint HÄR
            Console.WriteLine($"Nu blev jag ett år äldre: {Ålder}");  // Breakpoint HÄR
        }
    }
}

    
