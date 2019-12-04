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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.titleLabel = new System.Windows.Forms.Label();
            this.collectionMenuButton = new MtG_Project.RoundedButtons();
            this.deckMenuButton = new MtG_Project.RoundedButtons();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeWindowButton = new MtG_Project.RoundedButtons();
            this.maximizeButton = new MtG_Project.RoundedButtons();
            this.minimizeButton = new MtG_Project.RoundedButtons();
            this.updateButton = new MtG_Project.RoundedButtons();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(188, 109);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(230, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to SnapKeep!";
            // 
            // collectionMenuButton
            // 
            this.collectionMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.collectionMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionMenuButton.ForeColor = System.Drawing.Color.White;
            this.collectionMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("collectionMenuButton.Image")));
            this.collectionMenuButton.Location = new System.Drawing.Point(150, 179);
            this.collectionMenuButton.Name = "collectionMenuButton";
            this.collectionMenuButton.Size = new System.Drawing.Size(100, 97);
            this.collectionMenuButton.TabIndex = 1;
            this.collectionMenuButton.Text = "Deck Menu";
            this.collectionMenuButton.UseVisualStyleBackColor = true;
            this.collectionMenuButton.Click += new System.EventHandler(this.CollectionMenuButton_Click);
            // 
            // deckMenuButton
            // 
            this.deckMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deckMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckMenuButton.ForeColor = System.Drawing.Color.White;
            this.deckMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("deckMenuButton.Image")));
            this.deckMenuButton.Location = new System.Drawing.Point(256, 173);
            this.deckMenuButton.Name = "deckMenuButton";
            this.deckMenuButton.Size = new System.Drawing.Size(103, 103);
            this.deckMenuButton.TabIndex = 2;
            this.deckMenuButton.Text = "Collection Menu";
            this.deckMenuButton.UseVisualStyleBackColor = true;
            this.deckMenuButton.Click += new System.EventHandler(this.DeckMenuButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeWindowButton);
            this.panel1.Controls.Add(this.maximizeButton);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 57);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindowButton.ForeColor = System.Drawing.Color.White;
            this.closeWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("closeWindowButton.Image")));
            this.closeWindowButton.Location = new System.Drawing.Point(539, 9);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(49, 45);
            this.closeWindowButton.TabIndex = 2;
            this.closeWindowButton.Text = "X";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton.ForeColor = System.Drawing.Color.White;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(486, 9);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(47, 45);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.Text = "max";
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Aqua;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(409, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(56, 48);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.Text = "min";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(365, 173);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 103);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Card Bank";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deckMenuButton);
            this.Controls.Add(this.collectionMenuButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private RoundedButtons collectionMenuButton;
        private RoundedButtons deckMenuButton;
        private System.Windows.Forms.Panel panel1;
        private RoundedButtons closeWindowButton;
        private RoundedButtons maximizeButton;
        private RoundedButtons minimizeButton;
        private RoundedButtons updateButton;
    }
}

