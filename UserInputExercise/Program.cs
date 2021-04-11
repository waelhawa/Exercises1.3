using System;

namespace UserInputExercise
    {
    class Program
        {
        static void Main(string[] args)
            {
            string text;
            bool checker = true;
            while (checker)
                {
                Console.Write("Please choose which excercise would you like to try: \n1- Exercise 13\n2- Exercise 14\n3- Exercise 15\n4- Exit\n\nEntry: ");
                text = Console.ReadLine().Trim().ToLower();

                switch (text)
                    {
                    case "1":
                    case "13":
                        exercise13();
                        break;
                    case "2":
                    case "14":
                        exercise14();
                        break;
                    case "3":
                    case "15":
                        exercise15();
                        break;
                    case "4":
                    case "exit":
                        checker = false;
                        Console.WriteLine("Thank you. Goodbye!");
                        break;
                    default:
                        Console.WriteLine($"{text} is an invalid entry.\n");
                        break;
                    }
                }
            } //end main

        static void exercise13()
            {
            bool checker = true;
            int number;
            Console.WriteLine("This is an exercise to output all numbers from the number entered to 0.");
            while (checker)
                {
                number = numberEntry();
                for (int i = number; i >= 0; i--)
                    {
                    Console.Write($"{i} ");
                    }
                Console.WriteLine();
                checker = continueEntry();
                }
            Console.WriteLine("\nThank you for checking Exercise 13.\n");

            } //end exercise 13

        static void exercise14()
            {
            bool checker = true;
            int number;
            Console.WriteLine("This is an exercise to output all numbers squared from 1 to the number entered.");
            while (checker)
                {
                number = numberEntry();
                for (int i = 1; i <= number; i++)
                    {
                    Console.Write($"{i * i} ");
                    }
                Console.WriteLine();
                checker = continueEntry();
                }
            Console.WriteLine("\nThank you for checking Exercise 14.\n");

            } //end exercise 14

        static void exercise15()
            {
            bool checker = true;
            int number;
            Console.WriteLine("This is an exercise to output all numbers cubed from 1 to the number entered.");
            while (checker)
                {
                number = numberEntry();
                for (int i = 1; i <= number; i++)
                    {
                    Console.Write($"{i * i * i} ");
                    }
                Console.WriteLine();
                checker = continueEntry();
                }
            Console.WriteLine("\nThank you for checking Exercise 15.\n");

            } //end exercise 15

        static int numberEntry()
            {
            string text;
            int number;
            while (true)
                {
                Console.Write("Enter a number: ");
                text = Console.ReadLine().Trim().ToLower();
                if (int.TryParse(text, out number))
                    {
                    return number;
                    }
                else
                    {
                    Console.WriteLine("Ivalid entry.");
                    }
                }
            } //end numberEntry

        static bool continueEntry()
            {
            string text;
            while (true)
                {
                Console.Write("Would you like to continue? (Y/N)?: ");
                text = Console.ReadLine().Trim().ToLower();

                switch (text)
                    {
                    case "y":
                    case "yes":
                        return true;
                        break;

                    case "n":
                    case "no":
                        return false;
                        break;

                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                    }
                }
            }

        
        }
    }
