using System;
using System.IO;
using System.Collections.Generic;

namespace TomDickHarry
{
	class MainClass
	{
		private static string dbName = @"db.txt";
		/// <summary>
		/// The delimiter chars.
		/// </summary>
		private static char [] delimiterChars = { ',' };
		// using an array of possible delimiters for splitting strings (one for this exercise)
		/// <summary>
		/// The people.
		/// </summary>
		private static List<Person> people = new List<Person> ( );
		/// <summary>
		/// Exit constant value.
		/// </summary>
		private static char EXIT = 'x';

		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments, ignored.</param>
		public static void Main ( string [] args )
		{
			char userChoice;

			// load the file
			ReadDb ( );

			do
			{
				// clear any existing console text
				Console.Clear ( );

				// display menu to user
				PrintMenu ( );

				// prompt user for their choice
				userChoice = ReadCharLowerCase ( "Your choice: ", new char[] { 'a', 'b', 'c', 'x' } );

				// check user choice
				switch ( userChoice )
				{
					case 'a':
						// clear away existing console text
						Console.Clear ( );
						AddPeople ( );
						break;
					case 'b':
						// clear away existing console text
						Console.Clear ( );
						RemovePeople ( );
						break;
					case 'c':
						// clear away existing console text
						Console.Clear ( );
						PrintDb ( );
						break;
					default:
						break;
				}

				if (userChoice != EXIT) 
				{
					Console.WriteLine ( );
					Console.WriteLine ( "Done. Press any key to return to Main Menu..." );
					Console.ReadLine ( );
				}

			}
			while ( userChoice != EXIT );

			// save changes made to the people List to file
			WriteDb ( );

			// clear away existing console text
			Console.Clear ( );
			Console.WriteLine ( "Press any key to exit..." );
			Console.ReadLine ( );

		}

		/// <summary>
		/// Prints the menu.
		/// </summary>
		private static void PrintMenu ( )
		{
			Console.WriteLine ( "Please choose an option:" );
			Console.WriteLine ( "A. Add new people" );
			Console.WriteLine ( "B. Remove people" );
			Console.WriteLine ( "C. List people" );
			Console.WriteLine ( "X. Exit" );
			Console.WriteLine ( "" );
		}

		/// <summary>
		/// Removes the people.
		/// </summary>
		private static void RemovePeople ( )
		{
			int personToRemove;

			// display existing people
			PrintDb ( );

			// get the user selection
			personToRemove = ReadIntConstraint ( "Pick the Person to remove: ", 0, people.Count - 1 );

			// remove the person from the list
			people.RemoveAt ( personToRemove );

		}

		/// <summary>
		/// Adds the people.
		/// </summary>
		private static void AddPeople ( )
		{
			// infinite loop
			do
			{
				// create a new person object and add it to the people List
				people.Add 
					( 
						// create the Person object, use the Person Constructor method
					new Person ( 
							// set the first name
						ReadString ( "Person First Name: " ), 
							// set the last name
						ReadString ( "Person Last Name: " ), 
							// set the job title
						ReadString ( "Person Job Title: " )
					) 
				);

				Console.WriteLine ( );

				// stop the loop if the user does not want to add any more
				if ( 
					// get user answer
					ReadCharLowerCase ( 
						// prompt text
						"Add more people? Y/N: ", 
						// expected answers
						new char[] { 'y', 'n' } 
					)
					// compare the answer to 'n'
					== 'n' )
				{
					// stop the loop
					break;
				}

			}
			while ( true );
		}

		/// <summary>
		/// Prints the db.
		/// </summary>
		private static void PrintDb ( )
		{
			// display the people on the system
			for ( int index = 0 ; index < people.Count ; index++ )
			{
				Console.WriteLine ( "{0}. {1} {2} is a {3}.", index, people [ index ].FirstName, people [ index ].LastName, people [ index ].JobTitle );
			}

			Console.WriteLine ( );
		}

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
					people.Add 
					( 
						// create the Person object
						new Person ( 
							// set the first name
							splitResult [ 0 ].Trim ( ), 
							// set the last name
							splitResult [ 1 ].Trim ( ), 
							// set the job title
							splitResult [ 2 ].Trim ( ) 
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

		private static void WriteDb ( ) 
		{
			string fileContents = "";

			// empty out the file
			CreateOrEmptyFile ( dbName );

			// go through all people and write them to file one by one
			for ( int index = 0 ; index < people.Count ; index++ )
			{
				// put together the final contents of the database
				fileContents +=
					people [ index ].FirstName + ", " +
					people [ index ].LastName + ", " +
					people [ index ].JobTitle + "\n";
			}

			// write the text to the file all in one go
			WriteToFile ( fileContents );
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

		/// <summary>
		/// Reads the string.
		/// </summary>
		/// <returns>The string.</returns>
		/// <param name="displayText">Display text.</param>
		private static string ReadString ( string displayText )
		{
			string input;
			// prompt user
			Console.Write ( displayText );
			// read string and trim it
			input = Console.ReadLine ( ).Trim ( );
			// return string
			return input;
		}

		/// <summary>
		/// Reads the int.
		/// </summary>
		/// <returns>The int.</returns>
		/// <param name="displayText">Display text.</param>
		private static int ReadInt ( string displayText )
		{
			string input;
			// infinite loop
			do
			{
				try
				{
					// get the console string
					input = ReadString ( displayText );
					// convert to number and return it, thus stopping the loop
					return Convert.ToInt32 ( input );
				}
				catch ( Exception e )
				{
				}
			}
			while ( true );
		}

		/// <summary>
		/// Reads the int, with constraints, inclusive.
		/// </summary>
		/// <returns>The int.</returns>
		/// <param name="displayText">Display text.</param>
		/// <param name="min">Minimum.</param>
		/// <param name="max">Maximum.</param>
		private static int ReadIntConstraint ( string displayText, int min, int max )
		{
			int input;
			// infinite loop
			do
			{
				// read the integer
				input = ReadInt ( displayText );
				// check constraints
				if ( input >= min && input <= max) 
				{
					// stop method, return integer
					return input;
				}
			}
			while ( true );
		}

		/// <summary>
		/// Reads the char lower case.
		/// </summary>
		/// <returns>The char lower case.</returns>
		/// <param name="displayText">Display text.</param>
		private static char ReadCharLowerCase ( string displayText )
		{
			string input;

			input = ReadString ( displayText ) // use ReadString method to get the string
				.ToLower ( ); // convert it to lower case

			// in case there is more than one character,
			if ( input.Length > 1 )
			{
				input = input.Remove ( 1 ); // remove all but the first
			}

			Console.WriteLine ( );

			// return user's character
			return Convert.ToChar ( input );

		}

		/// <summary>
		/// Reads the char lower case, comparing the user input against expected answers.
		/// </summary>
		/// <returns>The char lower case.</returns>
		/// <param name="displayText">Display text.</param>
		/// <param name="expectedAnswers">Expected answers.</param>
		private static char ReadCharLowerCase ( string displayText, char [] expectedAnswers )
		{
			char input;
			bool stop = false;

			// infinite loop
			do
			{
				// ask user for answer
				input = ReadCharLowerCase ( displayText );

				// check the expected answers
				for ( int i = 0 ; i < expectedAnswers.Length ; i++ )
				{
					// if user's answer matches one of the expected answers
					if ( input == expectedAnswers [ i ] )
					{
						// stop the do-while loop
						stop = true;
						// stop the for loop, we are happy
						break;
					}
				}
			}
			while ( !stop );

			// return user's answer
			return input;
		}
	}
}
