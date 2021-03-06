﻿using _03.Validation_Of_Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.First_And_Reserve_Team
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            
        }
        public string Name { get; set; }
        public IReadOnlyList<Person> FirstTeam => this.firstTeam;

        public IReadOnlyList<Person> ReserveTeam => this.reserveTeam;

        public void AddPlayer (Person player)
        {
            if (player.Age < 40 )
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }
    }
}
