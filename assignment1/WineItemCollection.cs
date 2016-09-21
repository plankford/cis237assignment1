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
        //private string description;
        //private string id;
        //private string pack;
        string[] wineArray = new string[6000];
        string array;
        //Use this class to create the array 
        //WineItemCollection[] wineList = new WineItemCollection[6000];
        //WineItem[] wineList = new WineItem[6000];
        UserInterface ui = new UserInterface();

        /*****************************
         * Constructor
         * ***************************/
        //public WineItemCollection(string id, string description, string pack)
        //{
        //    this.id = id;
        //    this.description = description;
        //    this.pack = pack;
        //}

        //public WineItemCollection()
        //{

        //}


        //public string WineItems[6000];

        /*****************************
         * Properties
         * ***************************/

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

            //wineList[index] = wineLine;

            //wineArray[_index] = new WineItem(id, description, pack);
            wineArray[_index] = wineLine;
        }

        public void CreateArrayString()
        {
            //string array = " ";

            foreach (var item in wineArray)
            {
                Console.WriteLine(item.ToString());
                array += item + Environment.NewLine;
            }
        }

        public void PrintArray()
        {
            ui.printOutput(array);
        }
    }
}
