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

        object sender;
        EventArgs e;

        public Deck_Menu()
        {
            InitializeComponent();
            LoadDecks(sender, e);
        }
        // runs an external python script and gets the stdout as a result array of strings
        public static List<string> Run_Cmd(string cmd)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Python/python.exe";
            start.Arguments = string.Format("\"{0}\"", cmd);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardInput = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            List<string> deck_names = new List<string>();

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd();
                    string result = reader.ReadToEnd();
                    using (StringReader stringReader = new StringReader(result))
                    {
                        string line;
                        while ((line = stringReader.ReadLine()) != null)
                        {
                            deck_names.Add(line);
                        }
                    }
                }
            }

            return deck_names;
        }
        // load the image from the Scryfall uri
        public void LoadImg(string card_name)
        {
            // write the card name to a file so the python script can read it
            System.IO.File.WriteAllText("C:/Users/15022/Documents/CSC440/card_name.txt", deckContentsBox.SelectedItem.ToString());
            // run a python file to return the uri
            string card_uri = Run_Cmd("C:/Users/15022/Documents/CSC440/get_card_uri.py")[0];
            // load the image
            pictureBox1.Load(card_uri);
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

        private void ExitScreenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // write the deck name to a file so that the python file can read it
            System.IO.File.WriteAllText("C:/Users/15022/Documents/CSC440/deck_name.txt", deckListBox.SelectedItem.ToString());
            deckContentsBox.DataSource = Run_Cmd("C:/Users/15022/Documents/CSC440/get_deck_contents.py");
        }

        private void deckContentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImg(deckContentsBox.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            new Edit_Deck().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
