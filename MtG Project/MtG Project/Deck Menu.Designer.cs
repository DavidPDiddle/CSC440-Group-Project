namespace MtG_Project
{
    partial class Deck_Menu
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
            this.viewDeckButton = new System.Windows.Forms.Button();
            this.deckContentsBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitScreenButton = new System.Windows.Forms.Button();
            this.saveAdditionButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.deckListBox = new System.Windows.Forms.ListBox();
            this.notInCollectionButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDeckButton
            // 
            this.viewDeckButton.BackColor = System.Drawing.Color.Silver;
            this.viewDeckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDeckButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewDeckButton.Location = new System.Drawing.Point(472, 469);
            this.viewDeckButton.Name = "viewDeckButton";
            this.viewDeckButton.Size = new System.Drawing.Size(147, 78);
            this.viewDeckButton.TabIndex = 30;
            this.viewDeckButton.Text = "View";
            this.viewDeckButton.UseVisualStyleBackColor = false;
            this.viewDeckButton.Click += new System.EventHandler(this.ViewCollectionButton_Click);
            // 
            // deckContentsBox
            // 
            this.deckContentsBox.FormattingEnabled = true;
            this.deckContentsBox.ItemHeight = 20;
            this.deckContentsBox.Location = new System.Drawing.Point(14, 63);
            this.deckContentsBox.Name = "deckContentsBox";
            this.deckContentsBox.Size = new System.Drawing.Size(456, 384);
            this.deckContentsBox.TabIndex = 21;
            this.deckContentsBox.SelectedIndexChanged += new System.EventHandler(this.deckContentsBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(626, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 80);
            this.button1.TabIndex = 20;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // exitScreenButton
            // 
            this.exitScreenButton.BackColor = System.Drawing.Color.Blue;
            this.exitScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitScreenButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitScreenButton.Location = new System.Drawing.Point(778, 466);
            this.exitScreenButton.Name = "exitScreenButton";
            this.exitScreenButton.Size = new System.Drawing.Size(147, 80);
            this.exitScreenButton.TabIndex = 19;
            this.exitScreenButton.Text = "Exit";
            this.exitScreenButton.UseVisualStyleBackColor = false;
            this.exitScreenButton.Click += new System.EventHandler(this.ExitScreenButton_Click);
            // 
            // saveAdditionButton
            // 
            this.saveAdditionButton.BackColor = System.Drawing.Color.Black;
            this.saveAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAdditionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAdditionButton.Location = new System.Drawing.Point(324, 466);
            this.saveAdditionButton.Name = "saveAdditionButton";
            this.saveAdditionButton.Size = new System.Drawing.Size(147, 80);
            this.saveAdditionButton.TabIndex = 17;
            this.saveAdditionButton.Text = "Save";
            this.saveAdditionButton.UseVisualStyleBackColor = false;
            this.saveAdditionButton.Click += new System.EventHandler(this.SaveAdditionButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.DarkGreen;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addNewButton.Location = new System.Drawing.Point(171, 466);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(147, 80);
            this.addNewButton.TabIndex = 16;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // deckListBox
            // 
            this.deckListBox.FormattingEnabled = true;
            this.deckListBox.ItemHeight = 20;
            this.deckListBox.Location = new System.Drawing.Point(501, 63);
            this.deckListBox.Name = "deckListBox";
            this.deckListBox.Size = new System.Drawing.Size(454, 384);
            this.deckListBox.TabIndex = 31;
            this.deckListBox.SelectedIndexChanged += new System.EventHandler(this.deckListBox_SelectedIndexChanged);
            // 
            // notInCollectionButton
            // 
            this.notInCollectionButton.BackColor = System.Drawing.Color.Red;
            this.notInCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notInCollectionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notInCollectionButton.Location = new System.Drawing.Point(932, 466);
            this.notInCollectionButton.Name = "notInCollectionButton";
            this.notInCollectionButton.Size = new System.Drawing.Size(147, 80);
            this.notInCollectionButton.TabIndex = 33;
            this.notInCollectionButton.Text = "Not In Collection";
            this.notInCollectionButton.UseVisualStyleBackColor = false;
            this.notInCollectionButton.Click += new System.EventHandler(this.fromCollectionButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(992, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "List of Decks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Deck List";
            // 
            // Deck_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.notInCollectionButton);
            this.Controls.Add(this.deckListBox);
            this.Controls.Add(this.viewDeckButton);
            this.Controls.Add(this.deckContentsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitScreenButton);
            this.Controls.Add(this.saveAdditionButton);
            this.Controls.Add(this.addNewButton);
            this.Name = "Deck_Menu";
            this.Text = "Deck Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewDeckButton;
        private System.Windows.Forms.ListBox deckContentsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitScreenButton;
        private System.Windows.Forms.Button saveAdditionButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.ListBox deckListBox;
        private System.Windows.Forms.Button notInCollectionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}