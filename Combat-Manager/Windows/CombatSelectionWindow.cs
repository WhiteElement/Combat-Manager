using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Combat_Manager.Models;
using Combat_Manager.Services;

namespace Combat_Manager
{
    public partial class CombatSelectionWindow : Form
    {
        private readonly PlayerService _playerService;
        private readonly NpcService _npcService;

        public CombatSelectionWindow()
        {
            InitializeComponent();
            _playerService = new PlayerService();
            _npcService = new NpcService();
            PopulateCheckedListBoxes();
        }

        private void PopulateCheckedListBoxes()
        {
            var allPlayers = _playerService.LoadPlayersFromFile();
            var allNpcs = _npcService.LoadNpcsFromFile();

            foreach (Player player in allPlayers)
                playerBox.Items.Add(player);

            foreach (NPC npc in allNpcs)
                npcBox.Items.Add(npc);

            playerBox.DisplayMember = "Name";
            npcBox.DisplayMember = "Name";
        }

        private List<NPC> GetAllSelectedNPCsInBox(CheckedListBox box)
        {

            List<NPC> npcs = new List<NPC>();
            
            foreach (var item in box.CheckedItems)
            {
                NPC npc = (NPC) item;
                npcs.Add(npc);
            }

            return npcs;
        }

        private List<Player> GetAllSelectedPlayersInBox(CheckedListBox box)
        {
            List<Player> players = new List<Player>();
            
            foreach (var item in box.CheckedItems)
            {
                Player player = (Player) item;
                players.Add(player);
            }

            return players;
        }
        

        private void buttonStartCombat_Click(object sender, EventArgs e)
        {
            var NPCs = GetAllSelectedNPCsInBox(npcBox);
            var Players = GetAllSelectedPlayersInBox(playerBox);

            new CombatWindow(Players, NPCs).Show();
        }

    }
}