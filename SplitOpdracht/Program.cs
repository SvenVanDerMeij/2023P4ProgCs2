namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");
            string[] keyvalue = content.Split(new char[] {  ':', ',' } );
            
            Console.WriteLine(keyvalue[0]);
            Console.WriteLine(keyvalue[1]);
            Console.WriteLine(keyvalue[2]);


        }
    }
}
