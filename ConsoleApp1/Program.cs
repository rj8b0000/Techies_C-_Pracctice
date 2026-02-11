using System;
using System.Linq;

namespace Program
{
    class Program
    {
        public static void CreateProfile(string name, int age, string city, bool isActive)
        {
            Console.WriteLine($"{name}, {age}, {city}, {isActive}");
        }

        public static void CallWithNamedArguments(int scenario)
        {
            switch (scenario)
            {
                case 1:
                    CreateProfile(name: "Rudraksh", age: 20, city: "Ahmedabad", isActive: true);
                    break;

                case 2:
                    CreateProfile(isActive: true, age: 40, city: "Usa", name: "John");
                    break;

                case 3:
                    CreateProfile("Max", 32, city: "Texas", isActive: false);
                    break;

                case 4:
                    CreateProfile("Joe", 50, "Nyc", true);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static double SumAllNum(params double[] numbers)
        {
            double sum = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            foreach(double i in numbers)
            {
                sum = sum + i;
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter your case: ");
            //int userCase = int.Parse(Console.ReadLine());
            //CallWithNamedArguments(userCase);
            Console.WriteLine(SumAllNum(10, 20, 30));
            Console.WriteLine(SumAllNum(34.5, 34.2, 43));
            Console.WriteLine(SumAllNum());
        }
    }
}
