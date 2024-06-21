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
            //Console.WriteLine(birds);
            //Console.WriteLine("Hello, World!");
            //birds.ForEach(Console.WriteLine);
             TestFactoryFunctions();
            //  ConsoleMon datamon = new ConsoleMon("monsterdata.txt");
            
            
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

            Console.WriteLine(targetMon.health == -150);

            Console.WriteLine(casterMon.energy == -20);
        }

        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            factory.Load("monsterdata.txt");
            factory.LoadJson("monsterdata.json");
        }

    }
}
