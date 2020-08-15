using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
 /$$$$$$$ /$$                         /$$     /$$                               /$$   /$$         /$$           /$$    
| $$__  $| $$                        |  $$   /$$/                              | $$  | $$        |__/          | $$    
| $$  \ $| $$ /$$$$$$ /$$$$$$$        \  $$ /$$/$$$$$$ /$$   /$$ /$$$$$$       | $$  | $$ /$$$$$$ /$$ /$$$$$$$/$$$$$$  
| $$$$$$$| $$|____  $| $$__  $$        \  $$$$/$$__  $| $$  | $$/$$__  $$      | $$$$$$$$/$$__  $| $$/$$_____|_  $$_/  
| $$____/| $$ /$$$$$$| $$  \ $$         \  $$| $$  \ $| $$  | $| $$  \__/      | $$__  $| $$$$$$$| $|  $$$$$$  | $$    
| $$     | $$/$$__  $| $$  | $$          | $$| $$  | $| $$  | $| $$            | $$  | $| $$_____| $$\____  $$ | $$ /$$
| $$     | $|  $$$$$$| $$  | $$          | $$|  $$$$$$|  $$$$$$| $$            | $$  | $|  $$$$$$| $$/$$$$$$$/ |  $$$$/
|__/     |__/\_______|__/  |__/          |__/ \______/ \______/|__/            |__/  |__/\_______|__|_______/   \___/  
                                                                                                                       
                                                                                                                       
                                                                                                                                   
                ");

            Console.WriteLine("Please create your team by completing the following prompts: \nWhen done enter a blank value for the team member name.");

            var team = new List<TeamMember>();

            while (true)
            {
                Console.WriteLine("Enter a team member's name:");
                var teamMemberName = Console.ReadLine();

                if (string.IsNullOrEmpty(teamMemberName))
                {
                    Console.WriteLine("Your Heist team is ready to go!");
                    break;
                }

                Console.WriteLine("Enter the team member's skill level between 1 and 100:");
                var teamMemberSkill = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the team member's courage factor as a decimal between 0.0 and 2.0:");
                var teamMemberCourage = decimal.Parse(Console.ReadLine());

                var teamMember = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);
                team.Add(teamMember);
            }

            Console.WriteLine($"Team Size: {team.Count}\n");
            Console.WriteLine("Commencing Bank Heist!");

            //foreach (var member in team)
            //{
            //    Console.WriteLine(
            //        $"Team Member Stats: \n" +
            //        $"  Name: {member.Name} \n" +
            //        $"  Skill: {member.Skill} \n" +
            //        $"  Courage Factor: {member.CourageFactor}\n"
            //        );
            //}

            var bankDifficulty = 100;
            var teamSkillLevel = 0;

            foreach (var member in team)
            {
                teamSkillLevel += member.Skill;
            }

            if (teamSkillLevel >= bankDifficulty)
            {
                Console.WriteLine("You're Rich! The bank stood no chance against your masterful heist!");
            }
            else
            {
                Console.WriteLine("Oh no! The bank security system was too good for your team! Run away!");
            }
        }

    }
}
