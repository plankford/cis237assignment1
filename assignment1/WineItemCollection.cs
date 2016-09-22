using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        
        /********************************
         * Variables
         * *******************************/
        private string[] wineArray = new string[4000];
        private string array;
        
        UserInterface ui = new UserInterface();

        /*****************************
         * Properties
         * ***************************/

        public string PrintWineArray
        {
            get { return array; }
            set { array = value; }
        }

        /*******************************
         * Methods
         * ****************************/

        /*
         *Take the string (line) and the index that is send from the CSV processor and create the fulle
         * string that will become the wineLine. This line will then be added to the wineArray at the current
         * index. 
         * */
        public void AddWineItem(string _line, int _index)
        {
            string[] parts = _line.Split(',');

            string id = parts[0];
            string description = parts[1];
            string pack = parts[2];

            string wineLine = id + "    " + description + "      " + pack;

            wineArray[_index] = wineLine;
        }

        /*
         * Take the items in the wineArray and add them to a string "array" that will be used for 
         * output to the console for the entire array
         * */
        public void CreateArrayString()
        {
            foreach (var item in wineArray)
            {
                array += item + Environment.NewLine;
            }
        }

        /*
         * Send the string array over to the ui for output
         * */
        public void PrintArray()
        {
            ui.printOutput(array);
        }

        /*
         * Bring the search string in that was sent from main and search the entire array for that item
         * */
        public void SearchWineList(string searchString)
        {
            int i;
            bool found = false;

            /*
             * Use the current length of the array and search for the string. Use the .Contains of the array just
             * to search for the wine id and not have to match the entire string
             * */
            for (i=0; i < wineArray.Length; i++)
            {
                while (found == false)
                {
                    if (wineArray[i].Contains(searchString))
                    {
                    ui.printOutput("Item Found");
                    found = true; 
                    }
                }                    
            }

            if (found == false)
            {
                ui.printOutput("Item Not Found");
            }
        }
    }
}
