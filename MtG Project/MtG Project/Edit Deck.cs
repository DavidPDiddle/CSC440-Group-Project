using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static MtG_Project.Deck_Menu;

namespace MtG_Project
{
    public partial class Edit_Deck : Form
    {
        public Edit_Deck()
        {
            InitializeComponent();
            LoadFields();
        }

        private void LoadFields()
        {
            List<string> contents = Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/get_deck_contents.py");
            for (int i = 0; i < contents.Count; i++)
            {
                if (i < contents.Count - 1)
                {
                    rtb_deck_contents.AppendText(contents[i] + "\n");
                }
                else
                {
                    rtb_deck_contents.AppendText(contents[i]);
                }
            }
            tb_deck_name.Text = System.IO.File.ReadAllText("C:/Users/15022/Documents/CSC440/deck_name.txt");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:/Users/15022/Documents/CSC440/deck_contents.txt", rtb_deck_contents.Text);
            File.WriteAllText("C:/Users/15022/Documents/CSC440/new_deck_name.txt", tb_deck_name.Text);
            Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/edit_deck.py");
            new Deck_Menu().Show();
            Close();
        }

        private void Edit_Deck_Load(object sender, EventArgs e)
        {

        }

        private void rtb_deck_contents_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
