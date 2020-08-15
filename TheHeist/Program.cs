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

            Console.WriteLine("Please create your team by completing the following prompts:\n");


            // Create a team
            var team = new Team();

            team.AddTeamMembers();

            Console.WriteLine($"Team Size: {team.TeamMembers.Count}\n");


            //Create a bank instance
            Console.WriteLine("Enter a number for Bank Difficulty:");
            var bankDifficulty = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter how many times you want your team to attempt the heist:");
            var heistAttempts = int.Parse(Console.ReadLine());

            var bank = new Bank(bankDifficulty, heistAttempts);

            //Conduct the heist
            team.CombineTeamMemberSkill();

            bank.Rob(team);

            //Results
            team.TeamHeistSuccessReport();
        }

    }
}
