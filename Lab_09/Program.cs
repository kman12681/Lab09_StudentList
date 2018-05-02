using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Students = new List<string>();

            Students.Add("George Washington");
            Students.Add("Dennis Rodman");
            Students.Add("Alf");
            Students.Add("Bill Nye");
            Students.Add("Gumby");

            List<string> Food = new List<string>();

            Food.Add("Tacos");
            Food.Add("Pulled Pork");
            Food.Add("Cats");
            Food.Add("Cotton Candy");
            Food.Add("Tic-Tacs");

            List<string> Songs = new List<string>();

            Songs.Add("Mary Had a Little Lamb");
            Songs.Add("Rocketman");
            Songs.Add("Memory");
            Songs.Add("Blinded Me With Science");
            Songs.Add("The Elephant Show Theme Song");

            ArrayList Number = new ArrayList();

            Number.Add("1");
            Number.Add("2");
            Number.Add("3");
            Number.Add("4");
            Number.Add("5");

            bool again = true;
            while (again)

            {
                Console.WriteLine();
                Console.WriteLine("Would you like to learn about a student (\"learn\"), add a new student's information (\"add\"), or \"quit\"?\n");
                string response1 = LearnAddQuit(Console.ReadLine().ToLower());

                if (response1 == "add")
                {
                    string addedStudent = GetStudent();
                    Students.Add(addedStudent);

                    string addedFood = GetFood();
                    Food.Add(addedFood);

                    string addedNumber = GetNumber();
                    Number.Add(addedNumber);

                    string addedSong = GetSong();
                    Songs.Add(addedSong);

                    continue;
                }

                else if (response1 == "learn")

                {
                    Console.WriteLine();
                    Console.Write($"Enter a student's ID number (1 - {Students.Count}) to learn about their favorite things.\n");
                    Console.WriteLine();
                    string input = Console.ReadLine();
                    int index = Validate(input, Students);
                    index--;

                    Console.WriteLine();
                    Console.WriteLine($"That student is {Students[index]}.");
                    Console.WriteLine();

                    Console.WriteLine($"Would you like to know {Students[index]}'s favorite \"food\", \"number\", or \"song\"?\n\nYou can also go \"back\" to the beginning or \"quit\".\n");
                    Console.Write("Entry: ");
                    string response2 = ValidateWord(Console.ReadLine().ToLower());

                    if (response2 == "food")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{Students[index]}'s favorite food is: {Food[index]}");
                        Console.WriteLine();
                        continue;
                    }
                    else if (response2 == "number")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{Students[index]}'s favorite number is {Number[index]}");
                        Console.WriteLine();
                        continue;
                    }
                    else if (response2 == "song")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{Students[index]}'s favorite song is: \"{Songs[index]}\"");
                        Console.WriteLine();
                        continue;
                    }
                    else if (response2 == "back")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }

                else
                {
                    again = false;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Final list of students: ");
            Console.WriteLine();
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(Students[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Thank you, this program will now end.");
            Console.ReadLine();
        }

        static string GetStudent()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What is the student's name?\n");
                string newName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newName))
                {
                    Console.WriteLine();
                    Console.WriteLine("You didn't enter anything. Please try again.");
                    continue;
                }
                else
                {
                    return newName;
                }
            }
        }

        static string GetFood()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What is their favorite food?\n");
                string newFood = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newFood))
                {
                    Console.WriteLine();
                    Console.WriteLine("You didn't enter anything. Please try again.");
                    continue;
                }
                else
                {
                    return newFood;
                }
            }

        }

        static string GetNumber()

        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What is their favorite number?\n");
                string newNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newNumber))
                {
                    Console.WriteLine();
                    Console.WriteLine("You didn't enter anything. Please try again.");
                    continue;
                }
                else
                {

                    return newNumber;
                }
            }
        }
        static string GetSong()

        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What is their favorite song?\n");
                string newSong = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(newSong))
                {
                    Console.WriteLine();
                    Console.WriteLine("You didn't enter anything. Please try again.");
                    continue;
                }
                else
                {
                    return newSong;
                }
            }

        }
        static int Validate(string input, List<string> list)
        {
            int number;

            while (true)
            {
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine();
                    Console.Write($"Invalid input. Enter a number between 1 - {list.Count}): ");
                    input = Console.ReadLine();
                }
                else if (number < 1 || number > list.Count)
                {
                    Console.WriteLine();
                    Console.Write($"Invalid input. Enter a number between 1 - {list.Count}): ");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return number;

        }
        static string ValidateWord(string input)

        {
            while (!(input == "food" || input == "song" || input == "number" || input == "add" || input == "back" || input == "quit"))
            {
                Console.WriteLine();
                Console.Write("Invalid input. Type 'food', 'number', 'song': ");
                input = Console.ReadLine();
            }
            return input;
        }

        static string LearnAddQuit(string input)

        {
            while (!(input == "add" || input == "learn" || input == "quit"))
            {
                Console.WriteLine();
                Console.Write("Invalid input. Type 'learn', 'add', or 'quit': ");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}