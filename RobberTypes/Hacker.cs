using System;
using System.Collections.Generic;

namespace Heist_Pt_2.RobberTypes
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore--;
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disables the alarm system!");
            }
            else
            {
                Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel}");
            }
        }
        public Hacker(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }
    }
}