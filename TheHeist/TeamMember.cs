using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; }
        public int Skill { get; }
        public decimal CourageFactor { get; }

        public TeamMember(string name, int skill, decimal courageFactor)
        {
            Name = name;
            Skill = skill;
            CourageFactor = courageFactor;
        }
    }
}
