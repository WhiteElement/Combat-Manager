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
                // playerBox.Items.Add($"{player.Name}: Ini {player.Initiative}");
                playerBox.Items.Add(player);

            foreach (NPC npc in allNpcs)
                // npcBox.Items.Add($"{npc.Name}: Ini {npc.Initiative}");
                npcBox.Items.Add(npc);

            playerBox.DisplayMember = "Name";
            npcBox.DisplayMember = "Name";
        }

        private List<Entity> GetAllSelectedInBox(CheckedListBox box)
        {
            List<Entity> entities = new List<Entity>();
            
            if (box == npcBox)
            {
                foreach (var item in box.CheckedItems)
                {
                    NPC npc = (NPC) item;
                    entities.Add(npc);
                }
            }
            else if (box == playerBox)
            {
                foreach (var item in box.CheckedItems)
                {
                    Player player = (Player) item;
                    entities.Add(player);
                }
            }

            return entities;
        }

        private void buttonStartCombat_Click(object sender, EventArgs e)
        {
            var NPCs = GetAllSelectedInBox(npcBox);
            var Players = GetAllSelectedInBox(playerBox);

            new CombatWindow(Players, NPCs).Show();
        }
    }
}