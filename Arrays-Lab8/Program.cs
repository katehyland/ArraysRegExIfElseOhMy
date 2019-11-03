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
        public static void getStudentInfo()
        {

            //create 3 arrays for students, foods and colors
            string[] names = { "Alex", "Bailey", "Cal" };
            string[] foods = { "Pizza", "Burgers", "Tacos" };
            string[] colors = { "Pink", "Blue", "Yellow" };

            Console.WriteLine("Which student would you like to learn about? (enter a number 1-3)");
            for (int i = 0; i < names.Length; i++)
            {
                //in order to display this list in a non-array way, we add 1 to index 
                Console.WriteLine(i + 1 + ":" + names[i]);
            }
            try
            {
                int numericInput = int.Parse(Console.ReadLine());
                string selectedStudent = names[numericInput - 1];

                Console.WriteLine($"That student is {selectedStudent}. Would you like to know {selectedStudent}'s favorite color or favorite food?");
                string selectedFact = Console.ReadLine();

                Match acceptedInput = Regex.Match(selectedFact, @"/^[A-Za-z]+$/");

                if (acceptedInput.Success && selectedFact == "color")
                {
                    Console.WriteLine($"{selectedStudent}'s favorite color is {colors[numericInput - 1]}");

                }

                if (acceptedInput.Success && selectedFact == "food")
                {
                    Console.WriteLine($"{selectedStudent}'s favorite food is {foods[numericInput - 1]}");
                }

                else
                {
                    Console.WriteLine("Input must be 'food' or 'color' ");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("INPUT ERROR: You must choose a number between 1-3");
            }
            catch (FormatException)
            {
                Console.WriteLine("INPUT ERROR: You must enter a number. No special characters or letters.");
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: You broke it.");
            }

        }
    }
}
