﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teamwork_Projects
{
    class Team
    {
        public Team(string creator, string name)
        {
            this.Creator = creator;
            this.Name = name;
            this.Members = new List<string>();
            
        }
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            List<string> sortedMembers = this.Members
                .OrderBy(a => a)
                .ToList();
            string output = $"{this.Name}\n";
            output += $"- {this.Creator}\n";

            for (int i = 0; i < sortedMembers.Count; i++)
            {
                output += $"-- {sortedMembers[i]}\n";
            }

            return output.Trim();
        }
    }
}
