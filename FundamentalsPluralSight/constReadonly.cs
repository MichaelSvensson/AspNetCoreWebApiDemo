using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsPluralSight
{
    public class constReadonly
    {
        public const int Default = 0;   // const fields must be initialized at declaration and cannot be changed later
        //public const int DynamisktVarde = DateTime.Now.Year; // This will cause a compile-time error because const fields must be initialized with a compile-time constant value, and DateTime.Now.Year is not a compile-time constant
        public const int PiVarde = 314; // const fields are implicitly static, so they belong to the type rather than an instance

        public readonly int ReadonlyValue; // readonly fields can be assigned in the constructor and cannot be changed later
        public static readonly int MaxAnvändare = 100;  
        public readonly string InstansNamn; // readonly: Kan initieras i konstruktor

        public static readonly string AppVersion;

        public constReadonly(string namn)
        {
            InstansNamn = namn;  // Sätts per instans
        }

        static constReadonly()
        {
            AppVersion = "1.0.0"; // Kan sättas i statisk konstruktor
        }

        public static void ExampleUsage()
        {
            var obj1 = new constReadonly("Objekt 1");
            var obj2 = new constReadonly("Objekt 2");
            // obj1.InstansNamn skiljer sig från obj2.InstansNamn – omöjligt med const
            Console.WriteLine($"Obj1 namn: {obj1.InstansNamn}, Obj2 namn: {obj2.InstansNamn}");
        }
        static void Main(string[] args)
        {
            //MaxAnvändare = 200; // This will cause a compile-time error. 
            ExampleUsage();
            //string version = constReadonly.AppVersion = "2.0.0"; // This will cause a compile-time error because AppVersion is a static readonly field and cannot be assigned a new value after it has been initialized.
            Console.WriteLine(constReadonly.AppVersion);
        }
    }
}
