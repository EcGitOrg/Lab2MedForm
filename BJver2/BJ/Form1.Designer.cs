﻿namespace BJ
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
            this._exitBotton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._playerPrintCard1 = new System.Windows.Forms.TextBox();
            this._dealerPrint = new System.Windows.Forms.TextBox();
            this._betButton = new System.Windows.Forms.Button();
            this._betReadBox = new System.Windows.Forms.TextBox();
            this._pickCard = new System.Windows.Forms.Button();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this._wallet = new System.Windows.Forms.Label();
            this._stand = new System.Windows.Forms.Button();
            this._textBoxPlayerPoints = new System.Windows.Forms.TextBox();
            this._playerTotal = new System.Windows.Forms.Label();
            this._dealerTotal = new System.Windows.Forms.Label();
            this._textBoxDealerPoints = new System.Windows.Forms.TextBox();
            this._playerPrintsCard2 = new System.Windows.Forms.TextBox();
            this._playerPrintsCard5 = new System.Windows.Forms.TextBox();
            this._playerPrintsCard4 = new System.Windows.Forms.TextBox();
            this._playerPrintsCard1 = new System.Windows.Forms.TextBox();
            this._playerPrintsCard6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this._playerPrintsCard3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _exitBotton
            // 
            this._exitBotton.Location = new System.Drawing.Point(878, 642);
            this._exitBotton.Name = "_exitBotton";
            this._exitBotton.Size = new System.Drawing.Size(111, 39);
            this._exitBotton.TabIndex = 1;
            this._exitBotton.Text = "Exit";
            this._exitBotton.UseVisualStyleBackColor = true;
            this._exitBotton.Click += new System.EventHandler(this._exitBotton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = global::BJ.Properties.Resources.dealer;
            this.pictureBox1.Image = global::BJ.Properties.Resources.dealer;
            this.pictureBox1.Location = new System.Drawing.Point(895, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BJ.Properties.Resources.Player;
            this.pictureBox2.Location = new System.Drawing.Point(47, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // _playerPrintCard1
            // 
            this._playerPrintCard1.Location = new System.Drawing.Point(577, 300);
            this._playerPrintCard1.Multiline = true;
            this._playerPrintCard1.Name = "_playerPrintCard1";
            this._playerPrintCard1.ReadOnly = true;
            this._playerPrintCard1.Size = new System.Drawing.Size(47, 65);
            this._playerPrintCard1.TabIndex = 7;
            // 
            // _dealerPrint
            // 
            this._dealerPrint.Location = new System.Drawing.Point(895, 437);
            this._dealerPrint.Multiline = true;
            this._dealerPrint.Name = "_dealerPrint";
            this._dealerPrint.ReadOnly = true;
            this._dealerPrint.Size = new System.Drawing.Size(163, 120);
            this._dealerPrint.TabIndex = 8;
            // 
            // _betButton
            // 
            this._betButton.Location = new System.Drawing.Point(228, 260);
            this._betButton.Name = "_betButton";
            this._betButton.Size = new System.Drawing.Size(75, 23);
            this._betButton.TabIndex = 9;
            this._betButton.Text = "Bet";
            this._betButton.UseVisualStyleBackColor = true;
            this._betButton.Click += new System.EventHandler(this._betButton_Click);
            // 
            // _betReadBox
            // 
            this._betReadBox.Location = new System.Drawing.Point(310, 261);
            this._betReadBox.Name = "_betReadBox";
            this._betReadBox.Size = new System.Drawing.Size(75, 22);
            this._betReadBox.TabIndex = 10;
            // 
            // _pickCard
            // 
            this._pickCard.Location = new System.Drawing.Point(231, 376);
            this._pickCard.Name = "_pickCard";
            this._pickCard.Size = new System.Drawing.Size(175, 23);
            this._pickCard.TabIndex = 11;
            this._pickCard.Text = "Extra card";
            this._pickCard.UseVisualStyleBackColor = true;
            this._pickCard.Click += new System.EventHandler(this._pickCard_Click);
            // 
            // textBoxWallet
            // 
            this.textBoxWallet.Location = new System.Drawing.Point(285, 232);
            this.textBoxWallet.Name = "textBoxWallet";
            this.textBoxWallet.ReadOnly = true;
            this.textBoxWallet.Size = new System.Drawing.Size(100, 22);
            this.textBoxWallet.TabIndex = 12;
            // 
            // _wallet
            // 
            this._wallet.Location = new System.Drawing.Point(228, 232);
            this._wallet.Name = "_wallet";
            this._wallet.Size = new System.Drawing.Size(50, 22);
            this._wallet.TabIndex = 13;
            this._wallet.Text = "Wallet";
            this._wallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _stand
            // 
            this._stand.Location = new System.Drawing.Point(231, 405);
            this._stand.Name = "_stand";
            this._stand.Size = new System.Drawing.Size(175, 23);
            this._stand.TabIndex = 14;
            this._stand.Text = "Stand";
            this._stand.UseVisualStyleBackColor = true;
            this._stand.Click += new System.EventHandler(this._stand_Click);
            // 
            // _textBoxPlayerPoints
            // 
            this._textBoxPlayerPoints.Location = new System.Drawing.Point(122, 573);
            this._textBoxPlayerPoints.Name = "_textBoxPlayerPoints";
            this._textBoxPlayerPoints.ReadOnly = true;
            this._textBoxPlayerPoints.Size = new System.Drawing.Size(75, 22);
            this._textBoxPlayerPoints.TabIndex = 16;
            // 
            // _playerTotal
            // 
            this._playerTotal.Location = new System.Drawing.Point(44, 573);
            this._playerTotal.Name = "_playerTotal";
            this._playerTotal.Size = new System.Drawing.Size(72, 22);
            this._playerTotal.TabIndex = 17;
            this._playerTotal.Text = "Total";
            this._playerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dealerTotal
            // 
            this._dealerTotal.Location = new System.Drawing.Point(986, 564);
            this._dealerTotal.Name = "_dealerTotal";
            this._dealerTotal.Size = new System.Drawing.Size(72, 22);
            this._dealerTotal.TabIndex = 18;
            this._dealerTotal.Text = "Total";
            this._dealerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _textBoxDealerPoints
            // 
            this._textBoxDealerPoints.Location = new System.Drawing.Point(895, 564);
            this._textBoxDealerPoints.Name = "_textBoxDealerPoints";
            this._textBoxDealerPoints.ReadOnly = true;
            this._textBoxDealerPoints.Size = new System.Drawing.Size(74, 22);
            this._textBoxDealerPoints.TabIndex = 19;
            // 
            // _playerPrintsCard2
            // 
            this._playerPrintsCard2.Location = new System.Drawing.Point(97, 437);
            this._playerPrintsCard2.Multiline = true;
            this._playerPrintsCard2.Name = "_playerPrintsCard2";
            this._playerPrintsCard2.ReadOnly = true;
            this._playerPrintsCard2.Size = new System.Drawing.Size(44, 60);
            this._playerPrintsCard2.TabIndex = 20;
            // 
            // _playerPrintsCard5
            // 
            this._playerPrintsCard5.Location = new System.Drawing.Point(97, 503);
            this._playerPrintsCard5.Multiline = true;
            this._playerPrintsCard5.Name = "_playerPrintsCard5";
            this._playerPrintsCard5.Size = new System.Drawing.Size(44, 60);
            this._playerPrintsCard5.TabIndex = 21;
            // 
            // _playerPrintsCard4
            // 
            this._playerPrintsCard4.Location = new System.Drawing.Point(47, 503);
            this._playerPrintsCard4.Multiline = true;
            this._playerPrintsCard4.Name = "_playerPrintsCard4";
            this._playerPrintsCard4.Size = new System.Drawing.Size(44, 60);
            this._playerPrintsCard4.TabIndex = 22;
            // 
            // _playerPrintsCard1
            // 
            this._playerPrintsCard1.Location = new System.Drawing.Point(47, 437);
            this._playerPrintsCard1.Multiline = true;
            this._playerPrintsCard1.Name = "_playerPrintsCard1";
            this._playerPrintsCard1.ReadOnly = true;
            this._playerPrintsCard1.Size = new System.Drawing.Size(44, 60);
            this._playerPrintsCard1.TabIndex = 23;
            // 
            // _playerPrintsCard6
            // 
            this._playerPrintsCard6.Location = new System.Drawing.Point(147, 503);
            this._playerPrintsCard6.Multiline = true;
            this._playerPrintsCard6.Name = "_playerPrintsCard6";
            this._playerPrintsCard6.Size = new System.Drawing.Size(44, 60);
            this._playerPrintsCard6.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(730, 433);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 64);
            this.textBox5.TabIndex = 25;
            // 
            // _playerPrintsCard3
            // 
            this._playerPrintsCard3.Location = new System.Drawing.Point(147, 437);
            this._playerPrintsCard3.Multiline = true;
            this._playerPrintsCard3.Name = "_playerPrintsCard3";
            this._playerPrintsCard3.Size = new System.Drawing.Size(44, 60);
            this._playerPrintsCard3.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._playerPrintsCard3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this._playerPrintsCard6);
            this.Controls.Add(this._playerPrintsCard1);
            this.Controls.Add(this._playerPrintsCard4);
            this.Controls.Add(this._playerPrintsCard5);
            this.Controls.Add(this._playerPrintsCard2);
            this.Controls.Add(this._textBoxDealerPoints);
            this.Controls.Add(this._dealerTotal);
            this.Controls.Add(this._playerTotal);
            this.Controls.Add(this._textBoxPlayerPoints);
            this.Controls.Add(this._stand);
            this.Controls.Add(this._wallet);
            this.Controls.Add(this.textBoxWallet);
            this.Controls.Add(this._pickCard);
            this.Controls.Add(this._betReadBox);
            this.Controls.Add(this._betButton);
            this.Controls.Add(this._dealerPrint);
            this.Controls.Add(this._playerPrintCard1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._exitBotton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _exitBotton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox _playerPrintCard1;
        private System.Windows.Forms.TextBox _dealerPrint;
        private System.Windows.Forms.Button _betButton;
        private System.Windows.Forms.TextBox _betReadBox;
        private System.Windows.Forms.Button _pickCard;
        private System.Windows.Forms.Label _wallet;
        private System.Windows.Forms.Button _stand;
        private System.Windows.Forms.TextBox _textBoxPlayerPoints;
        private System.Windows.Forms.Label _playerTotal;
        private System.Windows.Forms.Label _dealerTotal;
        private System.Windows.Forms.TextBox _textBoxDealerPoints;
        public System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.TextBox _playerPrintsCard2;
        private System.Windows.Forms.TextBox _playerPrintsCard5;
        private System.Windows.Forms.TextBox _playerPrintsCard4;
        private System.Windows.Forms.TextBox _playerPrintsCard1;
        private System.Windows.Forms.TextBox _playerPrintsCard6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox _playerPrintsCard3;
        private System.Windows.Forms.Label label1;
    }
}

