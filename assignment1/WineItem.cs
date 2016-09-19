using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    //This is going to be used for printing the wine items to the console

    class WineItem
    {
        /*
         * Variables
         * */
        private int _id;
        private string _wineDescription;
        private int _packNumber;

        /*
         * Properties
         * */
        public int WineID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string WineDescription
        {
            get { return _wineDescription; }
            set { _wineDescription = value; }
        }

        public int PackNumber
        {
            get { return _packNumber; }
            set { _packNumber = value; }
        }
        /*
         * Methods
         * */
        public override string ToString()
        {
            return this._id + " " + _wineDescription + " " + _packNumber;
        }

        /*
         * Contructor
         * */
        public WineItem(int id, string wineDescription, int packNumber)
        {
            this._id = id;
            this._wineDescription = wineDescription;
            this._packNumber = packNumber;
        }

        public WineItem()
        {
            //Empty Constructor
        }

    }
}
