using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the user interface class
            UserInterface ui = new UserInterface();

            //Print the menu to the screen for the user to make a selection
            int userChoice = ui.GetUserInput();

            while(userChoice != 5)
            {
                switch (userChoice)
                {
                case 1:
                    //Load wine list
                    Console.WriteLine("Choice 1");
                    break;
                case 2:
                    //Print wine list
                    Console.WriteLine("Choice 2");
                    break;
                case 3:
                    //Search wine list
                    Console.WriteLine("Choice 3");
                    break;
                case 4:
                    //Add item to wine list
                    Console.WriteLine("Choice 4");
                    break;
                case 5:
                    //Close the application
                    Console.WriteLine("Choice 5");
                    break;
                default:
                    break;
                }
                userChoice = ui.GetUserInput();
            }
        }
    }
}
