﻿/*
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
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the user interface class
            UserInterface ui = new UserInterface();
            
            WineItemCollection wineCollection = new WineItemCollection();

            WineItem wineItem = new WineItem();

            //Print the menu to the screen for the user to make a selection
            int userChoice = ui.GetUserInput();

            //bool foundItem = false;

            while(userChoice != 5)
            {
                switch (userChoice)
                {
                case 1:
                    //Load wine list
                    Console.WriteLine("Loading Wine List.");
                    //instatntiate the CSVProcessor and send over the file location of the wine item list
                    CSVProcessor CSVFile = new CSVProcessor("WineList.csv", wineCollection);
                    break;
                case 2:
                    //Print wine list
                    Console.WriteLine("Printing Wine List.");
                    wineCollection.PrintArray();
                    break;
                case 3:
                    //Search wine list
                    Console.WriteLine("What Item Would You Like To Search For?");
                    string searchString = ui.GetSearchString();
                    wineCollection.SearchWineList(searchString);
                    break;
                case 4:
                    //Add item to wine list
                    Console.WriteLine("Enter The Wine Item You Would Like To Add.");
                    string addWineItem = ui.GetAddItem();
                    wineCollection.NewWineItem(addWineItem);
                    break;
                case 5:
                    //Close the application
                    Console.WriteLine("Closing Application");
                    break;
                default:
                    break;
                }
                userChoice = ui.GetUserInput();
            }
        }
    }
}
