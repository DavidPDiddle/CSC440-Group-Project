using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtG_Project
{
    public partial class Edit_Collection : Form
    {
        public Edit_Collection()
        {
            InitializeComponent();
            LoadContents();
        }

        private void LoadContents()
        {
            List<string> contents = Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/get_collection_contents.py");
            for (int i = 0; i < contents.Count; i++)
            {
                if (i < contents.Count - 1)
                {
                    rtb_collection_contents.AppendText(contents[i] + "\n");
                }
                else
                {
                    rtb_collection_contents.AppendText(contents[i]);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:/Users/15022/Documents/CSC440/collection_contents.txt", rtb_collection_contents.Text);
            Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/update_collection.py");
            new CollectionMenu().Show();
            Close();
        }
    }
}
