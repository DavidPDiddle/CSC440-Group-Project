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
            this.cardSubtypeTextBox = new System.Windows.Forms.TextBox();
            this.cardTypeTextBox = new System.Windows.Forms.TextBox();
            this.cardSubtypeLabel = new System.Windows.Forms.Label();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.manaCostTextBox = new System.Windows.Forms.TextBox();
            this.manaCostLabel = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.deckContentsBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitScreenButton = new System.Windows.Forms.Button();
            this.cancelAdditionButton = new System.Windows.Forms.Button();
            this.saveAdditionButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.deckListBox = new System.Windows.Forms.ListBox();
            this.allCardsButton = new System.Windows.Forms.Button();
            this.fromCollectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewDeckButton
            // 
            this.viewDeckButton.BackColor = System.Drawing.Color.Silver;
            this.viewDeckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDeckButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewDeckButton.Location = new System.Drawing.Point(111, 305);
            this.viewDeckButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewDeckButton.Name = "viewDeckButton";
            this.viewDeckButton.Size = new System.Drawing.Size(98, 51);
            this.viewDeckButton.TabIndex = 30;
            this.viewDeckButton.Text = "View";
            this.viewDeckButton.UseVisualStyleBackColor = false;
            this.viewDeckButton.Click += new System.EventHandler(this.ViewCollectionButton_Click);
            // 
            // cardSubtypeTextBox
            // 
            this.cardSubtypeTextBox.Location = new System.Drawing.Point(404, 103);
            this.cardSubtypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardSubtypeTextBox.Name = "cardSubtypeTextBox";
            this.cardSubtypeTextBox.Size = new System.Drawing.Size(76, 20);
            this.cardSubtypeTextBox.TabIndex = 29;
            this.cardSubtypeTextBox.Visible = false;
            // 
            // cardTypeTextBox
            // 
            this.cardTypeTextBox.Location = new System.Drawing.Point(404, 73);
            this.cardTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardTypeTextBox.Name = "cardTypeTextBox";
            this.cardTypeTextBox.Size = new System.Drawing.Size(76, 20);
            this.cardTypeTextBox.TabIndex = 28;
            this.cardTypeTextBox.Visible = false;
            // 
            // cardSubtypeLabel
            // 
            this.cardSubtypeLabel.AutoSize = true;
            this.cardSubtypeLabel.Location = new System.Drawing.Point(331, 103);
            this.cardSubtypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardSubtypeLabel.Name = "cardSubtypeLabel";
            this.cardSubtypeLabel.Size = new System.Drawing.Size(77, 13);
            this.cardSubtypeLabel.TabIndex = 27;
            this.cardSubtypeLabel.Text = "Card Subtype: ";
            this.cardSubtypeLabel.Visible = false;
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.Location = new System.Drawing.Point(331, 73);
            this.cardTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.cardTypeLabel.TabIndex = 26;
            this.cardTypeLabel.Text = "Card Type:";
            this.cardTypeLabel.Visible = false;
            // 
            // manaCostTextBox
            // 
            this.manaCostTextBox.Location = new System.Drawing.Point(404, 41);
            this.manaCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.manaCostTextBox.Name = "manaCostTextBox";
            this.manaCostTextBox.Size = new System.Drawing.Size(76, 20);
            this.manaCostTextBox.TabIndex = 25;
            this.manaCostTextBox.Visible = false;
            // 
            // manaCostLabel
            // 
            this.manaCostLabel.AutoSize = true;
            this.manaCostLabel.Location = new System.Drawing.Point(331, 41);
            this.manaCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manaCostLabel.Name = "manaCostLabel";
            this.manaCostLabel.Size = new System.Drawing.Size(61, 13);
            this.manaCostLabel.TabIndex = 24;
            this.manaCostLabel.Text = "Mana Cost:";
            this.manaCostLabel.Visible = false;
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.Location = new System.Drawing.Point(373, 10);
            this.cardNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.cardNameTextBox.TabIndex = 23;
            this.cardNameTextBox.Visible = false;
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.AutoSize = true;
            this.cardNameLabel.Location = new System.Drawing.Point(331, 10);
            this.cardNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(38, 13);
            this.cardNameLabel.TabIndex = 22;
            this.cardNameLabel.Text = "Name:";
            this.cardNameLabel.Visible = false;
            // 
            // deckContentsBox
            // 
            this.deckContentsBox.FormattingEnabled = true;
            this.deckContentsBox.Location = new System.Drawing.Point(9, 10);
            this.deckContentsBox.Margin = new System.Windows.Forms.Padding(2);
            this.deckContentsBox.Name = "deckContentsBox";
            this.deckContentsBox.Size = new System.Drawing.Size(305, 251);
            this.deckContentsBox.TabIndex = 21;
            this.deckContentsBox.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(214, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // exitScreenButton
            // 
            this.exitScreenButton.BackColor = System.Drawing.Color.Blue;
            this.exitScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitScreenButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitScreenButton.Location = new System.Drawing.Point(420, 304);
            this.exitScreenButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitScreenButton.Name = "exitScreenButton";
            this.exitScreenButton.Size = new System.Drawing.Size(98, 52);
            this.exitScreenButton.TabIndex = 19;
            this.exitScreenButton.Text = "Exit";
            this.exitScreenButton.UseVisualStyleBackColor = false;
            this.exitScreenButton.Click += new System.EventHandler(this.ExitScreenButton_Click);
            // 
            // cancelAdditionButton
            // 
            this.cancelAdditionButton.BackColor = System.Drawing.Color.White;
            this.cancelAdditionButton.Enabled = false;
            this.cancelAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAdditionButton.Location = new System.Drawing.Point(317, 304);
            this.cancelAdditionButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelAdditionButton.Name = "cancelAdditionButton";
            this.cancelAdditionButton.Size = new System.Drawing.Size(98, 52);
            this.cancelAdditionButton.TabIndex = 18;
            this.cancelAdditionButton.Text = "Cancel";
            this.cancelAdditionButton.UseVisualStyleBackColor = false;
            this.cancelAdditionButton.Click += new System.EventHandler(this.CancelAdditionButton_Click);
            // 
            // saveAdditionButton
            // 
            this.saveAdditionButton.BackColor = System.Drawing.Color.Black;
            this.saveAdditionButton.Enabled = false;
            this.saveAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAdditionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAdditionButton.Location = new System.Drawing.Point(112, 304);
            this.saveAdditionButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveAdditionButton.Name = "saveAdditionButton";
            this.saveAdditionButton.Size = new System.Drawing.Size(98, 52);
            this.saveAdditionButton.TabIndex = 17;
            this.saveAdditionButton.Text = "Save";
            this.saveAdditionButton.UseVisualStyleBackColor = false;
            this.saveAdditionButton.Visible = false;
            this.saveAdditionButton.Click += new System.EventHandler(this.SaveAdditionButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.DarkGreen;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addNewButton.Location = new System.Drawing.Point(9, 304);
            this.addNewButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(98, 52);
            this.addNewButton.TabIndex = 16;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // deckListBox
            // 
            this.deckListBox.FormattingEnabled = true;
            this.deckListBox.Location = new System.Drawing.Point(9, 41);
            this.deckListBox.Margin = new System.Windows.Forms.Padding(2);
            this.deckListBox.Name = "deckListBox";
            this.deckListBox.Size = new System.Drawing.Size(304, 121);
            this.deckListBox.TabIndex = 31;
            this.deckListBox.SelectedIndexChanged += new System.EventHandler(this.deckListBox_SelectedIndexChanged);
            // 
            // allCardsButton
            // 
            this.allCardsButton.BackColor = System.Drawing.Color.Blue;
            this.allCardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCardsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.allCardsButton.Location = new System.Drawing.Point(140, 166);
            this.allCardsButton.Margin = new System.Windows.Forms.Padding(2);
            this.allCardsButton.Name = "allCardsButton";
            this.allCardsButton.Size = new System.Drawing.Size(98, 52);
            this.allCardsButton.TabIndex = 32;
            this.allCardsButton.Text = "All Cards";
            this.allCardsButton.UseVisualStyleBackColor = false;
            this.allCardsButton.Click += new System.EventHandler(this.allCardsButton_Click);
            // 
            // fromCollectionButton
            // 
            this.fromCollectionButton.BackColor = System.Drawing.Color.Red;
            this.fromCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCollectionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fromCollectionButton.Location = new System.Drawing.Point(334, 166);
            this.fromCollectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.fromCollectionButton.Name = "fromCollectionButton";
            this.fromCollectionButton.Size = new System.Drawing.Size(98, 52);
            this.fromCollectionButton.TabIndex = 33;
            this.fromCollectionButton.Text = "From Collection";
            this.fromCollectionButton.UseVisualStyleBackColor = false;
            this.fromCollectionButton.Click += new System.EventHandler(this.fromCollectionButton_Click);
            // 
            // Deck_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.fromCollectionButton);
            this.Controls.Add(this.allCardsButton);
            this.Controls.Add(this.deckListBox);
            this.Controls.Add(this.viewDeckButton);
            this.Controls.Add(this.cardSubtypeTextBox);
            this.Controls.Add(this.cardTypeTextBox);
            this.Controls.Add(this.cardSubtypeLabel);
            this.Controls.Add(this.cardTypeLabel);
            this.Controls.Add(this.manaCostTextBox);
            this.Controls.Add(this.manaCostLabel);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.cardNameLabel);
            this.Controls.Add(this.deckContentsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitScreenButton);
            this.Controls.Add(this.cancelAdditionButton);
            this.Controls.Add(this.saveAdditionButton);
            this.Controls.Add(this.addNewButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Deck_Menu";
            this.Text = "Deck Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewDeckButton;
        private System.Windows.Forms.TextBox cardSubtypeTextBox;
        private System.Windows.Forms.TextBox cardTypeTextBox;
        private System.Windows.Forms.Label cardSubtypeLabel;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.TextBox manaCostTextBox;
        private System.Windows.Forms.Label manaCostLabel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.ListBox deckContentsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitScreenButton;
        private System.Windows.Forms.Button cancelAdditionButton;
        private System.Windows.Forms.Button saveAdditionButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.ListBox deckListBox;
        private System.Windows.Forms.Button allCardsButton;
        private System.Windows.Forms.Button fromCollectionButton;
    }
}