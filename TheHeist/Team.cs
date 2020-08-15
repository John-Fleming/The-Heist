using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Team
    {
        public List<TeamMember> TeamMembers = new List<TeamMember>();
        public int TeamSkillLevel { get; set; }
        public int TeamHeistCount { get; set; } = 1;
        public int SuccessfulHeists { get; set; }
        public int FailedHeists { get; set; }

        public void AddTeamMembers()
        {
            while (true)
            {
                Console.WriteLine("Enter a team member's name:");
                var teamMemberName = Console.ReadLine();

                Console.WriteLine("Enter the team member's skill level between 1 and 100:");
                var teamMemberSkill = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the team member's courage factor as a decimal between 0.0 and 2.0:");
                var teamMemberCourage = decimal.Parse(Console.ReadLine());

                var teamMember = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);
                TeamMembers.Add(teamMember);

                Console.WriteLine("Would you like to add another team member? (Enter y or n)");
                var continueInput = Console.ReadLine();

                if (continueInput == "n")
                {
                    Console.WriteLine("Your Heist team is ready to go!");
                    break;
                }
            }
        }

        public void CombineTeamMemberSkill()
        {
            foreach (var member in TeamMembers)
            {
                TeamSkillLevel += member.Skill;
            }
        }

        public void TeamHeistSuccessReport()
        {
            Console.WriteLine($"The team attempted to rob the bank {TeamHeistCount} times, succeeding {SuccessfulHeists} times and failing {FailedHeists} times.");
            Console.WriteLine
                    (
                        $"The team attempted to rob the bank {TeamHeistCount} times. \n" +
                        $"  Successful Attempts: {SuccessfulHeists} \n" +
                        $"  Failed Attempts: {FailedHeists}"
                        );
        }

    }
}
