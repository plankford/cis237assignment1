/*
 * Patrick Lankford
 * CIS 237 T-R
 * September 22, 2016
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    //Use this class for UserInterface interaction

    class UserInterface
    {
        public int GetUserInput()
        {
            printMenuSelection();

            string input = Console.ReadLine();

            while(input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
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

        public string GetSearchString()
        {
            string searchString = Console.ReadLine();
            return searchString;
        }

        /*
         * Get the user input for the wine item they would like to add to the array
         * Create the wine item in the WineItem class
         * Create the new string to add from the WineItem class
         * return the string to program to add
         * */
        public string GetAddItem()
        {
            Console.Write("Enter the Wine ID:  ");
            string id = Console.ReadLine();
            Console.Write("Enter the Description:   ");
            string description = Console.ReadLine();
            Console.Write("Enter the Pack:   ");
            string pack = Console.ReadLine();

            WineItem addWineItem = new WineItem(id, description, pack);

            string newWineItem = addWineItem.WineID + "   " + addWineItem.WineDescription + "   " + addWineItem.PackNumber;

            return newWineItem;
        }
    }
}
