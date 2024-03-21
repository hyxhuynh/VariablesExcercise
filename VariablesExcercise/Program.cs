namespace VariablesExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string restaurantName= "Banyan Tree";
            int restaurantAge = 3;

            string person1Name = "Mary";
            string person2Name = "John";
            string drinkType = "magarita";
            int person1Age = 27;
            int drinkingAge = 21;
            char initial = 'W';
            double drinkPrice = 12.50;

            bool isNice = true;

            // Favorite restaurant
            Console.WriteLine($"One of my favorite restaurants is {restaurantName}. It has been around for {restaurantAge} years.\n");            

            // Middle initial
            Console.WriteLine($"{person1Name}'s middle initial is {initial}.");

            // Drinking age
            if (person1Age >= drinkingAge)
            {
                Console.WriteLine($"{person1Name} is {person1Age} years old. She is old enough to drink! Let's party!\n" 
                    + $"She bought a {drinkType} for {drinkPrice} dollars.\n");
            }
            else
            {
                Console.WriteLine($"{person1Name} is {person1Age} years old. She is not old enough to drink.\n");
            }

            // Morgate
            decimal morgatePayment = 3527.00m;
            Console.WriteLine($"{person2Name} pay ${morgatePayment} for morgate every month.\n");

            // Weather
            if (isNice) 
            {
                Console.WriteLine("The weather is nice!");
            }
            else
            {
                Console.WriteLine("The weather is bad.");
            }

        }
    }
}
