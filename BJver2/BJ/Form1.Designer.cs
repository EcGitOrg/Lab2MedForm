namespace BJ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bid1 = new System.Windows.Forms.Button();
            this.bid5 = new System.Windows.Forms.Button();
            this.bid10 = new System.Windows.Forms.Button();
            this.bid25 = new System.Windows.Forms.Button();
            this.bid100 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // _exitBotton
            // 
            this._exitBotton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._exitBotton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._exitBotton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._exitBotton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_exitBotton.BackgroundImage")));
            this._exitBotton.Cursor = System.Windows.Forms.Cursors.Default;
            this._exitBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitBotton.Location = new System.Drawing.Point(1005, 585);
            this._exitBotton.Name = "_exitBotton";
            this._exitBotton.Size = new System.Drawing.Size(108, 108);
            this._exitBotton.TabIndex = 1;
            this._exitBotton.UseVisualStyleBackColor = false;
            this._exitBotton.Click += new System.EventHandler(this._exitBotton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::BJ.Properties.Resources.dealer;
            this.pictureBox1.Location = new System.Drawing.Point(917, 232);
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
            // _betButton
            // 
            this._betButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._betButton.Location = new System.Drawing.Point(228, 260);
            this._betButton.Name = "_betButton";
            this._betButton.Size = new System.Drawing.Size(75, 51);
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
            this._pickCard.Location = new System.Drawing.Point(298, 629);
            this._pickCard.Name = "_pickCard";
            this._pickCard.Size = new System.Drawing.Size(175, 23);
            this._pickCard.TabIndex = 11;
            this._pickCard.Text = "Next Card";
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
            this._stand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._stand.Image = ((System.Drawing.Image)(resources.GetObject("_stand.Image")));
            this._stand.ImageKey = "(none)";
            this._stand.Location = new System.Drawing.Point(577, 557);
            this._stand.Name = "_stand";
            this._stand.Size = new System.Drawing.Size(166, 85);
            this._stand.TabIndex = 14;
            this._stand.UseVisualStyleBackColor = true;
            this._stand.Click += new System.EventHandler(this._stand_Click);
            // 
            // _textBoxPlayerPoints
            // 
            this._textBoxPlayerPoints.Location = new System.Drawing.Point(228, 406);
            this._textBoxPlayerPoints.Name = "_textBoxPlayerPoints";
            this._textBoxPlayerPoints.ReadOnly = true;
            this._textBoxPlayerPoints.Size = new System.Drawing.Size(75, 22);
            this._textBoxPlayerPoints.TabIndex = 16;
            // 
            // _playerTotal
            // 
            this._playerTotal.Location = new System.Drawing.Point(228, 370);
            this._playerTotal.Name = "_playerTotal";
            this._playerTotal.Size = new System.Drawing.Size(72, 22);
            this._playerTotal.TabIndex = 17;
            this._playerTotal.Text = "Total";
            this._playerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dealerTotal
            // 
            this._dealerTotal.Location = new System.Drawing.Point(839, 370);
            this._dealerTotal.Name = "_dealerTotal";
            this._dealerTotal.Size = new System.Drawing.Size(72, 22);
            this._dealerTotal.TabIndex = 18;
            this._dealerTotal.Text = "Total";
            this._dealerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _textBoxDealerPoints
            // 
            this._textBoxDealerPoints.Location = new System.Drawing.Point(837, 406);
            this._textBoxDealerPoints.Name = "_textBoxDealerPoints";
            this._textBoxDealerPoints.ReadOnly = true;
            this._textBoxDealerPoints.Size = new System.Drawing.Size(74, 22);
            this._textBoxDealerPoints.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(138, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(792, 431);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = ".";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 370);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1123, 366);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // bid1
            // 
            this.bid1.Location = new System.Drawing.Point(12, 576);
            this.bid1.Name = "bid1";
            this.bid1.Size = new System.Drawing.Size(42, 43);
            this.bid1.TabIndex = 23;
            this.bid1.UseVisualStyleBackColor = false;
            this.bid1.Visible = false;
            this.bid1.Click += new System.EventHandler(this.bid1_Click);
            // 
            // bid5
            // 
            this.bid5.Location = new System.Drawing.Point(69, 604);
            this.bid5.Name = "bid5";
            this.bid5.Size = new System.Drawing.Size(37, 38);
            this.bid5.TabIndex = 24;
            this.bid5.UseVisualStyleBackColor = true;
            this.bid5.Visible = false;
            this.bid5.Click += new System.EventHandler(this.bid5_Click);
            // 
            // bid10
            // 
            this.bid10.Location = new System.Drawing.Point(112, 631);
            this.bid10.Name = "bid10";
            this.bid10.Size = new System.Drawing.Size(38, 37);
            this.bid10.TabIndex = 25;
            this.bid10.UseVisualStyleBackColor = true;
            this.bid10.Visible = false;
            this.bid10.Click += new System.EventHandler(this.bid10_Click);
            // 
            // bid25
            // 
            this.bid25.Location = new System.Drawing.Point(167, 654);
            this.bid25.Name = "bid25";
            this.bid25.Size = new System.Drawing.Size(38, 39);
            this.bid25.TabIndex = 26;
            this.bid25.UseVisualStyleBackColor = true;
            this.bid25.Visible = false;
            this.bid25.Click += new System.EventHandler(this.bid25_Click);
            // 
            // bid100
            // 
            this.bid100.Location = new System.Drawing.Point(220, 666);
            this.bid100.Name = "bid100";
            this.bid100.Size = new System.Drawing.Size(42, 38);
            this.bid100.TabIndex = 28;
            this.bid100.UseVisualStyleBackColor = true;
            this.bid100.Visible = false;
            this.bid100.Click += new System.EventHandler(this.bid100_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 705);
            this.Controls.Add(this.bid100);
            this.Controls.Add(this.bid25);
            this.Controls.Add(this.bid10);
            this.Controls.Add(this.bid5);
            this.Controls.Add(this.bid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._exitBotton);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _exitBotton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bid1;
        private System.Windows.Forms.Button bid5;
        private System.Windows.Forms.Button bid10;
        private System.Windows.Forms.Button bid25;
        private System.Windows.Forms.Button bid100;
    }
}

