using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtG_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:/Users/15022/Documents/CSC440/deck_contents.txt", rtb_deck_contents.Text);
            File.WriteAllText("C:/Users/15022/Documents/CSC440/new_deck_name.txt", tb_deck_name.Text);
            Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/new_deck.py");
            new Deck_Menu().Show();
            Close();
        }
    }
}
