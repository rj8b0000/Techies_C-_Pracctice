using System;

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

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your case: ");
            int userCase = int.Parse(Console.ReadLine());

            CallWithNamedArguments(userCase);
        }
    }
}
