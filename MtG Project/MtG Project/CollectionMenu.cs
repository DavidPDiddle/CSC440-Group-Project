using System;
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
    public partial class CollectionMenu : Form
    {
        public CollectionMenu()
        {
            InitializeComponent();
            LoadCollection();

        }

        private void LoadCollection()
        {
            collectionListBox.DataSource = Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/get_collection_contents.py");

        }

        public void LoadImg(string card_name)
        {
            // write the card name to a file so the python script can read it
            System.IO.File.WriteAllText("C:/Users/15022/Documents/CSC440/card_name.txt", collectionListBox.SelectedItem.ToString());
            // run a python file to return the uri
            string card_uri = "";
            try
            {
                card_uri = Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/get_card_uri.py")[0];
            }
            catch (ArgumentOutOfRangeException e)
            {
                card_uri = "";
            }
            // load the image
            if (card_uri.Equals(""))
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
            else
            {
                pictureBox1.Load(card_uri);
            }
        }


        private void SaveAdditionButton_Click(object sender, EventArgs e)
        {
            // stuff about saving stuff to the database

           
        }

        

        private void ExitScreenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void CollectionMenu_Load(object sender, EventArgs e)
        {

        }

        private void collectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImg(collectionListBox.SelectedItem.ToString());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Edit_Collection().Show();
            Close();
        }
    }
}
