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


        }
    }
}
