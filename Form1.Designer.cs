namespace Coinbase_Investment_Tracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GridInvestments = new System.Windows.Forms.DataGridView();
            this.LabelTotalInvested = new System.Windows.Forms.Label();
            this.LabelTotalSell = new System.Windows.Forms.Label();
            this.TextboxBitcoinAmount = new System.Windows.Forms.TextBox();
            this.LabelBitcoinAmount = new System.Windows.Forms.Label();
            this.LabelDollarAmount = new System.Windows.Forms.Label();
            this.TextboxDollarAmount = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelNoticeDollar = new System.Windows.Forms.Label();
            this.LabelNoticeSellFees = new System.Windows.Forms.Label();
            this.LabelTotalBTC = new System.Windows.Forms.Label();
            this.QrDonate = new System.Windows.Forms.PictureBox();
            this.LabelDonation = new System.Windows.Forms.Label();
            this.numberHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DollarHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvestments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // GridInvestments
            // 
            this.GridInvestments.AllowUserToAddRows = false;
            this.GridInvestments.AllowUserToDeleteRows = false;
            this.GridInvestments.AllowUserToResizeColumns = false;
            this.GridInvestments.AllowUserToResizeRows = false;
            this.GridInvestments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridInvestments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInvestments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberHeader,
            this.BitHeader,
            this.DollarHeader,
            this.DateHeader,
            this.ChangeHeader,
            this.SellHeader});
            this.GridInvestments.Location = new System.Drawing.Point(169, 12);
            this.GridInvestments.Name = "GridInvestments";
            this.GridInvestments.Size = new System.Drawing.Size(568, 413);
            this.GridInvestments.TabIndex = 0;
            this.GridInvestments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridInvestments_KeyDown);
            // 
            // LabelTotalInvested
            // 
            this.LabelTotalInvested.AutoSize = true;
            this.LabelTotalInvested.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalInvested.Location = new System.Drawing.Point(221, 436);
            this.LabelTotalInvested.Name = "LabelTotalInvested";
            this.LabelTotalInvested.Size = new System.Drawing.Size(203, 39);
            this.LabelTotalInvested.TabIndex = 1;
            this.LabelTotalInvested.Text = "USD Invested:";
            // 
            // LabelTotalSell
            // 
            this.LabelTotalSell.AutoSize = true;
            this.LabelTotalSell.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSell.Location = new System.Drawing.Point(221, 514);
            this.LabelTotalSell.Name = "LabelTotalSell";
            this.LabelTotalSell.Size = new System.Drawing.Size(152, 39);
            this.LabelTotalSell.TabIndex = 2;
            this.LabelTotalSell.Text = "Total Sell: ";
            // 
            // TextboxBitcoinAmount
            // 
            this.TextboxBitcoinAmount.Location = new System.Drawing.Point(24, 34);
            this.TextboxBitcoinAmount.Name = "TextboxBitcoinAmount";
            this.TextboxBitcoinAmount.Size = new System.Drawing.Size(100, 27);
            this.TextboxBitcoinAmount.TabIndex = 3;
            // 
            // LabelBitcoinAmount
            // 
            this.LabelBitcoinAmount.AutoSize = true;
            this.LabelBitcoinAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBitcoinAmount.Location = new System.Drawing.Point(20, 12);
            this.LabelBitcoinAmount.Name = "LabelBitcoinAmount";
            this.LabelBitcoinAmount.Size = new System.Drawing.Size(94, 19);
            this.LabelBitcoinAmount.TabIndex = 4;
            this.LabelBitcoinAmount.Text = "BTC Amount";
            // 
            // LabelDollarAmount
            // 
            this.LabelDollarAmount.AutoSize = true;
            this.LabelDollarAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDollarAmount.Location = new System.Drawing.Point(17, 76);
            this.LabelDollarAmount.Name = "LabelDollarAmount";
            this.LabelDollarAmount.Size = new System.Drawing.Size(110, 19);
            this.LabelDollarAmount.TabIndex = 5;
            this.LabelDollarAmount.Text = "Dollar Amount";
            // 
            // TextboxDollarAmount
            // 
            this.TextboxDollarAmount.Location = new System.Drawing.Point(21, 98);
            this.TextboxDollarAmount.Name = "TextboxDollarAmount";
            this.TextboxDollarAmount.Size = new System.Drawing.Size(100, 27);
            this.TextboxDollarAmount.TabIndex = 6;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.Location = new System.Drawing.Point(24, 131);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 29);
            this.ButtonSubmit.TabIndex = 7;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelNoticeDollar
            // 
            this.LabelNoticeDollar.AutoSize = true;
            this.LabelNoticeDollar.Location = new System.Drawing.Point(17, 177);
            this.LabelNoticeDollar.Name = "LabelNoticeDollar";
            this.LabelNoticeDollar.Size = new System.Drawing.Size(120, 57);
            this.LabelNoticeDollar.TabIndex = 8;
            this.LabelNoticeDollar.Text = "*include all fees \r\nin dollar amount\r\nsubmission";
            // 
            // LabelNoticeSellFees
            // 
            this.LabelNoticeSellFees.AutoSize = true;
            this.LabelNoticeSellFees.Location = new System.Drawing.Point(17, 245);
            this.LabelNoticeSellFees.Name = "LabelNoticeSellFees";
            this.LabelNoticeSellFees.Size = new System.Drawing.Size(123, 76);
            this.LabelNoticeSellFees.TabIndex = 9;
            this.LabelNoticeSellFees.Text = "*all sell values \r\ninclude both\r\nthe Coinbase fee \r\nand bank fee";
            // 
            // LabelTotalBTC
            // 
            this.LabelTotalBTC.AutoSize = true;
            this.LabelTotalBTC.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalBTC.Location = new System.Drawing.Point(221, 475);
            this.LabelTotalBTC.Name = "LabelTotalBTC";
            this.LabelTotalBTC.Size = new System.Drawing.Size(185, 39);
            this.LabelTotalBTC.TabIndex = 10;
            this.LabelTotalBTC.Text = "BTC Owned: ";
            // 
            // QrDonate
            // 
            this.QrDonate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QrDonate.BackgroundImage")));
            this.QrDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QrDonate.Location = new System.Drawing.Point(12, 434);
            this.QrDonate.Name = "QrDonate";
            this.QrDonate.Size = new System.Drawing.Size(119, 116);
            this.QrDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QrDonate.TabIndex = 11;
            this.QrDonate.TabStop = false;
            // 
            // LabelDonation
            // 
            this.LabelDonation.AutoSize = true;
            this.LabelDonation.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDonation.Location = new System.Drawing.Point(17, 415);
            this.LabelDonation.Name = "LabelDonation";
            this.LabelDonation.Size = new System.Drawing.Size(110, 19);
            this.LabelDonation.TabIndex = 12;
            this.LabelDonation.Text = "Donation Code";
            // 
            // numberHeader
            // 
            this.numberHeader.HeaderText = "#";
            this.numberHeader.Name = "numberHeader";
            this.numberHeader.ReadOnly = true;
            this.numberHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numberHeader.Width = 25;
            // 
            // BitHeader
            // 
            this.BitHeader.HeaderText = "BTC Amount";
            this.BitHeader.Name = "BitHeader";
            this.BitHeader.ReadOnly = true;
            this.BitHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DollarHeader
            // 
            this.DollarHeader.HeaderText = "USD Amount";
            this.DollarHeader.Name = "DollarHeader";
            this.DollarHeader.ReadOnly = true;
            this.DollarHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DateHeader
            // 
            this.DateHeader.HeaderText = "Date Logged";
            this.DateHeader.Name = "DateHeader";
            this.DateHeader.ReadOnly = true;
            this.DateHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ChangeHeader
            // 
            this.ChangeHeader.HeaderText = "USD Change";
            this.ChangeHeader.Name = "ChangeHeader";
            this.ChangeHeader.ReadOnly = true;
            this.ChangeHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SellHeader
            // 
            this.SellHeader.HeaderText = "Current Sell Value";
            this.SellHeader.Name = "SellHeader";
            this.SellHeader.ReadOnly = true;
            this.SellHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.LabelDonation);
            this.Controls.Add(this.QrDonate);
            this.Controls.Add(this.LabelTotalBTC);
            this.Controls.Add(this.LabelNoticeSellFees);
            this.Controls.Add(this.LabelNoticeDollar);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextboxDollarAmount);
            this.Controls.Add(this.LabelDollarAmount);
            this.Controls.Add(this.LabelBitcoinAmount);
            this.Controls.Add(this.TextboxBitcoinAmount);
            this.Controls.Add(this.LabelTotalSell);
            this.Controls.Add(this.LabelTotalInvested);
            this.Controls.Add(this.GridInvestments);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Coinbase Investment Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvestments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrDonate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridInvestments;
        private System.Windows.Forms.Label LabelTotalInvested;
        private System.Windows.Forms.Label LabelTotalSell;
        private System.Windows.Forms.TextBox TextboxBitcoinAmount;
        private System.Windows.Forms.Label LabelBitcoinAmount;
        private System.Windows.Forms.Label LabelDollarAmount;
        private System.Windows.Forms.TextBox TextboxDollarAmount;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label LabelNoticeDollar;
        private System.Windows.Forms.Label LabelNoticeSellFees;
        private System.Windows.Forms.Label LabelTotalBTC;
        private System.Windows.Forms.PictureBox QrDonate;
        private System.Windows.Forms.Label LabelDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DollarHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellHeader;
    }
}

