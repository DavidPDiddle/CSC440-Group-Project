namespace MtG_Project
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_deck_contents = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_deck_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Red;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(24, 670);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(147, 79);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(379, 670);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(147, 79);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cards:";
            // 
            // rtb_deck_contents
            // 
            this.rtb_deck_contents.Location = new System.Drawing.Point(24, 89);
            this.rtb_deck_contents.Name = "rtb_deck_contents";
            this.rtb_deck_contents.Size = new System.Drawing.Size(381, 505);
            this.rtb_deck_contents.TabIndex = 25;
            this.rtb_deck_contents.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Deck Name:";
            // 
            // tb_deck_name
            // 
            this.tb_deck_name.Location = new System.Drawing.Point(124, 15);
            this.tb_deck_name.Name = "tb_deck_name";
            this.tb_deck_name.Size = new System.Drawing.Size(281, 26);
            this.tb_deck_name.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 790);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_deck_contents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_deck_name);
            this.Name = "Form1";
            this.Text = "New Deck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_deck_contents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_deck_name;
    }
}