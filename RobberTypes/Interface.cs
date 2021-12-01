using System;

namespace Heist_Pt_2.RobberTypes
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        void PerformSkill(Bank bank);

    }
}