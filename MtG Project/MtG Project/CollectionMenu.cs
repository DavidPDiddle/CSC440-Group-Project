﻿using System;
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
            collectionListBox.Text += "Grobby     5RR     Creature       Goblin       4/5";
            collectionListBox.Text += "";
            collectionListBox.Text += "Jace Beleren     2UU     Planeswalker        Jace Beleren        4";

        }

        

        private void SaveAdditionButton_Click(object sender, EventArgs e)
        {
            // stuff about saving stuff to the database

            saveAdditionButton.Visible = false;
            collectionListBox.Visible = false;
            cardNameLabel.Visible = false;
            cardNameTextBox.Visible = false;
            cardTypeLabel.Visible = false;
            cardTypeTextBox.Visible = false;
            cardSubtypeLabel.Visible = false;
            cardSubtypeTextBox.Visible = false;
            manaCostLabel.Visible = false;
            manaCostTextBox.Visible = false;

        }

        

        private void ExitScreenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void CollectionMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
