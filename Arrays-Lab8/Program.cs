using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Arrays_Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            getStudentInfo();
        }

        //prompt user to enter a number 1-30
        static void getStudentInfo()
        {

            //create 3 arrays for students, foods and colors
            string[] names = { "Alex", "Bailey", "Cal" };
            string[] foods = { "Pizza", "Burgers", "Tacos" };
            string[] colors = { "Pink", "Blue", "Yellow" };

            Console.WriteLine("Which student would you like to learn about? (enter a number 1-30)");
            int input = int.Parse(Console.ReadLine());

            //if (validateInput == true)
            //{ 
            if (Enumerable.Range(1, 10).Contains(input) == true)
            {
                Console.WriteLine($"Would you like to know {names[0]}'s favorite food or favoirte color? Enter 'food' or 'color'.");
                string inputString= Console.ReadLine();

                Match food = Regex.Match(inputString, @"\W*((?i)food(?-i))\W*");
                Match color = Regex.Match(inputString, @"\W*((?i)color(?-i))\W*");

                if (food.Success) {
                    Console.WriteLine($"{names[0]}'s favorite food is {foods[0]}");
                    return;
                }

                if (color.Success)
                {
                    Console.WriteLine($"{names[0]}'s favorite color is {colors[0]}");
                    return;
                }

                Console.WriteLine("Hmmm...sorry. You must not have typed food or color.");
            }
            else if (Enumerable.Range(11, 20).Contains(input) == true)
            {
                Console.WriteLine($"Would you like to know {names[1]}'s favorite food or favoirte color? Enter 'food' or 'color'.");
                string inputString = Console.ReadLine();

                Match food = Regex.Match(inputString, @"\W*((?i)food(?-i))\W*");
                Match color = Regex.Match(inputString, @"\W*((?i)color(?-i))\W*");

                if (food.Success)
                {
                    Console.WriteLine($"{names[1]}'s favorite food is {foods[1]}");
                    return;
                }

                if (color.Success)
                {
                    Console.WriteLine($"{names[1]}'s favorite color is {colors[1]}");
                    return;
                }

                Console.WriteLine("Hmmm...sorry. You must not have typed food or color.");
            }
            else if (input >= 21 && input <= 30)
            {
                Console.WriteLine($"Would you like to know {names[2]}'s favorite food or favoirte color? Enter 'food' or 'color'.");
                string inputString = Console.ReadLine();

                Match food = Regex.Match(inputString, @"\W*((?i)food(?-i))\W*");
                Match color = Regex.Match(inputString, @"\W*((?i)color(?-i))\W*");

                if (food.Success)
                {
                    Console.WriteLine($"{names[2]}'s favorite food is {foods[2]}");
                    return;
                }

                if (color.Success)
                {
                    Console.WriteLine($"{names[2]}'s favorite color is {colors[2]}");
                    return;
                }

                Console.WriteLine("Hmmm...sorry. You must not have typed food or color.");
            }
        Console.WriteLine("Sorry- you must enter a number 1-30!");
        }
    }
}
