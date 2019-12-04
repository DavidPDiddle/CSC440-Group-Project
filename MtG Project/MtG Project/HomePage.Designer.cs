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
            this.playTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(46, 7);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(510, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to the UNNAMED MAGIC THE GATHERING APP";
            // 
            // collectionMenuButton
            // 
            this.collectionMenuButton.BackColor = System.Drawing.Color.Blue;
            this.collectionMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionMenuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.collectionMenuButton.Location = new System.Drawing.Point(50, 116);
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
            this.deckMenuButton.BackColor = System.Drawing.Color.Red;
            this.deckMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckMenuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deckMenuButton.Location = new System.Drawing.Point(180, 116);
            this.deckMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.deckMenuButton.Name = "deckMenuButton";
            this.deckMenuButton.Size = new System.Drawing.Size(109, 76);
            this.deckMenuButton.TabIndex = 2;
            this.deckMenuButton.Text = "Deck Menu";
            this.deckMenuButton.UseVisualStyleBackColor = false;
            this.deckMenuButton.Click += new System.EventHandler(this.deckMenuButton_Click);
            // 
            // playTestButton
            // 
            this.playTestButton.BackColor = System.Drawing.Color.DarkGreen;
            this.playTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playTestButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playTestButton.Location = new System.Drawing.Point(300, 116);
            this.playTestButton.Margin = new System.Windows.Forms.Padding(2);
            this.playTestButton.Name = "playTestButton";
            this.playTestButton.Size = new System.Drawing.Size(109, 76);
            this.playTestButton.TabIndex = 3;
            this.playTestButton.Text = "Playtest";
            this.playTestButton.UseVisualStyleBackColor = false;
            this.playTestButton.Click += new System.EventHandler(this.playTestButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.playTestButton);
            this.Controls.Add(this.deckMenuButton);
            this.Controls.Add(this.collectionMenuButton);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button collectionMenuButton;
        private System.Windows.Forms.Button deckMenuButton;
        private System.Windows.Forms.Button playTestButton;
    }
}

