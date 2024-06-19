using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
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
                Console.WriteLine(line);
            }
        }
    }
}
