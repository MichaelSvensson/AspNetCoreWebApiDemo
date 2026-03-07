namespace FundamentalsPluralSight
{
    public class Fundamentals
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} {args[1]}");
            }
            else
            {
                Console.WriteLine("Hej från en fristående C#-fil!");
                GradeDouble();
                GradeInt();
                CheckEvenOrOddProduction();
                Console.ReadLine();
            }
        }
        static void CheckEvenOrOdd()
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine()!); // null-forgiving operator
            var output = input % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine($"Output: {output}");
        }

        static void CheckEvenOrOddProduction()
        {
            Console.Write("Enter a number: ");
            string? input = Console.ReadLine(); // read input as string
            if (int.TryParse(input, out int number))  // input="10" => 10 = true, input="abc" => false 
            {
                var output = number % 2 == 0 ? "Even" : "Odd";
                Console.WriteLine($"Output: {output}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        static void GradeDouble()
        {
            var grades = new List<double> { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count; // medelvärde
            Console.WriteLine($"Total grade: {result:N2}");
        }
        static void GradeInt()
        {
            var grades = new List<int> { 2, 4, 6, 8 };
            grades.Add(30);
            var result = 0;
            foreach (var number in grades)
            {
                result += number;
            }
            //result /= grades.Count; // medelvärde
            result = result/grades.Count; // medelvärde
            Console.WriteLine($"Total grade: {result}");
        }
    }
}
