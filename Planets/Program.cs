using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * by Mark Hawes
 * Week 2
 * last updated 8/30/17
 */

namespace Planets
{
    class Program
    {
        // enum for planets in solar system in order from sun
        enum Planet
        {
            // wasn't sure if I should start at 0, but then I realized it would
            // be easier to start at position 1 - cuts out middle man/method
            Mercury = 1, 
            Venus = 2,
            Earth = 3,
            Mars = 4,
            Jupiter = 5,
            Saturn = 6,
            Uranus = 7,
            Neptune = 8
        };

        // holds user input value
        static int value;

        static void Main(string[] args)
        {
            bool run = true; // bool to tell if program should keep running or not

            Write("Welcome to the Planet Finder\n");

            do
            {
                InputPrompt();
                FindPlanet();

                Write("\nWould you like to check for another planet?(y/n)\n");
                string ans = ReadLine().ToLower();
                if (ans.Equals("n"))
                {
                    run = false;
                } else if (ans.Equals("y")) { }
                else if (ans.Equals("why"))
                {
                    Write("How philosophical... continuing anyway.\n");
                } // end else if
                else
                {
                    Write("Invalid input, continuing anyway.\n");
                } // end else
            } while (run);

            Write("\nThanks for using the Planet Finder. Have a nice day.\n");

            StopClose();
        }

        // prompt user for input
        static void InputPrompt()
        {
            do
            {
                Write("\nEnter a numeric position(1 through 8) to get the " +
                "associated planet in our Solar System.\n");
                int.TryParse(ReadLine(), out value);
                if(value < 1 | value > 8)
                {
                    Write("Invalid input, try again.\n");
                }
            } while (value < 1 | value > 8);
        } // end method

        // find associated planet and tell user
        static void FindPlanet()
        {
            var plVal = (Planet)value;
            string name = Enum.GetName(typeof (Planet), plVal);

            Write("\nThe associated planet is: " + name + "\n");
        }

        // method to stop console from auto closing
        static void StopClose()
        {
            Write("\nPress Enter to close program.\n");
            ReadLine();
        } 
    } // end class 
}// end namespace
