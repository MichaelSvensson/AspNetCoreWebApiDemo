using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsPluralSight
{
    public class Person // Person-klass med namn och ålder
    {
        private readonly string? namn;  // readonly innebär att fältet kan bara tilldelas i konstruktorn och inte ändras efter det
        private readonly int ålder;     

        public Person(string? namn, int ålder)  // Konstruktor som tar namn och ålder som parametrar
        {
            this.namn = namn;   
            this.ålder = ålder; 
        }
    }
}
