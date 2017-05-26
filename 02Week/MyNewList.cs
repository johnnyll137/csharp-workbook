using System;
using System.Collections.Generic;

namespace ConsoleApplication
{

    class MyNewList
    {
        public void Run()
        {
            /*
            Ask the user for 10 names and add each name into a list
             */

            //Count
            //Console.ReadLine();
            //List<sting>people
            //people.Add();

            List<string> people = new List<string>();
            {

                Console.WriteLine("Please enter 3 people");
                while (people.Count < 3)
                {
                    var input = Console.ReadLine();

                    if (people.Contains(input))
                    {
                        Console.WriteLine("Name has already been added, enter a differnt name");
                        Console.WriteLine("Would you like to delete that name");
                        var response = Console.ReadLine();
                        if (response == "y"){
                            people.Remove(input);
                            Console.WriteLine("Continue adding names");
                        }
                    }
                    else
                    {
                        people.Add(input);
                    }
                }


                Console.WriteLine("These are the people you entered.");
                people.ForEach(Console.WriteLine);
            }
        }
    }
}