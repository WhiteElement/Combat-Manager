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
        private string npcPath = Environment.CurrentDirectory.Substring(0, 
                                     Environment.CurrentDirectory.IndexOf("bin")) + "resources\\npcs.json";
        
        public NpcsWindow()
        {
            InitializeComponent();
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
            
            string json = File.ReadAllText(npcPath);
            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(json) ?? new List<NPC>();
            
            npcs.Add(newNpc);
            json = JsonConvert.SerializeObject(npcs);
            
            File.WriteAllText(npcPath,json);
        }

        private void MustFieldNotEntered()
        {
            MessageBox.Show("Mussfeld ist nicht ausgefüllt");
        }
    }
}