using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Combat_Manager.Helper;
using Combat_Manager.Models;
using Combat_Manager.Services;
using Newtonsoft.Json;

namespace Combat_Manager
{
    public partial class PlayersWindow : Form
    {
        private readonly PlayerService _playerService; 
        
        public PlayersWindow()
        {
            _playerService = new PlayerService();
            InitializeComponent();
            FormHelper.PopulateTreeView(treeView1,_playerService.LoadPlayersFromFile(),true);
        }

        private void newNpcButton_Click(object sender, EventArgs e)
        {
            Player newPlayer;
            try
            {
                newPlayer = new Player()
                {
                    Name = nameBox.Text,
                    Initiative = Int32.Parse(initiativeBox.Text),
                };
            }
            catch
            {
                FormHelper.MustFieldNotEntered();
                return;
            }
            
            var players = _playerService.LoadPlayersFromFile();
            players.Add(newPlayer);
            
            string json = JsonConvert.SerializeObject(players);

            _playerService.WritePlayersToFile(json);
            
            FormHelper.PopulateTreeView(treeView1, players, true);
        }
        
    }
}