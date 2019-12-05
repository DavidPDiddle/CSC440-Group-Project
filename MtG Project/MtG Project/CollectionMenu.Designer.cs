namespace MtG_Project
{
    partial class CollectionMenu
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
            this.saveAdditionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.collectionListBox = new System.Windows.Forms.ListBox();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.manaCostLabel = new System.Windows.Forms.Label();
            this.manaCostTextBox = new System.Windows.Forms.TextBox();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.cardSubtypeLabel = new System.Windows.Forms.Label();
            this.cardTypeTextBox = new System.Windows.Forms.TextBox();
            this.cardColorTextBox = new System.Windows.Forms.TextBox();
            this.exitScreenButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveAdditionButton
            // 
            this.saveAdditionButton.BackColor = System.Drawing.Color.Black;
            this.saveAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAdditionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAdditionButton.Location = new System.Drawing.Point(318, 209);
            this.saveAdditionButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveAdditionButton.Name = "saveAdditionButton";
            this.saveAdditionButton.Size = new System.Drawing.Size(98, 52);
            this.saveAdditionButton.TabIndex = 1;
            this.saveAdditionButton.Text = "Save";
            this.saveAdditionButton.UseVisualStyleBackColor = false;
            this.saveAdditionButton.Click += new System.EventHandler(this.SaveAdditionButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(521, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // collectionListBox
            // 
            this.collectionListBox.FormattingEnabled = true;
            this.collectionListBox.Location = new System.Drawing.Point(9, 10);
            this.collectionListBox.Margin = new System.Windows.Forms.Padding(2);
            this.collectionListBox.Name = "collectionListBox";
            this.collectionListBox.Size = new System.Drawing.Size(305, 251);
            this.collectionListBox.TabIndex = 6;
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.AutoSize = true;
            this.cardNameLabel.Location = new System.Drawing.Point(331, 10);
            this.cardNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(38, 13);
            this.cardNameLabel.TabIndex = 7;
            this.cardNameLabel.Text = "Name:";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.Location = new System.Drawing.Point(373, 10);
            this.cardNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.cardNameTextBox.TabIndex = 8;
            // 
            // manaCostLabel
            // 
            this.manaCostLabel.AutoSize = true;
            this.manaCostLabel.Location = new System.Drawing.Point(331, 41);
            this.manaCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manaCostLabel.Name = "manaCostLabel";
            this.manaCostLabel.Size = new System.Drawing.Size(61, 13);
            this.manaCostLabel.TabIndex = 9;
            this.manaCostLabel.Text = "Mana Cost:";
            // 
            // manaCostTextBox
            // 
            this.manaCostTextBox.Location = new System.Drawing.Point(404, 41);
            this.manaCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.manaCostTextBox.Name = "manaCostTextBox";
            this.manaCostTextBox.Size = new System.Drawing.Size(76, 20);
            this.manaCostTextBox.TabIndex = 10;
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.Location = new System.Drawing.Point(331, 73);
            this.cardTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.cardTypeLabel.TabIndex = 11;
            this.cardTypeLabel.Text = "Card Type:";
            // 
            // cardSubtypeLabel
            // 
            this.cardSubtypeLabel.AutoSize = true;
            this.cardSubtypeLabel.Location = new System.Drawing.Point(331, 103);
            this.cardSubtypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardSubtypeLabel.Name = "cardSubtypeLabel";
            this.cardSubtypeLabel.Size = new System.Drawing.Size(59, 13);
            this.cardSubtypeLabel.TabIndex = 12;
            this.cardSubtypeLabel.Text = "Card Color:";
            // 
            // cardTypeTextBox
            // 
            this.cardTypeTextBox.Location = new System.Drawing.Point(404, 73);
            this.cardTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardTypeTextBox.Name = "cardTypeTextBox";
            this.cardTypeTextBox.Size = new System.Drawing.Size(76, 20);
            this.cardTypeTextBox.TabIndex = 13;
            // 
            // cardColorTextBox
            // 
            this.cardColorTextBox.Location = new System.Drawing.Point(412, 103);
            this.cardColorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardColorTextBox.Name = "cardColorTextBox";
            this.cardColorTextBox.Size = new System.Drawing.Size(76, 20);
            this.cardColorTextBox.TabIndex = 14;
            // 
            // exitScreenButton
            // 
            this.exitScreenButton.BackColor = System.Drawing.Color.Blue;
            this.exitScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitScreenButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitScreenButton.Location = new System.Drawing.Point(425, 153);
            this.exitScreenButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitScreenButton.Name = "exitScreenButton";
            this.exitScreenButton.Size = new System.Drawing.Size(98, 52);
            this.exitScreenButton.TabIndex = 4;
            this.exitScreenButton.Text = "Exit";
            this.exitScreenButton.UseVisualStyleBackColor = false;
            this.exitScreenButton.Click += new System.EventHandler(this.ExitScreenButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(624, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 248);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CollectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cardColorTextBox);
            this.Controls.Add(this.cardTypeTextBox);
            this.Controls.Add(this.cardSubtypeLabel);
            this.Controls.Add(this.cardTypeLabel);
            this.Controls.Add(this.manaCostTextBox);
            this.Controls.Add(this.manaCostLabel);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.cardNameLabel);
            this.Controls.Add(this.collectionListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitScreenButton);
            this.Controls.Add(this.saveAdditionButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CollectionMenu";
            this.Text = "Collection Menu";
            this.Load += new System.EventHandler(this.CollectionMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveAdditionButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox collectionListBox;
        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label manaCostLabel;
        private System.Windows.Forms.TextBox manaCostTextBox;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label cardSubtypeLabel;
        private System.Windows.Forms.TextBox cardTypeTextBox;
        private System.Windows.Forms.TextBox cardColorTextBox;
        private System.Windows.Forms.Button exitScreenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}