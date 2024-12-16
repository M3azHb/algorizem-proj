using System;
using System.Collections.Generic;

class Program
{
    //  صف يحتفاظ بمعلومات المسجل😁
    public class Enrollee
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public double FirstTest { get; set; }
        public double SecondTest { get; set; }
        public double AverageScore { get; private set; }
        public string Outcome { get; private set; }

        public Enrollee(string number, string name, double firstTest, double secondTest)
        {
            Number = number;
            Name = name;
            FirstTest = firstTest;
            SecondTest = secondTest;
            AverageScore = CalculateAverageScore(firstTest, secondTest);
            Outcome = DetermineOutcome(AverageScore);
        }

        // ميثود لحساب متوسط ​​الدرجات😚☺
        private double CalculateAverageScore(double firstTest, double secondTest)
        {
            return (firstTest + secondTest) / 2;
        }

        //  ميثود لتحديد النتيجة على أساس متوسط ​​الدرجات😴  
        private string DetermineOutcome(double averageScore)
        {
            if (averageScore < 50)
                return "Fail";
            else if (averageScore < 70)
                return "Pass";
            else if (averageScore < 85)
                return "Very Good";
            else
                return "Excellent";
        }
    }

    static void Main(string[] args)
    {
        List<Enrollee> enrollees = new List<Enrollee>();

        while (true)
        {
            // إدخال بيانات المنتسبين
            Console.Write("Enter enrollee number (or type 'exit' to finish): ");
            string number = Console.ReadLine();
            if (number.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            Console.Write("Enter enrollee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter first test mark: ");
            double firstTest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second test mark: ");
            double secondTest = Convert.ToDouble(Console.ReadLine());

            // قم بإنشاء منتسب جديد وأضفه إلى القائمة☠☠☠
            Enrollee newEnrollee = new Enrollee(number, name, firstTest, secondTest);
            enrollees.Add(newEnrollee);

            // فرز القائمة حسب متوسط ​​الدرجات🥶
            enrollees.Sort((x, y) => x.AverageScore.CompareTo(y.AverageScore));
        }

        // عرض القائمة المصنفة للمسجلين
        Console.WriteLine("\nEnrollee Information (sorted by average score):");
        foreach (var enrollee in enrollees)
        {
            Console.WriteLine($"Number: {enrollee.Number}, Name: {enrollee.Name}, " +
                              $"First Test: {enrollee.FirstTest}, Second Test: {enrollee.SecondTest}, " +
                              $"Average Score: {enrollee.AverageScore:F2}, Outcome: {enrollee.Outcome}");
        }
    }
}

