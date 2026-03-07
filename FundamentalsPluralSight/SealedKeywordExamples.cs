using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsPluralSight
{
    internal class SealedKeywordExamples
    {
        //public class Bas
        //{
        //    public virtual void Process() { }
        //}

        //public class Barn : Bas
        //{
        //    public sealed override void Process()  // Förseglad – ingen vidare override
        //    {
        //        Console.WriteLine("Bearbetat!");
        //    }
        //}

        //public class BarnBarn : Barn
        //{
        //    // public override void Process() {}  // Fel! Sealed metod
        //}

        public sealed class SealedClass
        {
            public void DisplayMessage()
            {
                Console.WriteLine("This is a sealed class.");
            }
        }

        //public class CustomSealedClass : SealedClass
        //{
        //    // This will cause a compile-time error because SealedClass is sealed and cannot be inherited.
        //}

        public static void Main(string[] args)
        {
               SealedClass mySealedClass = new SealedClass();   // Create an instance of the sealed class
                mySealedClass.DisplayMessage();  // Call the method to display the message
        }
    }
}
