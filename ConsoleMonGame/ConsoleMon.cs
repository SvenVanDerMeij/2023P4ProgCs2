using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public Element weakness { get; set; }
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }
        private List<Skill> skills;

        internal void TakeDamage(int damage)
        {
            health = health - damage;
        }
        internal void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
    }
}
