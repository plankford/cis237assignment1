/*
 * Patrick Lankford
 * CIS 237 T-R
 * September 22, 2016
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{

    //Use this class for processing the CSV file for input
    class CSVProcessor
    {
        /*
         * Variables
         * */
        string _line;
        int _counter = 0;
        private StreamReader streamReader;
        private WineItemCollection wineCollection;

        /*
         * Methods
         * */

        /*
         * Import the wine items from the CSV file that is read in from the program class
         * Continue to read the file until the line is null
         * Create the exception if there is an error
         * Send the line that is read over to the processLine method to actually process the line
         * Once the file is read we will close the file
         * */
        public bool ImportWineItemList()
        {
            try
            {
                _counter = 0;

                //Import the CSV file and add the items into the wineCollection class
                while ((_line = streamReader.ReadLine()) != null)
                {
                    //Create the item in the wineCollection class
                    wineCollection.AddWineItem(_line, _counter++);
                }
                wineCollection.CreateArrayString();                                         // This is added
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }

            }
        }

        /*
         * Constructor
         * Set the loaction of the CSV file
         * Go to import the wine list
         * */
        public CSVProcessor(string CSVFile)
        {
            streamReader = new StreamReader(CSVFile);
            ImportWineItemList();
        }

        public CSVProcessor(string CSVFile, WineItemCollection wineCollection)  // : this(CSVFile)
        {
            this.wineCollection = wineCollection;

            streamReader = new StreamReader(CSVFile);
            ImportWineItemList();
        }
    }
}
