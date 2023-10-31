using System.Collections.Generic;
using System.Windows.Forms;
using Combat_Manager.Models;

namespace Combat_Manager.Helper
{
    public class FormHelper
    {
        public static void MustFieldNotEntered()
        {
            MessageBox.Show("Mussfeld ist nicht ausgefüllt");
        }

        public static void PopulateTreeView(TreeView treeView, List<NPC> npcs, bool expand)
        {
            treeView.Nodes.Clear();
            
            foreach (var npc in npcs)
            {
                TreeNode node = new TreeNode();
                node.Text = npc.Name;
                
                node.Nodes.Add(new TreeNode($"Initiative: {npc.Initiative}"));

                if (npc.Attack != null)
                    node.Nodes.Add(new TreeNode($"Attacke: {npc.Attack}"));
                if (npc.HitPoints != null)
                    node.Nodes.Add(new TreeNode($"HP: {npc.HitPoints}"));
                if (npc.Parry != null)
                    node.Nodes.Add(new TreeNode($"Parade: {npc.Parry}"));
                if (!string.IsNullOrEmpty(npc.Comment))
                    node.Nodes.Add(new TreeNode($"Kommentar: {npc.Comment}"));
                
                treeView.Nodes.Add(node);
            }
            
            if(expand)
                treeView.ExpandAll();
        }
        
        public static void PopulateTreeView(TreeView treeView, List<Player> players, bool expand)
        {
            treeView.Nodes.Clear();
            
            foreach (var player in players)
            {
                TreeNode node = new TreeNode();
                node.Text = player.Name;
                
                node.Nodes.Add(new TreeNode($"Initiative: {player.Initiative}"));
                
                treeView.Nodes.Add(node);
    
            }
            
            if(expand)
                treeView.ExpandAll();
        }
    }
}