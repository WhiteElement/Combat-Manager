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

        public void RunMainLoop()
        {
            
        }

        // // MAINLOOP
        // bool shouldRun = true;
        // int globalInitiative = 0;
        //     
        //     
        // //TODO NPCs
        // List<Player> entities = new List<Player>();
        // entities.Add(new Player()
        // {
        //     Name = "p1",
        //     Initiative = 8,
        //     Parry = 4
        // });
        // entities.Add(new Player()
        // {
        //     Name = "p2",
        //     Initiative = 6,
        //     Parry = 4
        // });
        //     
        // while (shouldRun)
        // {
        //         
        //     foreach (Entity entity in entities)
        //     {
        //         if (IsTurn(entity, globalInitiative))
        //         {
        //             var turnMessageBox = new TurnMessageBox($"{entity.Name.ToUpper()}", 
        //                 $"[Initiative: {globalInitiative}] {entity.Name.ToUpper()} ist am Zug");
        //             turnMessageBox.StartPosition = FormStartPosition.CenterParent;
        //             turnMessageBox.ShowDialog();
        //             if (turnMessageBox.ShouldAbort())
        //                 return;
        //         }   
        //     }
        //
        //     globalInitiative++;
        // }

        // private bool IsTurn(Entity entity, int globalInitiative)
        // {
        //     if (entity.Initiative < globalInitiative)
        //     {
        //         if (globalInitiative % entity.Initiative == 0)
        //             return true;
        //         return false;
        //     }
        //     else
        //     {
        //         if (entity.Initiative == globalInitiative)
        //             return true;
        //     }
        //
        //     return false;
        // }
    }
}