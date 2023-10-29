using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Combat_Manager.Models;
using Newtonsoft.Json;

namespace Combat_Manager
{
    public partial class NpcsWindow : Form
    {
        private string _npcFilePath = Environment.CurrentDirectory.Substring(0, 
                                     Environment.CurrentDirectory.IndexOf("bin")) + "resources\\npcs.json";
        
        public NpcsWindow()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        

        private void newNpcButton_Click(object sender, EventArgs e)
        {
            NPC newNpc;
            try
            {
                newNpc = new NPC()
                {
                    Name = nameBox.Text,
                    Initiative = Int32.Parse(initiativeBox.Text),
                    Parry = Int32.Parse(parryBox.Text),
                    HitPoints = Int32.Parse(hpBox.Text),
                    Comment = commentBox.Text
                };
            }
            catch
            {
                MustFieldNotEntered();
                return;
            }
            
            var npcs = LoadNpcsFromFile();

            npcs.Add(newNpc);
            string json = JsonConvert.SerializeObject(npcs);
            
            File.WriteAllText(_npcFilePath,json);
            
            PopulateTreeView();
        }

        private List<NPC> LoadNpcsFromFile()
        {
            string json = File.ReadAllText(_npcFilePath);
            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(json) ?? new List<NPC>();
            return npcs;
        }

        private void MustFieldNotEntered()
        {
            MessageBox.Show("Mussfeld ist nicht ausgefüllt");
        }
        
        private void PopulateTreeView()
        {
            var npcs = LoadNpcsFromFile();

            foreach (var npc in npcs)
            {
                TreeNode node = new TreeNode();
                node.Text = npc.Name;
                
                node.Nodes.Add(new TreeNode($"Initiative: {npc.Initiative}"));
                node.Nodes.Add(new TreeNode($"Parade: {npc.Parry}"));
                node.Nodes.Add(new TreeNode($"HP: {npc.HitPoints}"));
                node.Nodes.Add(new TreeNode($"Kommentar: {npc.Comment}"));
                
                treeView1.Nodes.Add(node);
    
            }
            treeView1.ExpandAll();
            
        }

    }
}