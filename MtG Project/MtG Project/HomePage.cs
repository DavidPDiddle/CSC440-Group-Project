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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void collectionMenuButton_Click(object sender, EventArgs e)
        {
            new CollectionMenu().Show();
        }

        private void deckMenuButton_Click(object sender, EventArgs e)
        {
            new Deck_Menu().Show();
        }

        private void playTestButton_Click(object sender, EventArgs e)
        {
            new Playtest().Show();
        }
    }
}
