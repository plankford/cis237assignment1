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
        // Create the StreamReader and set to null
        //StreamReader streamReader = new StreamReader("WineList.CSV");
        //StreamReader streamReader = null;

        //Create the array for the wine list
        wineList[] wineCollection = new wineList[6000];

        /*
         * Variables
         * */
        string _line;
        int _counter = 0;
        private StreamReader streamReader;


        /*
         * Properties
         * */



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
           // StreamReader streamReader = null;
            try
            {
                _counter = 0;

                while ((_line = streamReader.ReadLine()) != null)
                {
                    processLine(_line, wineCollection, _counter++);

                    //string[] parts = _line.Split(',');

                    //int id = int.Parse(parts[0]);
                    //string description = parts[1];
                    //int pack = int.Parse(parts[2]);

                    ////Create the array in the WineItemCollection class
                    //wineList[_counter] = new wineList(id, description, pack);
                }
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
         * Process the line that is read in.
         * Once the line is processed we will send the line over the the WineCollection class
         * where the array will be created
         * */
        public void processLine(string line, wineList[] wineList, int index)
        {
            string[] parts = line.Split(',');

            string id = parts[0];
            string description = parts[1];
            string pack = parts[2];

            //Create the array in the WineItemCollection class
            wineList[index] = new wineList(id, description, pack);
        }
        

        /*
         * Constructor
         * Set the loaction of the CSV file
         * Go to import the wine list
         * */
        public CSVProcessor(string WineItemList)
        {
            streamReader = new StreamReader(WineItemList);
            ImportWineItemList();
        }
        
    }
}
