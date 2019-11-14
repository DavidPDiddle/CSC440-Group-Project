namespace MtG_Project
{
    partial class HomePage
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.collectionMenuButton = new System.Windows.Forms.Button();
            this.deckMenuButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(215, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to SNAP KEEP";
            // 
            // collectionMenuButton
            // 
            this.collectionMenuButton.BackColor = System.Drawing.Color.Blue;
            this.collectionMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionMenuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.collectionMenuButton.Location = new System.Drawing.Point(159, 74);
            this.collectionMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.collectionMenuButton.Name = "collectionMenuButton";
            this.collectionMenuButton.Size = new System.Drawing.Size(109, 76);
            this.collectionMenuButton.TabIndex = 1;
            this.collectionMenuButton.Text = "Collection Menu";
            this.collectionMenuButton.UseVisualStyleBackColor = false;
            this.collectionMenuButton.Click += new System.EventHandler(this.collectionMenuButton_Click);
            // 
            // deckMenuButton
            // 
            this.deckMenuButton.BackColor = System.Drawing.Color.Black;
            this.deckMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckMenuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deckMenuButton.Location = new System.Drawing.Point(159, 223);
            this.deckMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.deckMenuButton.Name = "deckMenuButton";
            this.deckMenuButton.Size = new System.Drawing.Size(109, 76);
            this.deckMenuButton.TabIndex = 2;
            this.deckMenuButton.Text = "Deck Menu";
            this.deckMenuButton.UseVisualStyleBackColor = false;
            this.deckMenuButton.Click += new System.EventHandler(this.deckMenuButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MtG_Project.Properties.Resources._220px_Magic_the_gathering_card_back;
            this.pictureBox1.Location = new System.Drawing.Point(363, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deckMenuButton);
            this.Controls.Add(this.collectionMenuButton);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button collectionMenuButton;
        private System.Windows.Forms.Button deckMenuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

