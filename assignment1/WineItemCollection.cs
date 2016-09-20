using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class wineList
    {

        //Use this class to create the array 

        wineList[] wineCollection = new wineList[6000];

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
        //public WineItemCollection(string Line, Array WineCollection, int Counter)
        //{
        //    string[] parts = Line.Split(',');

        //    _id = int.Parse(parts[0]);
        //    _description = parts[1];
        //    _pack = int.Parse(parts[2]);

        //    WineList[Counter] = wineList(_id, _description, _pack);
            
        //}

        public wineList(string _id, string _description, string _pack)
        {
            this._id = _id;
            this._description = _description;
            this._pack = _pack;
        }
    }
}
