using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> allTeams = new List<Team>();
            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamTokens = Console.ReadLine().Split("-");
                string user = teamTokens[0];
                string teamName = teamTokens[1];
                Team existingTeam = allTeams.Find(t => t.Name == teamName);
                Team existingCreator = allTeams.Find(c => c.Creator == user);
                
                
                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (existingCreator != null )
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }
                
                    Team myTeam = new Team(teamTokens[0], teamTokens[1]);
                    allTeams.Add(myTeam);
                
               

                Console.WriteLine($"Team {teamName} has been created by {user}!");

            }

            
            string line = Console.ReadLine();

            while (line != "end of assignment")
            {
                string[] tokens = line.Split("->");
                string user = tokens[0];
                string teamName = tokens[1];
                Team existingTeam = allTeams.Find(t => t.Name == teamName);
                Team existingTeamMember = allTeams.Find(t => t.Members.Contains(user) || t.Creator == user);
                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    line = Console.ReadLine();
                    continue;
                }

                if (existingTeamMember != null)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    line = Console.ReadLine();
                    continue;
                }

                existingTeam.Members.Add(user);
           
                line = Console.ReadLine();
            }

            List<string> disbandedTeams = allTeams
                .Where(a => a.Members.Count == 0)
                .OrderBy(a => a.Name)
                .Select(a => a.Name)
                .ToList();

            allTeams.RemoveAll(t => t.Members.Count == 0);

            List<Team> sortedTeams = allTeams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            foreach (Team t in sortedTeams)
            {
                Console.WriteLine(t.ToString());
            }

            Console.WriteLine("Teams to disband:");
            foreach (string t in disbandedTeams)
            {
                Console.WriteLine(t);
            }
        }
    }
}
