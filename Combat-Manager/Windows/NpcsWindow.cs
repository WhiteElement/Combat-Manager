using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Combat_Manager.Helper;
using Combat_Manager.Models;
using Combat_Manager.Services;
using Newtonsoft.Json;

namespace Combat_Manager
{
    public partial class NpcsWindow : Form
    {
        private readonly NpcService _npcService;
        
        public NpcsWindow()
        {
            _npcService = new NpcService();
            InitializeComponent();
            List<Entity> npcs = new List<Entity>(_npcService.LoadNpcsFromFile());
            FormHelper.PopulateTreeView(treeView1,new List<Entity>(npcs),true);
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
                FormHelper.MustFieldNotEntered();
                return;
            }
            
            var npcs = _npcService.LoadNpcsFromFile();
            npcs.Add(newNpc);
            
            string json = JsonConvert.SerializeObject(npcs);

            _npcService.WriteNpcsToFile(json);
            
            FormHelper.PopulateTreeView(treeView1,new List<Entity>(npcs),true);
        }
    }
}