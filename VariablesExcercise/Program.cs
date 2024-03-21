namespace VariablesExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            string restaurantName = "Banyan Tree";
            int restaurantAge = 3;

            string personName = "Mary";
            string drinkType = "magarita";
            int personAge = 27;
            int drinkingAge = 21;
            char initial = 'W';
            double drinkPrice = 12.50;
            decimal morgatePayment = 3527.00m;

            bool isNice = true;

            string firstName;
            string lastName;
            
            // Favorite restaurant
            Console.WriteLine($"One of my favorite restaurants is {restaurantName}. It has been around for {restaurantAge} years.\n");            

            // Middle initial
            Console.WriteLine($"{personName}'s middle initial is {initial}.");

            // Drinking age
            if (personAge >= drinkingAge)
            {
                Console.WriteLine($"{personName} is {personAge} years old. She is old enough to drink! Let's party!\n" 
                    + $"She bought a {drinkType} for {drinkPrice} dollars.\n");
            }
            else
            {
                Console.WriteLine($"{personName} is {personAge} years old. She is not old enough to drink.\n");
            }

            // Morgate
            Console.WriteLine($"{personName} pay ${morgatePayment} for morgate every month.\n");

            // Weather
            if (isNice) 
            {
                Console.WriteLine("The weather is nice!");
            }
            else
            {
                Console.WriteLine("The weather is bad.");
            }

            // User Input
            Console.WriteLine("\nEnter your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            
            Console.WriteLine($"Your full name is {firstName} {lastName}.");
        }
    }
}
