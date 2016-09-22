using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{

    class WineItem
    {
        /*
         * Variables
         * */
        private string _id;
        private string _wineDescription;
        private string _packNumber;

        /*
         * Properties
         * */
        public string WineID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string WineDescription
        {
            get { return _wineDescription; }
            set { _wineDescription = value; }
        }

        public string PackNumber
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
        public WineItem(string id, string wineDescription, string packNumber)
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
