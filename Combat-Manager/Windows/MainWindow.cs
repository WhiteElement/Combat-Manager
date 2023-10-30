using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Combat_Manager.Models;

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