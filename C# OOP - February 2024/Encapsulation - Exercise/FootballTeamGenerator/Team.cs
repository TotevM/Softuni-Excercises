﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class Team
    {
        private int numberOfPlayers;
        private string name;
        private readonly List<Player> team;

        public Team(string name)
        {
            Name = name;
            team=new List<Player>();
        }

        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set { numberOfPlayers = value; }
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value; 
            }
        }
        public double Rating
        {
            get
            {
                if (team.Any())
                {
                    return Math.Round(team.Average(p => p.SkillLevel)) ;
                }
                return 0;
            }
        }
        public void AddPlayer(Player player) => team.Add(player);

        public void RemovePlayer(string playerName)
        {
            Player player = team.FirstOrDefault(p => p.Name == playerName);

            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }

            team.Remove(player);
        }
    }
}
