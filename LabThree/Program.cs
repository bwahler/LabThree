using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greet user and take input for name
            Console.WriteLine("Hello, please enter name:");
            string name = Console.ReadLine();

            //Take input for integer 1 to 100
            bool execute = true;
            while (execute == true)
            {
                try
                {
                    Console.WriteLine(name + ", " + "please choose an integer from 1 to 100:");
                    int number = int.Parse(Console.ReadLine());

                    if (number >= 1 && number <= 100)
                    {
                        if ((number) % 2 == 1)
                        {
                            Console.WriteLine("{0} and Odd", number);
                        }
                        else if ((number) % 2 == 0 && number >= 2 && number <= 25)
                        {
                            Console.WriteLine("Even and less than 25");
                        }
                        else if ((number) % 2 == 0 && number >= 26 && number <= 60)
                        {
                            Console.WriteLine("Even");
                        }
                        else if ((number) % 2 == 0 && number > 60)
                        {
                            Console.WriteLine("{0} and Even", number);
                        }
                        else if ((number) % 2 == 1 && number > 60)
                        {
                            Console.WriteLine("{0} and Odd", number);
                        }
                    }
                        else
                        {
                            Console.WriteLine(name + " that number is out of range");
                            execute = true;
                        }
                            execute = Continue(name);
                }
                catch (FormatException)
                {
                    Console.WriteLine(name + " this is not a valid input. Please try again.");
                }
            }
        }

        public static bool Continue(string name)
        {
            Console.WriteLine(name + " would you like to continue? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool loop;
            
            if (userContinue == "y")
            {
                loop = true;
            }
            else if (userContinue == "n")
            {
                loop = false;
                Console.WriteLine("See you later, " + name);
            }
            else
            {
                loop = Continue(name);
            }
            return loop;
        }
    }
}
