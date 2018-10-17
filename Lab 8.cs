using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    { 
        static void Main(string[] args)
           {
            // Grand Circus class list
            List<string> students = new List<string>();

            students.Add("Jonathan");
            students.Add("Joseph");
            students.Add("Jeremy");
            students.Add("Sean");
            students.Add("Chuck");
            students.Add("Andrew");
            students.Add("Katie");
            students.Add("Justin");
            students.Add("Tommy");
            students.Add("Kelsey");

            // list of our hometowns
            List<string> hometown = new List<string>();

            hometown.Add("Alger");
            hometown.Add("Grand Rapids");
            hometown.Add("Milwaukee");
            hometown.Add("Grand Rapids");
            hometown.Add("Ripon");
            hometown.Add("Grand Haven");
            hometown.Add("Grand Rapids");
            hometown.Add("Wyoming");
            hometown.Add("Raleigh");
            hometown.Add("Grand Rapids");

            // list of our favorite foods
            List<string> favoriteFood = new List<string>();

            favoriteFood.Add("tres leche");
            favoriteFood.Add("burritos");
            favoriteFood.Add("peanut butter");
            favoriteFood.Add("BBQ");
            favoriteFood.Add("Almonds");
            favoriteFood.Add("chicken wings");
            favoriteFood.Add("Indian cuisine");
            favoriteFood.Add("burger");
            favoriteFood.Add("Buttered chicken");
            favoriteFood.Add("grits");

            // list of our favorite colors
            List<string> favoriteColor = new List<string>();

            favoriteColor.Add("money green");
            favoriteColor.Add("clementine");
            favoriteColor.Add("red like blood");
            favoriteColor.Add("yellow snow");
            favoriteColor.Add("red like blood");
            favoriteColor.Add("Honolulu blue");
            favoriteColor.Add("Blue Devil blue");
            favoriteColor.Add("black");
            favoriteColor.Add("flamingo pink");
            favoriteColor.Add("violet");

            // condition that returns 'true', part of the while loop
            bool loop = true;

            Console.WriteLine("Welcome to our sensatioanl Grand Circus C# class...a place where I wish we could hit that pinata whenever we got frustrated!");

            // block of code will be executed at least once
            do
            {
                // user is prompted to ask about a particular student
                Console.WriteLine("Which student would you like to learn more about? Enter a number between 1-10!");

                // initialization of variable
                int number;

                // block of code will be executed at least once
                do
                {
                    // code that throws an exception
                    try
                    {
                        // converting input from the user (inputed number converts to a student)
                        number = int.Parse(Console.ReadLine());
                        // validates that only inputs of 1-10 will work
                        if (number < 1 || number > 10)
                        {
                            Console.WriteLine("I'm sorry, that is not a valid number. Please enter a number between 1-10");
                            // only inputs of 1-10 will work
                        }
                        else
                        {
                            // terminates this loop and program control resumes at the next statement following this loop
                            break;
                        }
                    }
                    // exception handler which details appropriate response to an exception
                    catch
                    {
                        // handling of thrown exception...informs user that they need to provide a valid input
                        Console.WriteLine("I'm sorry, that was not a number!");
               
                    }
                // executes code as long as condition returns true
                } while (true);

                number = number - 1;
                // name of student (selected by an initial input of 1-10 by user) outputs
                Console.WriteLine(students[number]);
                Console.WriteLine($"What would you like to know about {students[number]}?");
                string response;

                // block of code will be executed at least once
                do
                {
                    Console.Write("(Enter one of the following: hometown, favorite food, or favorite color)");  
                    response = Console.ReadLine();
                    if (response == "hometown")
                    {
                        // outputs student's hometown
                        Console.WriteLine(hometown[number]);

                        // user is prompted about continuing
                        Console.WriteLine("Would you like to know anything else about this student?  y/n ");

                        // executes code as long as condition returns true
                        while (true)
                        { 
                            response = Console.ReadLine();
                            // if user wants to know more about the student
                            if (response == "y")
                                {
                                    Console.WriteLine("Alright!");

                                // terminates this loop and program control resumes at the next statement following this loop
                                break;
                                }
                            // if user doesn't want to know more about this student
                            else if (response == "n")
                            {
                                Console.WriteLine("ok");

                                // terminates this loop and program control resumes at the next statement following this loop
                                break;
                            }
                        }
                        // stopping selected student
                        if (response == "n")
                        {
                            // terminates this loop and program control resumes at the next statement following this loop
                            break;
                        }
                    }
                    else if (response == "favorite food")
                    {
                        // output is student's favorite food
                        Console.WriteLine(favoriteFood[number]);

                        // user is prompted about continuing
                        Console.WriteLine("Would you like to know anything else about this student?  y/n ");

                        // executes code as long as condition returns true
                        while (true)
                        {
                            response = Console.ReadLine();
                            // if user wants to know more about the student
                            if (response == "y")
                            {
                                Console.WriteLine("Alright!");

                                // terminates this loop and program control resumes at the next statement following this loop
                                break;
                            }
                            else if (response == "n")
                            {
                                Console.WriteLine("ok");

                                // terminates this loop and program control resumes at the next statement following this loop
                                break;
                            }
                        }
                        // stopping selected student
                        if (response == "n")
                        {
                            // terminates this loop and program control resumes at the next statement following this loop
                            break;
                        }
                    }
                    else if (response == "favorite color")
                    {
                        // output is student's favorite color
                        Console.WriteLine(favoriteColor[number]);

                        // user is prompted about continuing
                        Console.WriteLine("Would you like to know anything else about this student?  y/n ");

                        // executes code as long as condition returns true
                        while (true)
                        {
                            response = Console.ReadLine();
                            // if user wants to know more about the student
                            if (response == "y")
                            {
                                Console.WriteLine("Alright!");

                                // terminates this loop and program control resumes at the next statement following this loop
                                break;
                            }
                            // if user doesn't want to know more about the student
                            else if (response == "n")
                            {
                                Console.WriteLine("ok");

                                // terminates this loop and program control resumes at the next statement following this loop
                                break;
                            }
                        }
                        // stopping selected student
                        if (response == "n")
                        {
                            // terminates this loop and program control resumes at the next statement following this loop
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that resoponse is invalid!");
                        }

                // executes code as long as condition returns true
                } while (true);

                // user is prompted about continuing
                Console.WriteLine("Would you like to learn about another student?  y/n");

                // block of code will be executed at least once
                do
                {
                    response = Console.ReadLine();
                    if (response == "y")
                    {
                        Console.WriteLine("Alright!");

                        // terminates this loop and program control resumes at the next statement following this loop
                        break;
                    }
                    else if (response == "n")
                    {
                        Console.WriteLine("ok");

                        // code is no longer executed due to boolean expression
                        loop = false;

                        // terminates this loop and program control resumes at the next statement following this loop
                        break;
                    }
                // executes code as long as condition returns true
                } while (true);

            // executes a block of code repeatedly
            } while (loop);
        }
    }
}