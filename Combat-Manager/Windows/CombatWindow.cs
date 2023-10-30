using System.Collections.Generic;
using System.Windows.Forms;
using Combat_Manager.Models;
using Combat_Manager.Services;

namespace Combat_Manager
{
    public partial class CombatWindow : Form
    {
        private readonly CombatService _combatService;
        
        public CombatWindow(List<Entity> players, List<Entity> npcs)
        {
            InitializeComponent();
            _combatService = new CombatService();
        }
    }
}