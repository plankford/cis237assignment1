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
         * Constructor
         * ***************************/

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
        public void AddWineItem(string _line, int _index)
        {
            string[] parts = _line.Split(',');

            string id = parts[0];
            string description = parts[1];
            string pack = parts[2];

            string wineLine = id + "    " + description + "      " + pack;

            wineArray[_index] = wineLine;
        }

        public void CreateArrayString()
        {
            foreach (var item in wineArray)
            {
                //Console.WriteLine(item.ToString());                           //Uncomment this back out when finished
                array += item + Environment.NewLine;
                //ui.printOutput(array);
            }
        }

        public void PrintArray()
        {
            ui.printOutput(array);
        }
    }
}
