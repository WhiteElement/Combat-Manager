using System.Windows.Forms;
using Combat_Manager.Models;
using Combat_Manager.Services;

namespace Combat_Manager
{
    public partial class CombatSelectionWindow : Form
    {
        private readonly PlayerService _playerService;
        public CombatSelectionWindow()
        {
            InitializeComponent();
            _playerService = new PlayerService();
            PopulateCheckedListBoxes();
        }

        private void PopulateCheckedListBoxes()
        {
            var allPlayers = _playerService.LoadPlayersFromFile();
            foreach (Player player in allPlayers)
                playerBox.Items.Add(player.Name);
        }
    }
}