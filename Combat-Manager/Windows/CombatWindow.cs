using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Combat_Manager.Helper;
using Combat_Manager.Models;

namespace Combat_Manager
{
    public partial class CombatWindow : Form
    {
        private List<Entity> _players;
        private List<Entity> _npcs;
        private int _globalInitiative = 0;
        private List<Entity> _hadHisTurn = new List<Entity>();
        
        public CombatWindow(List<Entity> players, List<Entity> npcs)
        {

            InitializeComponent();
            _players = players;
            _npcs = npcs;
        }
        
        private void RunMainLoop(List<Entity> entities)
        {
            while (true)
            {
                Thread.Sleep(50);
                listBox1.Items.Add($"Initiative: {_globalInitiative}");
                listBox1.Refresh();
                listBox1.TopIndex = listBox1.Items.Count - 1;
                    
                foreach (Entity entity in entities)
                {
                    if (IsHisTurn(entity)
                        && !_hadHisTurn.Contains(entity))
                    {
                        Thread.Sleep(50);
                        listBox1.Items.Add($"\t{entity.Name}(Ini: {entity.Initiative}) ist am Zug");
                        listBox1.Refresh();
                        listBox1.TopIndex = listBox1.Items.Count - 1;
                        
                        _hadHisTurn.Add(entity);
                        return;

                    }   
                }
                _hadHisTurn.Clear();
                _globalInitiative++;
            }
        }

        private void CombatWindow_Shown(object sender, EventArgs e)
        {
            FormHelper.PopulateTreeView(treeViewPlayer, _players, true);
            FormHelper.PopulateTreeView(treeViewNpcs, _npcs, true);
        }

        private void buttonStartContinueCombat_Click(object sender, EventArgs e)
        {
            buttonStartContinueCombat.Visible = false;
            List<Entity> entities = new List<Entity>(_players);
            entities.AddRange(_npcs);
            
            RunMainLoop(entities);
            buttonStartContinueCombat.Text = "weiter";
            buttonStartContinueCombat.Visible = true;
        }
        
        public bool IsHisTurn(Entity entity)
        {
            if (entity.Initiative < _globalInitiative)
            {
                if (_globalInitiative % entity.Initiative == 0)
                    return true;
            }
            else
            {
                if (entity.Initiative == _globalInitiative)
                    return true;
            }
        
            return false;
        }
        
    }
}