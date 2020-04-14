//Author: Ian Brown
//SID: 7654321
//Edited: 04/12/2014
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicShop
{
    /// <summary>
    /// Form for displaying the current state of the shop and allowing 
    /// user interaction with the data model
    /// </summary>
    public partial class ShopView : Form
    {

        #region Member variables
        /// <summary>
        /// The underlying data model of the shop
        /// </summary>
        public Shop ShopDataModel { get; set; }
        
        /// <summary>
        /// The currently selected and active title
        /// </summary>
        private TitleListViewItem selectedItem;

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public ShopView()
        {
            //Build the form by calling the auto-generated code
            InitializeComponent();
            //Display the data currently in the model
            RefreshView();
        }

        #endregion

        #region Event Handlers
        /// <summary>
        /// Event Handler for creating a new title.
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void btnNewTitle_Click(object sender, EventArgs e)
        {
            Title newTitle;

            //Create a new detail window for creation
            TitleView test = new TitleView();
            test.CurrentMode = TitleView.Mode.Creation;
            //Display as a pop-up and handle the result.
            if (test.ShowDialog() == DialogResult.OK)
            {
                newTitle = test.CurrentTitle;
                ShopDataModel.Titles.Add(newTitle);
                RefreshView();
            }

        }

        /// <summary>
        /// Event handler to force a save of the data when the form is closed.
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void ShopView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShopDataModel.SaveData();
        }

        /// <summary>
        /// Event Handler for updating the selected item from the Vinyl Shelf display
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void lvwVinyl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedItem(lvwVinyl);
        }

        /// <summary>
        /// Event Handler for updating the selected item from the CD Shelf display
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void lvwCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedItem(lvwCD);
        }

        /// <summary>
        /// Event Handler for updating the selected item from the Tape Shelf display
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void lvwTape_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedItem(lvwTape);
        }

        /// <summary>
        /// Event Handler for the button to move stock of the selected item into storage
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void btnToShelf_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.Data.MoveStockToShelf(1);
                RefreshActionButtons();
                selectedItem.RefreshListItem();
            }
        }

        /// <summary>
        /// Event Handler for the button to move stock of the selected item onto the shelf
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void btnToStore_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.Data.MoveStockToStore(1);
                RefreshActionButtons();
                selectedItem.RefreshListItem();
            }
        }

        /// <summary>
        /// Event Handler for the button to restock a title.
        /// Opens a new form as a popup dialog to request the details
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void btnRestockTitle_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                //Create a new form in Stocking mode
                TitleView detailForm = new TitleView();
                detailForm.CurrentMode = TitleView.Mode.Stocking;
                detailForm.CurrentTitle = selectedItem.Data;

                //Show it as a dialog and if it was not cancelled, 
                //refresh the display as the model will have changed
                if (detailForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshActionButtons();
                    RefreshView();
                }
            }
        }

        /// <summary>
        /// Event handler for double clicking on a title on the shelf to edit it.
        /// Note that this handler is shared between the list view objects
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void OnListDoubleClick(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                TitleView detailForm = new TitleView();
                detailForm.CurrentMode = TitleView.Mode.Editing;
                detailForm.CurrentTitle = selectedItem.Data;
                if (detailForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshActionButtons();
                    selectedItem.RefreshListItem();
                }
            }
        }

        /// <summary>
        /// Event handler for triggering a new search/filter as the user types into
        /// the search box
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            //Reset the view of the data
            RefreshView();
            //Then eliminate non-matching titles
            SearchForItem(searchText, lvwVinyl);
            SearchForItem(searchText, lvwCD);
            SearchForItem(searchText, lvwTape);
        }
 
        /// <summary>
        /// Event handler for selling an item by clicking the sale button.
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void btnSale_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.Data.SellCopy();
                RefreshView();
                RefreshActionButtons();
            }
        }

        /// <summary>
        /// Event handler for manually saving the data
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ShopDataModel.SaveData();
        }

        /// <summary>
        /// Event handler to make sure the window is refreshed when it is displayed
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void ShopView_Shown(object sender, EventArgs e)
        {
            RefreshView();
        }

        #endregion

        #region Helper methods
        /// <summary>
        /// Refresh the view of the data model in the window.
        /// </summary>
        private void RefreshView()
        {
            //Variables to total the space used on shelves
            float usedSpaceVinyl = 0, usedSpaceCD = 0, usedSpaceTape = 0;

            //Reset GUI elements
            lvwVinyl.Items.Clear();
            lvwCD.Items.Clear();
            lvwTape.Items.Clear();

            //Reset columns on the shelf displays
            TitleListViewItem.SetListColumns(lvwVinyl);
            TitleListViewItem.SetListColumns(lvwCD);
            TitleListViewItem.SetListColumns(lvwTape);

            //Check there is data to display
            if (ShopDataModel != null)
            {
                //Loop over all titles
                for (int index = 0; index < ShopDataModel.Titles.Count; index++)
                {
                    Title currentTitle = ShopDataModel.Titles[index];
                    ListViewItem newItem = new TitleListViewItem(currentTitle).ListItem;
                    //restore highlight to currently selected item
                    if (selectedItem != null && selectedItem.Data == currentTitle)
                    {
                        newItem.BackColor = Color.LightBlue;
                    }

                    // Put each title in the correct shelf and count up the space used
                    if (currentTitle is Vinyl)
                    {
                        lvwVinyl.Items.Add(newItem);
                        usedSpaceVinyl += currentTitle.Width * currentTitle.CopiesOnShelf;
                    }
                    else if (currentTitle is CompactDisc)
                    {
                        lvwCD.Items.Add(newItem);
                        usedSpaceCD += currentTitle.Width * currentTitle.CopiesOnShelf;
                    }
                    else if (currentTitle is Cassette)
                    {
                        lvwTape.Items.Add(newItem);
                        usedSpaceTape += currentTitle.Width * currentTitle.CopiesOnShelf;
                    }

                }
            }

            //Display the space used on the three shelves
            SetSpaceDisplay(prgVinylShelfSpace, usedSpaceVinyl);
            SetSpaceDisplay(prgCDShelfSpace, usedSpaceCD);
            SetSpaceDisplay(prgTapeShelfSpace, usedSpaceTape);
        }

        /// <summary>
        /// Method to display how much space is used on a shelf in a progress bar
        /// </summary>
        /// <param name="bar">The control (ProgressBar) used for the display</param>
        /// <param name="spaceUsed">The width taken up by products</param>
        private void SetSpaceDisplay(ProgressBar bar, float spaceUsed)
        {
            if (spaceUsed > Shop.SHELF_LENGTH)
            {
                //Cap the displayed value at the maximum
                bar.Value = bar.Maximum;
            }
            else
            {
                //Display the correct proportion of the space used.
                bar.Value = (int)(spaceUsed * 100f / Shop.SHELF_LENGTH);
            }
        }


        /// <summary>
        /// Method to update the current selected item and highlight it in the list views
        /// </summary>
        /// <param name="lvwActiveList"></param>
        private void UpdateSelectedItem(ListView lvwActiveList)
        {
            if (selectedItem != null && selectedItem.ListItem.ListView != null)
            {
                //Unhighlight the existing item
                selectedItem.ListItem.BackColor = selectedItem.ListItem.ListView.BackColor;
                selectedItem.ListItem.ListView.Refresh();
            }

            if (lvwActiveList.SelectedItems.Count == 1)
            {
                //remember the selected item and highlight it
                selectedItem = (TitleListViewItem)lvwActiveList.SelectedItems[0].Tag;
                selectedItem.ListItem.BackColor = Color.LightBlue;
            }
            else
            {
                //we have no new selected item, so just clear the old one from memory
                selectedItem = null;
            }
            RefreshActionButtons();
        }

        /// <summary>
        /// Adjust the action buttons so they are valid for the current 
        /// state of the currently selected title
        /// </summary>
        private void RefreshActionButtons()
        {
            if (selectedItem == null)
            {
                //Disable all buttons
                btnRestockTitle.Enabled = false;
                btnToShelf.Enabled = false;
                btnToStore.Enabled = false;
                btnSale.Enabled = false;
            }
            else
            {
                //Enable some or all buttons.
                btnRestockTitle.Enabled = true;
                btnToShelf.Enabled = selectedItem.Data.CopiesInStock > 0;
                btnToStore.Enabled = selectedItem.Data.CopiesOnShelf > 0;
                btnSale.Enabled = selectedItem.Data.CopiesOnShelf > 0;
            }
        }

        /// <summary>
        /// Remove the items that don't match a search term from a list view control
        /// </summary>
        /// <param name="text">The string to match against</param>
        /// <param name="list">The control to filter</param>
        private void SearchForItem(string text, ListView list)
        {
            for (int index = 0; index < list.Items.Count; index++)
            {
                ListViewItem currentItem = list.Items[index];
                if (currentItem.Text.ToUpper().Contains(text.ToUpper()) || currentItem.SubItems[1].Text.ToUpper().Contains(text.ToUpper()))
                {
                    //automatically select a matching item, and make sure it's scrolled to be visible.
                    currentItem.Selected = true;
                    currentItem.EnsureVisible();
                }
                else
                {
                    list.Items.Remove(currentItem);
                    //Exceptionally, we must decrement the counter here as the list is now 
                    //shorter by the current item.  To not do so would skip elements.
                    index--;
                }
            }
        }

    #endregion

    }
}

