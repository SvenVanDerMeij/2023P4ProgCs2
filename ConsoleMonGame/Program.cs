using System.Diagnostics;

namespace ConsoleMonGame
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> birds = new List<string> { "uil", "Kraai", "papegaai", "hond" };
            List<string> birds2 = new List<string> { "meeuw", "duif" };
            birds.AddRange(birds2);
            birds.Remove(birds[3]);
            Console.WriteLine(birds);
            Console.WriteLine("Hello, World!");
            birds.ForEach(Console.WriteLine);
           // TestSkillFunctions();
        }
        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");
            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon = new ConsoleMon();
            Skill skill = new Skill()
            {
                damage = 100,
                energyCost = 20,
            };
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -100);

            Console.WriteLine(casterMon.energy == -20);
        }


    }
}
