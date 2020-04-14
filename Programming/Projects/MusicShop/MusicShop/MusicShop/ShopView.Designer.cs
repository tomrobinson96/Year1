namespace MusicShop
{
    partial class ShopView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpShelfFrame = new System.Windows.Forms.GroupBox();
            this.prgTapeShelfSpace = new System.Windows.Forms.ProgressBar();
            this.prgCDShelfSpace = new System.Windows.Forms.ProgressBar();
            this.prgVinylShelfSpace = new System.Windows.Forms.ProgressBar();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTapeShelf = new System.Windows.Forms.Label();
            this.lvwTape = new System.Windows.Forms.ListView();
            this.lblCDShelf = new System.Windows.Forms.Label();
            this.lvwCD = new System.Windows.Forms.ListView();
            this.lblVinylShelf = new System.Windows.Forms.Label();
            this.lvwVinyl = new System.Windows.Forms.ListView();
            this.btnNewTitle = new System.Windows.Forms.Button();
            this.btnRestockTitle = new System.Windows.Forms.Button();
            this.btnToShelf = new System.Windows.Forms.Button();
            this.btnToStore = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpShelfFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShelfFrame
            // 
            this.grpShelfFrame.Controls.Add(this.prgTapeShelfSpace);
            this.grpShelfFrame.Controls.Add(this.prgCDShelfSpace);
            this.grpShelfFrame.Controls.Add(this.prgVinylShelfSpace);
            this.grpShelfFrame.Controls.Add(this.txtSearch);
            this.grpShelfFrame.Controls.Add(this.lblSearch);
            this.grpShelfFrame.Controls.Add(this.lblTapeShelf);
            this.grpShelfFrame.Controls.Add(this.lvwTape);
            this.grpShelfFrame.Controls.Add(this.lblCDShelf);
            this.grpShelfFrame.Controls.Add(this.lvwCD);
            this.grpShelfFrame.Controls.Add(this.lblVinylShelf);
            this.grpShelfFrame.Controls.Add(this.lvwVinyl);
            this.grpShelfFrame.Location = new System.Drawing.Point(12, 12);
            this.grpShelfFrame.Name = "grpShelfFrame";
            this.grpShelfFrame.Size = new System.Drawing.Size(755, 462);
            this.grpShelfFrame.TabIndex = 0;
            this.grpShelfFrame.TabStop = false;
            this.grpShelfFrame.Text = "Display Shelves";
            // 
            // prgTapeShelfSpace
            // 
            this.prgTapeShelfSpace.Location = new System.Drawing.Point(195, 259);
            this.prgTapeShelfSpace.Name = "prgTapeShelfSpace";
            this.prgTapeShelfSpace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prgTapeShelfSpace.Size = new System.Drawing.Size(170, 13);
            this.prgTapeShelfSpace.TabIndex = 11;
            this.prgTapeShelfSpace.Value = 50;
            // 
            // prgCDShelfSpace
            // 
            this.prgCDShelfSpace.Location = new System.Drawing.Point(578, 38);
            this.prgCDShelfSpace.Name = "prgCDShelfSpace";
            this.prgCDShelfSpace.Size = new System.Drawing.Size(170, 13);
            this.prgCDShelfSpace.Step = 1;
            this.prgCDShelfSpace.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgCDShelfSpace.TabIndex = 10;
            this.prgCDShelfSpace.Value = 50;
            // 
            // prgVinylShelfSpace
            // 
            this.prgVinylShelfSpace.Location = new System.Drawing.Point(195, 38);
            this.prgVinylShelfSpace.Name = "prgVinylShelfSpace";
            this.prgVinylShelfSpace.Size = new System.Drawing.Size(170, 13);
            this.prgVinylShelfSpace.Step = 1;
            this.prgVinylShelfSpace.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgVinylShelfSpace.TabIndex = 9;
            this.prgVinylShelfSpace.Value = 50;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(394, 278);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(355, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(394, 258);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // lblTapeShelf
            // 
            this.lblTapeShelf.AutoSize = true;
            this.lblTapeShelf.Location = new System.Drawing.Point(11, 255);
            this.lblTapeShelf.Name = "lblTapeShelf";
            this.lblTapeShelf.Size = new System.Drawing.Size(107, 17);
            this.lblTapeShelf.TabIndex = 5;
            this.lblTapeShelf.Text = "Cassette Tapes";
            // 
            // lvwTape
            // 
            this.lvwTape.FullRowSelect = true;
            this.lvwTape.GridLines = true;
            this.lvwTape.Location = new System.Drawing.Point(11, 278);
            this.lvwTape.MultiSelect = false;
            this.lvwTape.Name = "lvwTape";
            this.lvwTape.Size = new System.Drawing.Size(355, 169);
            this.lvwTape.TabIndex = 6;
            this.lvwTape.UseCompatibleStateImageBehavior = false;
            this.lvwTape.View = System.Windows.Forms.View.Details;
            this.lvwTape.SelectedIndexChanged += new System.EventHandler(this.lvwTape_SelectedIndexChanged);
            this.lvwTape.DoubleClick += new System.EventHandler(this.OnListDoubleClick);
            // 
            // lblCDShelf
            // 
            this.lblCDShelf.AutoSize = true;
            this.lblCDShelf.Location = new System.Drawing.Point(395, 34);
            this.lblCDShelf.Name = "lblCDShelf";
            this.lblCDShelf.Size = new System.Drawing.Size(101, 17);
            this.lblCDShelf.TabIndex = 3;
            this.lblCDShelf.Text = "Compact Disks";
            // 
            // lvwCD
            // 
            this.lvwCD.FullRowSelect = true;
            this.lvwCD.GridLines = true;
            this.lvwCD.Location = new System.Drawing.Point(394, 57);
            this.lvwCD.MultiSelect = false;
            this.lvwCD.Name = "lvwCD";
            this.lvwCD.Size = new System.Drawing.Size(355, 169);
            this.lvwCD.TabIndex = 4;
            this.lvwCD.UseCompatibleStateImageBehavior = false;
            this.lvwCD.View = System.Windows.Forms.View.Details;
            this.lvwCD.SelectedIndexChanged += new System.EventHandler(this.lvwCD_SelectedIndexChanged);
            this.lvwCD.DoubleClick += new System.EventHandler(this.OnListDoubleClick);
            // 
            // lblVinylShelf
            // 
            this.lblVinylShelf.AutoSize = true;
            this.lblVinylShelf.Location = new System.Drawing.Point(12, 34);
            this.lblVinylShelf.Name = "lblVinylShelf";
            this.lblVinylShelf.Size = new System.Drawing.Size(88, 17);
            this.lblVinylShelf.TabIndex = 1;
            this.lblVinylShelf.Text = "Vinyl Albums";
            // 
            // lvwVinyl
            // 
            this.lvwVinyl.FullRowSelect = true;
            this.lvwVinyl.GridLines = true;
            this.lvwVinyl.Location = new System.Drawing.Point(11, 57);
            this.lvwVinyl.MultiSelect = false;
            this.lvwVinyl.Name = "lvwVinyl";
            this.lvwVinyl.Size = new System.Drawing.Size(355, 169);
            this.lvwVinyl.TabIndex = 2;
            this.lvwVinyl.UseCompatibleStateImageBehavior = false;
            this.lvwVinyl.View = System.Windows.Forms.View.Details;
            this.lvwVinyl.SelectedIndexChanged += new System.EventHandler(this.lvwVinyl_SelectedIndexChanged);
            this.lvwVinyl.DoubleClick += new System.EventHandler(this.OnListDoubleClick);
            // 
            // btnNewTitle
            // 
            this.btnNewTitle.Location = new System.Drawing.Point(785, 24);
            this.btnNewTitle.Name = "btnNewTitle";
            this.btnNewTitle.Size = new System.Drawing.Size(104, 49);
            this.btnNewTitle.TabIndex = 1;
            this.btnNewTitle.Text = "New Title";
            this.btnNewTitle.UseVisualStyleBackColor = true;
            this.btnNewTitle.Click += new System.EventHandler(this.btnNewTitle_Click);
            // 
            // btnRestockTitle
            // 
            this.btnRestockTitle.Enabled = false;
            this.btnRestockTitle.Location = new System.Drawing.Point(785, 79);
            this.btnRestockTitle.Name = "btnRestockTitle";
            this.btnRestockTitle.Size = new System.Drawing.Size(104, 49);
            this.btnRestockTitle.TabIndex = 2;
            this.btnRestockTitle.Text = "Restock Title";
            this.btnRestockTitle.UseVisualStyleBackColor = true;
            this.btnRestockTitle.Click += new System.EventHandler(this.btnRestockTitle_Click);
            // 
            // btnToShelf
            // 
            this.btnToShelf.Enabled = false;
            this.btnToShelf.Location = new System.Drawing.Point(785, 244);
            this.btnToShelf.Name = "btnToShelf";
            this.btnToShelf.Size = new System.Drawing.Size(104, 49);
            this.btnToShelf.TabIndex = 2;
            this.btnToShelf.Text = "To Shelf";
            this.btnToShelf.UseVisualStyleBackColor = true;
            this.btnToShelf.Click += new System.EventHandler(this.btnToShelf_Click);
            // 
            // btnToStore
            // 
            this.btnToStore.Enabled = false;
            this.btnToStore.Location = new System.Drawing.Point(785, 189);
            this.btnToStore.Name = "btnToStore";
            this.btnToStore.Size = new System.Drawing.Size(104, 49);
            this.btnToStore.TabIndex = 2;
            this.btnToStore.Text = "To Store";
            this.btnToStore.UseVisualStyleBackColor = true;
            this.btnToStore.Click += new System.EventHandler(this.btnToStore_Click);
            // 
            // btnSale
            // 
            this.btnSale.Enabled = false;
            this.btnSale.Location = new System.Drawing.Point(785, 134);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(104, 49);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Make Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(785, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnToStore);
            this.Controls.Add(this.btnToShelf);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnRestockTitle);
            this.Controls.Add(this.btnNewTitle);
            this.Controls.Add(this.grpShelfFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShopView";
            this.Text = "Music Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopView_FormClosing);
            this.Shown += new System.EventHandler(this.ShopView_Shown);
            this.grpShelfFrame.ResumeLayout(false);
            this.grpShelfFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShelfFrame;
        private System.Windows.Forms.ProgressBar prgTapeShelfSpace;
        private System.Windows.Forms.ProgressBar prgCDShelfSpace;
        private System.Windows.Forms.ProgressBar prgVinylShelfSpace;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTapeShelf;
        private System.Windows.Forms.ListView lvwTape;
        private System.Windows.Forms.Label lblCDShelf;
        private System.Windows.Forms.ListView lvwCD;
        private System.Windows.Forms.Label lblVinylShelf;
        private System.Windows.Forms.ListView lvwVinyl;
        private System.Windows.Forms.Button btnNewTitle;
        private System.Windows.Forms.Button btnRestockTitle;
        private System.Windows.Forms.Button btnToShelf;
        private System.Windows.Forms.Button btnToStore;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnSave;
    }
}

