//Author: Ian Brown
//SID: 7654321
//Edited: 04/12/2014
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MusicShop
{
    /// <summary>
    /// Class for modelling the music shop
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ShopView mainWindow = new ShopView();
            mainWindow.ShopDataModel = new Shop();
            Application.Run(mainWindow);
        }

        #region Static variables
        public static string filePath = Application.StartupPath + @"/MusicShop.txt";
        /// <summary>
        /// Length of the three display shelves in millimetres
        /// </summary>
        public const float SHELF_LENGTH = 100f;
        #endregion

        #region Member variables
        private List<Title> titles;
        /// <summary>
        /// The full list of titles that the shop has ever carried
        /// </summary>
        public List<Title> Titles
        {
            get { return titles; }
            //set { titles = value; }
        }
        
        #endregion

        #region Constructors
        public Shop()
        {
            titles = new List<Title>();
            LoadData();
        }

        #endregion

        #region Private methods
        /// <summary>
        /// Load the data from a file.
        /// </summary>
        private void LoadData()
        {
            StreamReader dataFileIn = new StreamReader(filePath);
            while (!dataFileIn.EndOfStream)
            {
                //Create a new title for each line in the stream (File)
                Title newTitle = Title.LoadTitle(dataFileIn);
                titles.Add(newTitle);
            }
            dataFileIn.Close();
        }

        /// <summary>
        /// Save all the data to a file
        /// </summary>
        public void SaveData()
        {
            StreamWriter dataFileOut = new StreamWriter(filePath);
            for (int index = 0; index < titles.Count; index++)
            {
                //Ask each title to save itself to the stream (File)
                titles[index].SaveToFile(dataFileOut);
            }
            dataFileOut.Close();
        }
        #endregion
    }
}
