﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MtG_Project
{

    public partial class Deck_Menu : Form
    {
        // If the person selects All Cards, then they take from the API. If they select from Collection, then the
        // program will only use the JSON files.
        Boolean allCards;

        object sender;
        EventArgs e;

        public Deck_Menu()
        {
            InitializeComponent();

            // when the deck editor loads, populate the field of decks with deck names


            //String connectionString;
            //SqlConnection cnn;

            //// Data source = name of server, initial catalog = name of database, user id and password are
            //// self-explanatory.
            //connectionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demo123";
            //cnn = new SqlConnection(connectionString);
            //cnn.Open();
            //MessageBox.Show("Connection Open!");
            //// Continue from
            //// https://www.guru99.com/c-sharp-access-database.html

            //// Define variables
            //SqlCommand command;
            //SqlDataReader datareader;
            //String sql, Output = "";

            //// Define the SQL statement
            //sql = "SELECT TutorialID, TutorialName from demotb";

            //// command statement
            //command = new SqlCommand(sql, cnn);

            //// Define the data reader
            //datareader = command.ExecuteReader();

            //// Get results
            //while (datareader.Read())
            //{
            //    Output = Output + datareader.GetValue(0) + " - " + datareader.GetValue(1) + "\n";
            //}

            //MessageBox.Show(Output);

            //datareader.Close();
            //command.Dispose();
            //cnn.Close();

            //// For putting stuff into the table
            //// Reuse SqlCommand command
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //String sql2 = "";
            //sql2 = "INSERT into demotb (TutorialID, TutorialName) values(3,'" + "VB.Net" + "')";

            //command = new SqlCommand(sql2, cnn);
            //adapter.InsertCommand = new SqlCommand(sql2, cnn);
            //adapter.InsertCommand.ExecuteNonQuery();

            //command.Dispose();
            //cnn.Close();
           


        }
        // adds a new deck to the json file
        private void AddNewButton_Click(object sender, EventArgs e)
        {
            // creates a new deck titled 'New Deck' and populates that into the list view
            var json_file = "deck_lists.json";
            // get the existing json data out of that file
            var json_data = System.IO.File.ReadAllText(json_file);
            // deserialize the json object
            var deck_lists = JsonConvert.DeserializeObject(json_data);

        }

        private void ViewCollectionButton_Click(object sender, EventArgs e)
        {
           
        }

        private void SaveAdditionButton_Click(object sender, EventArgs e)
        {
           
        }

       

        private void ExitScreenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allCardsButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fromCollectionButton_Click(object sender, EventArgs e)
        {
           
        }


        private void CardSubtypeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
