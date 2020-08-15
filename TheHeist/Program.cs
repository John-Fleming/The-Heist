using System;

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



            Console.WriteLine("Enter a team member's name:");
            var teamMemberName = Console.ReadLine();
            Console.WriteLine("Enter the team member's skill level between 1 and 100:");
            //var skillString = Console.ReadLine();
            var teamMemberSkill = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the team member's courage factor as a decimal between 0.0 and 2.0:");
            var teamMemberCourage = decimal.Parse(Console.ReadLine());

            var member1 = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);
            Console.WriteLine(
                $"Team Member Stats: \n" +
                $"  Name: {member1.Name}\n" +
                $"  Skill: {member1.Skill}\n" +
                $"  Courage Factor: {member1.CourageFactor}"
                );

        }
    }
}
