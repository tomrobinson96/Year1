namespace MusicShop
{
    partial class TitleView
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
            this.radVinylSelect = new System.Windows.Forms.RadioButton();
            this.radCDSelect = new System.Windows.Forms.RadioButton();
            this.radTapeSelect = new System.Windows.Forms.RadioButton();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtOnShelf = new System.Windows.Forms.TextBox();
            this.lblShelf = new System.Windows.Forms.Label();
            this.txtInStore = new System.Windows.Forms.TextBox();
            this.lblStore = new System.Windows.Forms.Label();
            this.txtSold = new System.Windows.Forms.TextBox();
            this.lblSold = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radVinylSelect
            // 
            this.radVinylSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radVinylSelect.Checked = true;
            this.radVinylSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radVinylSelect.Location = new System.Drawing.Point(12, 12);
            this.radVinylSelect.Name = "radVinylSelect";
            this.radVinylSelect.Size = new System.Drawing.Size(96, 27);
            this.radVinylSelect.TabIndex = 0;
            this.radVinylSelect.TabStop = true;
            this.radVinylSelect.Text = "&Vinyl";
            this.radVinylSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radVinylSelect.UseVisualStyleBackColor = true;
            // 
            // radCDSelect
            // 
            this.radCDSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCDSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radCDSelect.Location = new System.Drawing.Point(216, 12);
            this.radCDSelect.Name = "radCDSelect";
            this.radCDSelect.Size = new System.Drawing.Size(96, 27);
            this.radCDSelect.TabIndex = 1;
            this.radCDSelect.Text = "&CD";
            this.radCDSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCDSelect.UseVisualStyleBackColor = true;
            // 
            // radTapeSelect
            // 
            this.radTapeSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTapeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radTapeSelect.Location = new System.Drawing.Point(114, 12);
            this.radTapeSelect.Name = "radTapeSelect";
            this.radTapeSelect.Size = new System.Drawing.Size(96, 27);
            this.radTapeSelect.TabIndex = 2;
            this.radTapeSelect.Text = "Casse&tte";
            this.radTapeSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTapeSelect.UseVisualStyleBackColor = true;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(12, 60);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(40, 17);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "&Artist";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(115, 60);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(197, 22);
            this.txtArtist.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(115, 88);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(197, 22);
            this.txtTitle.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "&Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(95, 22);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Text = "£0.00";
            this.txtPrice.TextChanged += new System.EventHandler(this.EnableOKOnTextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 116);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "&Price";
            // 
            // txtOnShelf
            // 
            this.txtOnShelf.Location = new System.Drawing.Point(115, 144);
            this.txtOnShelf.Name = "txtOnShelf";
            this.txtOnShelf.ReadOnly = true;
            this.txtOnShelf.Size = new System.Drawing.Size(95, 22);
            this.txtOnShelf.TabIndex = 10;
            this.txtOnShelf.Text = "0";
            this.txtOnShelf.TextChanged += new System.EventHandler(this.EnableOKOnTextChanged);
            this.txtOnShelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnShelf_KeyPress);
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Location = new System.Drawing.Point(12, 144);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(63, 17);
            this.lblShelf.TabIndex = 9;
            this.lblShelf.Text = "On Shelf";
            // 
            // txtInStore
            // 
            this.txtInStore.Location = new System.Drawing.Point(115, 172);
            this.txtInStore.Name = "txtInStore";
            this.txtInStore.ReadOnly = true;
            this.txtInStore.Size = new System.Drawing.Size(95, 22);
            this.txtInStore.TabIndex = 12;
            this.txtInStore.Text = "0";
            this.txtInStore.TextChanged += new System.EventHandler(this.EnableOKOnTextChanged);
            this.txtInStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnShelf_KeyPress);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(12, 172);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(57, 17);
            this.lblStore.TabIndex = 11;
            this.lblStore.Text = "In Store";
            // 
            // txtSold
            // 
            this.txtSold.Location = new System.Drawing.Point(115, 200);
            this.txtSold.Name = "txtSold";
            this.txtSold.ReadOnly = true;
            this.txtSold.Size = new System.Drawing.Size(95, 22);
            this.txtSold.TabIndex = 14;
            this.txtSold.Text = "0";
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(12, 200);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(36, 17);
            this.lblSold.TabIndex = 13;
            this.lblSold.Text = "Sold";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(216, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 50);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(216, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TitleView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(318, 229);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSold);
            this.Controls.Add(this.lblSold);
            this.Controls.Add(this.txtInStore);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.txtOnShelf);
            this.Controls.Add(this.lblShelf);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.radTapeSelect);
            this.Controls.Add(this.radCDSelect);
            this.Controls.Add(this.radVinylSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TitleView";
            this.Text = "Title Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radVinylSelect;
        private System.Windows.Forms.RadioButton radCDSelect;
        private System.Windows.Forms.RadioButton radTapeSelect;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtOnShelf;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.TextBox txtInStore;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.TextBox txtSold;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}