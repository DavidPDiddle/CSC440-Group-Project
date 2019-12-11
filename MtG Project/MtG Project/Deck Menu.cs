using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            LoadDecks(sender, e);

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
        // runs an external python script and gets the stdout as a result string
        public List<string> Run_Cmd(string cmd)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Python/python.exe";
            start.Arguments = string.Format("\"{0}\"", cmd);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            List<string> deck_names = new List<string>();

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd();
                    string result = reader.ReadToEnd();
                    deck_names.Add(result);
                }
            }

            return deck_names;
        }
        // load the list of decks when the page is loaded
        public void LoadDecks(object sender, EventArgs e)
        {
            deckListBox.DataSource = Run_Cmd("C:/Users/15022/Documents/CSC440/read_decks.py");
        }

        // adds a new deck to the json file
        private void AddNewButton_Click(object sender, EventArgs e)
        {

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
