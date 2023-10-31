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

        public static void PopulateTreeView(TreeView treeView, List<Entity> entities, bool expand)
        {
            treeView.Nodes.Clear();
            
            foreach (var entity in entities)
            {
                TreeNode node = new TreeNode();
                node.Text = entity.Name;
                
                node.Nodes.Add(new TreeNode($"Initiative: {entity.Initiative}"));
                // node.Nodes.Add(new TreeNode($"Parade: {entity.Parry}"));
                // node.Nodes.Add(new TreeNode($"HP: {entity.HitPoints}"));
                // node.Nodes.Add(new TreeNode($"Kommentar: {entity.Comment}"));
                
                treeView.Nodes.Add(node);
    
            }
            
            if(expand)
                treeView.ExpandAll();
        }
    }
}