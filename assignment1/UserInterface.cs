using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        public int GetUserInput()
        {
            printMenuSelection();

            string input = Console.ReadLine();

            while(input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.WriteLine("That is not a valid selection, Please try again");
                Console.WriteLine();

                printMenuSelection();

                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }

        private void printMenuSelection()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load wine list");
            Console.WriteLine("2. Print wine list");
            Console.WriteLine("3. Search wine list based on wine ID");
            Console.WriteLine("4. Add item to wine list");
            Console.WriteLine("5. Exit");
        }

        public void printOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}
