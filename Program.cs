using System;
using System.Collections.Generic;
using Heist_Pt_2.RobberTypes;

namespace Heist_Pt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Joe = new Hacker("joe", 15, 25);

            Hacker John = new Hacker("John", 15, 25);

            Muscle Bob = new Muscle("Bob", 15, 25);

            Muscle Bill = new Muscle("Bill", 15, 25);

            LockSpecialist Sue = new LockSpecialist("Sue", 15, 25);

            LockSpecialist Serana = new LockSpecialist("Serana", 15, 25);

            List<IRobber> rolodex = new List<IRobber>
            {
                Joe, John, Bob, Bill, Sue, Serana
            };
            AddNewCrewMember();

            void AddNewCrewMember()
            {
                Console.WriteLine($"Current Heist Operatives {rolodex.Count}");
                Console.WriteLine($"Pick a Crew Member: ");
                var NewCrewMember = Console.ReadLine();

                Console.WriteLine($"{NewCrewMember} can be 1 - Hacker(Disables Alarms), 2 - Muscle(Disarms Gaurds), 3 = Lock Specialist(Caracks Safe)");
                var thief = int.Parse(Console.ReadLine());
                string[] thiefTypes = new string[] { "Null", "Hacker", "Muscle", "LockSpecialist" };
                var thiefType = thiefTypes[thief];
                Console.WriteLine($"{NewCrewMember} is the {thiefType}");
                Console.WriteLine($"What will {NewCrewMember}'s skill level be? (1-100)");
                var skillLevel = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"{NewCrewMember} has a skill level of {skillLevel}");
                Console.WriteLine($"What percentage cut do you want {NewCrewMember} to recieve");
                var percentageCut = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"{NewCrewMember} will recieve a {percentageCut}% cut");
                if (thief == 1)
                {
                    rolodex.Add(new Hacker(NewCrewMember, skillLevel, percentageCut));
                }
                else if (thief == 2)
                {
                    rolodex.Add(new Muscle(NewCrewMember, skillLevel, percentageCut));
                }
                else
                {
                    rolodex.Add(new LockSpecialist(NewCrewMember, skillLevel, percentageCut));
                }

                Console.WriteLine("Choose another member?(Y/N): ");
                var answer = Console.ReadLine();
                if (answer == "Y")
                {
                    AddNewCrewMember();
                }


            }
        }
    }
}
