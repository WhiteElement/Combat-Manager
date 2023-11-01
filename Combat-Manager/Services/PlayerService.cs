using System;
using System.Collections.Generic;
using System.IO;
using Combat_Manager.Models;
using Newtonsoft.Json;

namespace Combat_Manager.Services
{
    public class PlayerService
    {
        // private string playerFilePath = Environment.CurrentDirectory.Substring(0, 
        //     Environment.CurrentDirectory.IndexOf("bin")) + "resources\\players.json";
        private string playerFilePath = "resources\\players.json";
        
        public List<Player> LoadPlayersFromFile()
        {
            string json = File.ReadAllText(playerFilePath);
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(json) ?? new List<Player>();
            return players;
        }

        public void WritePlayersToFile(string json)
        {
            File.WriteAllText(playerFilePath,json);        
        }
    }
}