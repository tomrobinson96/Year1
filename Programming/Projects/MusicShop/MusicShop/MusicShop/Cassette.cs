//Author: Ian Brown
//SID: 7654321
//Edited: 04/12/2014
using System.IO;
using System.Text;

namespace MusicShop
{
    /// <summary>
    /// Represents a Compact Cassette (Tape) style title
    /// </summary>
    class Cassette : Title
    {
        /// <summary>
        /// Identifier for use in saved data.
        /// </summary>
        public const string TypeName = "Tape";

        /// <summary>
        /// Constructor for creating a new title.
        /// </summary>
        /// <param name="artist">The name of the artist</param>
        /// <param name="title">The name of the work</param>
        /// <param name="price">The retail price (in pounds sterling)</param>
        public Cassette(string artist, string title, float price)
            : base(artist, title, price)
        {
        }

        /// <summary>
        /// Constructor for loading the data from a text string
        /// </summary>
        /// <param name="sourceData">Pipe (|) delimited string of data read back in from a file</param>
        public Cassette(string sourceData)
        {
            string[] dataItems = sourceData.Split('|');
            ConstructMe(dataItems[1], dataItems[2], float.Parse(dataItems[3]), int.Parse(dataItems[6]),
                int.Parse(dataItems[4]), int.Parse(dataItems[5]));
        }

        /// <summary>
        /// Save the state of the object to a stream
        /// </summary>
        /// <param name="dataFileOut">An output stream</param>
        public override void SaveToFile(StreamWriter dataFileOut)
        {
            StringBuilder outputString = new StringBuilder();
            outputString.Append(TypeName);
            outputString.Append("|");
            outputString.Append(artist);
            outputString.Append("|");
            outputString.Append(name);
            outputString.Append("|");
            outputString.Append(Price.ToString("##0.00"));
            outputString.Append("|");
            outputString.Append(copiesOnShelf);
            outputString.Append("|");
            outputString.Append(copiesInStock);
            outputString.Append("|");
            outputString.Append(copiesSold);

            dataFileOut.WriteLine(outputString);

        }

        /// <summary>
        /// The width of each physical copy in millimetres
        /// </summary>
        public override float Width
        {
            get { return 12f; }
        }
    }
}
