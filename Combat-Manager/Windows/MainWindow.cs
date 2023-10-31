using System;
using System.Windows.Forms;

namespace Combat_Manager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCombatSelection_Click(object sender, EventArgs e)
        {
            new CombatSelectionWindow().Show();
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            new PlayersWindow().Show();
            
        }

        private void buttonNpc_Click(object sender, EventArgs e)
        {
            new NpcsWindow().Show();
        }
    }
}