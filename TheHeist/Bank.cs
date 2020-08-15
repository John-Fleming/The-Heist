using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Bank
    {
        public int Difficulty { get; set; }

        public int HeistAttempts { get; set; }

        public Bank(int difficulty, int attempts)
        {
            Difficulty = difficulty;
            HeistAttempts = attempts;
        }

        public void Rob(Team team)
        {
            while (team.TeamHeistCount <= HeistAttempts)
            {
                Console.WriteLine($"Commencing bank heist attempt {team.TeamHeistCount}!\n");
                var luckFactor = new Random().Next(-10, 10);
                var adjustedBankDifficulty = Difficulty + luckFactor;

                Console.WriteLine
                    (
                        $"Heist Attempt Stats: \n" +
                        $"  Team Combined Skill: {team.TeamSkillLevel} \n" +
                        $"  Bank Difficulty Level: {Difficulty} \n" +
                        $"  Luck Factor: {luckFactor} \n" +
                        $"  Adjusted Bank Difficulty Level: {adjustedBankDifficulty} \n"
                        );

                if (team.TeamSkillLevel >= adjustedBankDifficulty)
                {
                    Console.WriteLine("You're Rich! The bank stood no chance against your masterful heist!\n");
                    team.SuccessfulHeists++;
                }
                else
                {
                    Console.WriteLine("Oh no! The bank security system was too good for your team! Run away!\n");
                    team.FailedHeists++;
                }

                if (team.TeamHeistCount == HeistAttempts) 
                {
                    break;
                }
                else
                {
                    team.TeamHeistCount++;
                }
            }
        }
    }
}
