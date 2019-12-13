using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace MtG_Project
{
    public partial class HomePage : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        public HomePage()
        {
            InitializeComponent();
        }

        private void CollectionMenuButton_Click(object sender, EventArgs e)
        {
            new CollectionMenu().Show();
        }

        private void DeckMenuButton_Click(object sender, EventArgs e)
        {
            new Deck_Menu().Show();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);

        }

        private void HomePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }


        }
        // gets the latest updates from Scryfall's website
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://archive.scryfall.com/json/scryfall-oracle-cards.json",
                @"C:/Users/15022/Documents/CSC440/scryfall-oracle-cards.json");
            Deck_Menu.Run_Cmd("C:/Users/15022/Documents/CSC440/Json_Processing.py");
        }

        private void HomePage_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;

        }

    }
}