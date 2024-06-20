namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");
            string[] keyvalue = content.Split(new char[] {  ':'} );
            
            Console.WriteLine(keyvalue[0]);
            string[] cijfersPerVak = keyvalue[1].Split(new char[] { ',' });
            Console.WriteLine(cijfersPerVak[0]);
            Console.WriteLine(cijfersPerVak[1]);
            


        }
    }
}
