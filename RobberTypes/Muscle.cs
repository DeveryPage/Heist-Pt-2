using System;

namespace Heist_Pt_2.RobberTypes
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGaurdScore--;
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has taken care of the gaurds!");
            }
            else
            {
                Console.WriteLine($"{Name} is taking care of the gaurds. Decreased security {SkillLevel}");
            }
        }
    }
}