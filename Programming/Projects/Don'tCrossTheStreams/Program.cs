using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Don_tCrossTheStreams
{
    class Program
    {
        private static string dbName = @"db.txt";

		private static char [] delimiterChars = { ',' };

        private static List<Stream1> stream = new List<Stream1> ( );

        private static char EXIT = 'x';

        static void Main(string[] args)
        { }
        
            /// <summary>
		/// Writes to file a chunk of text, appends, does not add NewLine character at the end.
		/// </summary>
		/// <param name="text">Text.</param>
		private static void WriteToFile ( string text )
		{
			try
			{
				// the second boolean parameter specifies whether the file should be appended to if set to TRUE
				StreamWriter fileWriter = new StreamWriter ( dbName, true );
				// write the text, does not put a NewLine character at the end
				fileWriter.Write ( text );
				// close the file
				fileWriter.Close ( );
			}
			catch ( Exception e )
			{
				Console.WriteLine ( "Method: 'WriteToFile'. Database file '{0}'. Exception: {1}", dbName, e.Message );
			}
		}

		/// <summary>
		/// Reads the db.
		/// </summary>
		private static void ReadDb ( )
		{
			string myData;
			string [] splitResult;

			try
			{
				StreamReader fileReader = new StreamReader ( dbName );

				// start reading the file line by line while the end has not been reached (can run 0 or more times)
				while ( !fileReader.EndOfStream )
				{
					// get next line from the file
					myData = fileReader.ReadLine ( );
					// split the result
					splitResult = myData.Split ( delimiterChars );
					// add a Person object to the List
					stream.Add 
					(
                        // create the Person object
                        item:
                        // create the Person object
                        new Stream1 
                            ( 
							// set the first name
							splitResult [ 0 ].Trim ( )
                           
                            )									
						);
				}

				fileReader.Close ( );
			}
			catch ( FileNotFoundException e )
			{
				// create the file if not there
				CreateOrEmptyFile ( dbName );

			}
			catch ( Exception e )
			{
				Console.WriteLine ( "Method: 'ReadDb'. Database file '{0}'. Exception: {1}", dbName, e.Message );
			}
		}
        private static void CreateOrEmptyFile ( string fileName ) 
		{
			try
			{
				// open the file
				StreamWriter fileWriter = new StreamWriter ( fileName );
				// close the file
				fileWriter.Close ( );
			}
			catch ( Exception e )
			{
				Console.WriteLine ( "Method: 'CreateOrEmptyFile'. Database file '{0}'. Exception: {1}", fileName, e.Message );
			}
		}
        }
}