using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Combat_Manager.Helper;
using Combat_Manager.Models;
using Combat_Manager.Services;

namespace Combat_Manager
{
    public partial class CombatWindow : Form
    {
        private readonly CombatService _combatService;
        private List<Entity> _players;
        private List<Entity> _npcs;
        
        public CombatWindow(List<Entity> players, List<Entity> npcs)
        {

            InitializeComponent();
            _combatService = new CombatService();
            _players = players;
            _npcs = npcs;
        }
        
        private void RunMainLoop(List<Entity> players, List<Entity> npcs)
        {
            bool shouldRun = true;
            int globalInitiative = 0;
            List<Entity> entities = players;
            entities.AddRange(npcs);
            
            while (shouldRun)
            {
                Thread.Sleep(100);
                listBox1.Items.Add($"Initiative: {globalInitiative}");
                    
                foreach (Entity entity in entities)
                {
                    if (_combatService.IsTurn(entity, globalInitiative))
                    {
                        Thread.Sleep(100);
                        listBox1.Items.Add($"\t{entity.Name}(Ini: {entity.Initiative}) ist am Zug");
                        
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

        private void CombatWindow_Shown(object sender, EventArgs e)
        {
            FormHelper.PopulateTreeView(treeViewPlayer, _players, true);
            FormHelper.PopulateTreeView(treeViewNpcs, _npcs, true);

            RunMainLoop(_players, _npcs);
        }

        private void PopulateTreeView(TreeView treeView, List<Entity> entities)
        {
            foreach (Entity entity in entities)
            {
                var node = new TreeNode();
                node.Name = entity.Name;
                
                node.Nodes.Add(new TreeNode() {Name = entity.Initiative.ToString()});
                
                treeView.Nodes.Add(node);
            }
            
            

        }
    }
}