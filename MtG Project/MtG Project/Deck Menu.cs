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
    public partial class Deck_Menu : Form
    {
        public Deck_Menu()
        {
            InitializeComponent();

            deckContentsBox.Text += "Grobby     5RR     Creature       Goblin       4/5";
            deckListBox.Text += "Eggs Sunnyside Up";
            deckListBox.Text += "Cawblade";
            deckListBox.Text += "Jund Midrange";
            deckListBox.Text += "5-Color Planeswalkers";
            deckListBox.Text += "Jeskai Group Hug";

            viewDeckButton.Visible = false;
            addNewButton.Visible = false;
            saveAdditionButton.Visible = false;
            cancelAdditionButton.Visible = false;
            exitScreenButton.Visible = false;
            allCardsButton.Visible = true;
            fromCollectionButton.Visible = true;

            deckListBox.Visible = false;
            deckContentsBox.Visible = false;
            cardNameLabel.Visible = false;
            cardNameTextBox.Visible = false;
            cardTypeLabel.Visible = false;
            cardTypeTextBox.Visible = false;
            cardSubtypeLabel.Visible = false;
            cardSubtypeTextBox.Visible = false;

        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            viewDeckButton.Visible = false;
            addNewButton.Visible = false;
            deckListBox.Visible = false;
            saveAdditionButton.Visible = true;
            deckContentsBox.Visible = true;
            cancelAdditionButton.Visible = true;
            cardNameLabel.Visible = true;
            cardNameTextBox.Visible = true;
            cardTypeLabel.Visible = true;
            cardTypeTextBox.Visible = true;
            cardSubtypeLabel.Visible = true;
            cardSubtypeTextBox.Visible = true;
        }

        private void ViewCollectionButton_Click(object sender, EventArgs e)
        {
            viewDeckButton.Visible = false;
            addNewButton.Visible = false;
            deckListBox.Visible = false;
            saveAdditionButton.Visible = true;
            deckContentsBox.Visible = true;
            cancelAdditionButton.Visible = true;
            cardNameLabel.Visible = true;
            cardNameTextBox.Visible = true;
            cardTypeLabel.Visible = true;
            cardTypeTextBox.Visible = true;
            cardSubtypeLabel.Visible = true;
            cardSubtypeTextBox.Visible = true;
        }

        private void SaveAdditionButton_Click(object sender, EventArgs e)
        {
            // stuff about saving stuff to the database

            saveAdditionButton.Visible = false;
            deckContentsBox.Visible = false;
            cancelAdditionButton.Visible = false;
            cardNameLabel.Visible = false;
            cardNameTextBox.Visible = false;
            cardTypeLabel.Visible = false;
            cardTypeTextBox.Visible = false;
            cardSubtypeLabel.Visible = false;
            cardSubtypeTextBox.Visible = false;

            viewDeckButton.Visible = true;
            addNewButton.Visible = true;
            deckListBox.Visible = true;
        }

        private void ExitScreenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fromCollectionButton_Click(object sender, EventArgs e)
        {
            viewDeckButton.Visible = true;
            addNewButton.Visible = true;
            saveAdditionButton.Visible = false;
            cancelAdditionButton.Visible = true;
            exitScreenButton.Visible = true;
            fromCollectionButton.Visible = false;
        }

        private void CancelAdditionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
