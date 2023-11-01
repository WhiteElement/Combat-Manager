using System;
using System.Collections.Generic;
using System.IO;
using Combat_Manager.Models;
using Newtonsoft.Json;

namespace Combat_Manager.Services
{
    public class NpcService
    {
        //Production Path
        // private string npcFilePath = "resources\\npcs.json";
        
        private string npcFilePath = Environment.CurrentDirectory.Substring(0, 
            Environment.CurrentDirectory.IndexOf("bin")) + "resources\\npcs.json";
        
        public List<NPC> LoadNpcsFromFile()
        {
            string json = File.ReadAllText(npcFilePath);
            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(json) ?? new List<NPC>();
            return npcs;
        }

        public void WriteNpcsToFile(string json)
        {
            File.WriteAllText(npcFilePath,json);        
        }
    }
}