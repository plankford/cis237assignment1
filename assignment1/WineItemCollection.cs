using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {

        //Use this class to create the array 

        WineItemCollection[] wineCollection = new WineItemCollection[6000];

        /*
         * Variables
         * */
        private string _id;
        private string _description;
        private string _pack;
        string[] WineList;

        /*
         * Properties
         * */
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description= value; }
        }

        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

        /*
         * Methods
         * */

        /*
         * Constructor
         * */

        public WineItemCollection(string _id, string _description, string _pack)
        {
            this._id = _id;
            this._description = _description;
            this._pack = _pack;
        }

        public WineItemCollection()
        {

        }
    }
}
