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

        private void button1_Click(object sender, EventArgs e)
        {
            // MAINLOOP
            bool shouldRun = true;
            int globalInitiative = 0;
            
            
            //TODO NPCs
            List<Player> entities = new List<Player>();
            entities.Add(new Player()
            {
                Name = "p1",
                Initiative = 8,
                Parry = 4
            });
            entities.Add(new Player()
            {
                Name = "p2",
                Initiative = 6,
                Parry = 4
            });
            
            while (shouldRun)
            {
                
                foreach (Entity entity in entities)
                {
                    if (IsTurn(entity, globalInitiative))
                    {
                        var turnMessageBox = new TurnMessageBox($"{entity.Name.ToUpper()}", 
                            $"[Initiative: {globalInitiative}] {entity.Name.ToUpper()} ist am Zug");
                        turnMessageBox.StartPosition = FormStartPosition.CenterParent;
                        turnMessageBox.ShowDialog();
                        if (turnMessageBox.ShouldAbort())
                            return;
                    }   
                }

                globalInitiative++;
            }
            
            
        }

        private bool IsTurn(Entity entity, int globalInitiative)
        {
            if (entity.Initiative < globalInitiative)
            {
                if (globalInitiative % entity.Initiative == 0)
                    return true;
                return false;
            }
            else
            {
                if (entity.Initiative == globalInitiative)
                    return true;
            }

            return false;
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