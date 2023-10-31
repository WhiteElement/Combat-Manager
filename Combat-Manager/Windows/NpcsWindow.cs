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
            FormHelper.PopulateTreeView(treeView1,_npcService.LoadNpcsFromFile(),true);
        }
        

        private void newNpcButton_Click(object sender, EventArgs e)
        {
            NPC newNpc;
            try
            {
                newNpc = new NPC()
                {
                    Name = nameBox.Text,
                    Initiative = Int32.Parse(initiativeBox.Text)
                };
            }
            catch
            {
                FormHelper.MustFieldNotEntered();
                return;
            }

            newNpc.Parry = SetOrDefault(parryBox);
            newNpc.Attack = SetOrDefault(attackBox);
            newNpc.HitPoints = SetOrDefault(hpBox);
            newNpc.Comment = commentBox.Text;
            
            var npcs = _npcService.LoadNpcsFromFile();
            npcs.Add(newNpc);
            
            string json = JsonConvert.SerializeObject(npcs);

            _npcService.WriteNpcsToFile(json);
            
            FormHelper.PopulateTreeView(treeView1, npcs, true);
        }

        private int? SetOrDefault(TextBox textBox)
        {
            int result;

            if (Int32.TryParse(textBox.Text, out result))
                return result;

            return null;
        }
        
    }
}