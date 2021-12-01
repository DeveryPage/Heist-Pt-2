using System;
using System.Collections.Generic;

namespace Heist_Pt_2.RobberTypes
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore--;
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has unlocked the Safe!");
            }
            else
            {
                Console.WriteLine($"{Name} is unlocking the safe. Decreased security {SkillLevel}");
            }
        }
    }
}