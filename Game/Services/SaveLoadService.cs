using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Game.Entity;


namespace Game.Services
{
    public class SaveLoadService
    {
        public void save(Player player)
        {
            var options = new JsonSerializerOptions{
                IncludeFields = true,
                WriteIndented = true,
            };

            string playerSting = JsonSerializer.Serialize(player, options);

            File.WriteAllText("save.json", playerSting);
        }

        public Player load()
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true,
            };

            string playerString = File.ReadAllText("save.json");

            Player player = JsonSerializer.Deserialize<Player>(playerString, options);

            return player;
        }
    }
}
