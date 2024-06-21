using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        
        internal void Load(string datafile)
        {
            
            string[] lines = File.ReadAllLines(datafile);
            foreach (string line in lines)
            {
                string[] typeSplit = line.Split(new char[] { '|' });
                string[] consolemonData = typeSplit[0].Split(new char[] {','});
                ConsoleMon datamon = new ConsoleMon();
                datamon.name = consolemonData[0];
                Console.WriteLine(datamon.name);
                datamon.health = Convert.ToInt16(consolemonData[2]);
                Console.WriteLine(datamon.health);
                datamon.energy = Convert.ToInt16(consolemonData[4]);
                Console.WriteLine(datamon.energy);
                
                

            }

            
        }

        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);
            Console.WriteLine(json);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }
    }
}
