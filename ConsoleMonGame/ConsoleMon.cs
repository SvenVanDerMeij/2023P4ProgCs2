﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal Element weakness;
        internal int health;
        internal int energy;
        internal string name;
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
