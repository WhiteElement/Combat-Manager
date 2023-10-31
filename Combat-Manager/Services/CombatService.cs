using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Combat_Manager.Models;

namespace Combat_Manager.Services
{
    public class CombatService
    {
        private readonly PlayerService _playerService;
        private readonly NpcService _npcService;

        public CombatService()
        {
            _playerService = new PlayerService();
            _npcService = new NpcService();
        }
        

        public bool IsTurn(Entity entity, int globalInitiative)
        {
            if (entity.Initiative < globalInitiative)
            {
                if (globalInitiative % entity.Initiative == 0)
                    return true;
            }
            else
            {
                if (entity.Initiative == globalInitiative)
                    return true;
            }
        
            return false;
        }
    }
}