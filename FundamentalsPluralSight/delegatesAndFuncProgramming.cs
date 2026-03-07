using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsPluralSight
{
    internal class DelegatesAndFuncProgramming
    {   
        public static void Main(string[] args)
        {
            // delegat: funktionspekare: objekt som kan hålla referens till en eller flera metoder 
            // med samma signatur (samma antal parametrar och returtyp). 
            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> multiply = (x, y) => x * y;

            // anropa delegaten som om det vore en vanlig metod.
            Console.WriteLine($"Addition: {add(5, 3)}"); // Output: 8
            Console.WriteLine($"Multiplication: {multiply(5, 3)}"); // Output: 15
        }
    }

}
