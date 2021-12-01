using System;
using System.Collections.Generic;
using Heist_Pt_2.RobberTypes;

namespace Heist_Pt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Joe = new Hacker()
            {
                Name = "Joe",
                SkillLevel = 15,
                PercentageCut = 25
            };
            Hacker John = new Hacker()
            {
                Name = "John",
                SkillLevel = 15,
                PercentageCut = 25
            };
            Muscle Bob = new Muscle()
            {
                Name = "Bob",
                SkillLevel = 10,
                PercentageCut = 25
            };
            Muscle Bill = new Muscle()
            {
                Name = "Bill",
                SkillLevel = 10,
                PercentageCut = 25
            };
            LockSpecialist Sue = new LockSpecialist()
            {
                Name = "Sue",
                SkillLevel = 15,
                PercentageCut = 25
            };
            LockSpecialist Serana = new LockSpecialist()
            {
                Name = "Serana",
                SkillLevel = 15,
                PercentageCut = 25
            };
            List<IRobber> rolodex = new List<IRobber>
            {
                Joe, John, Bob, Bill, Sue, Serana
            };
            Console.WriteLine($"Current Hesit Operatives", rolodex.Count);
            Console.WriteLine("New CrewMember Name:");
            Console.WriteLine($"Pick a Crew Member: {robber.Name}");
            var NewCrewMember = Console.ReadLine();
        }
    }
}
