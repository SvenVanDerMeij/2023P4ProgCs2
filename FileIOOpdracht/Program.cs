namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = @"C:\Users\svenj\OneDrive\Documents\Ma dingen\bewijzenmap\Jaar 1\periode 4\prog\2023P4ProgCs2\FileIOOpdracht\bin\Debug\net8.0\leesdezefile.txt";
            var dest = @"C:\Users\svenj\OneDrive\Documents\Ma dingen\bewijzenmap\Jaar 1\periode 4\prog\2023P4ProgCs2\FileIOOpdracht\bin\Debug\net8.0\output\leesdezefile.txt";
            string[] content = File.ReadAllLines("leesdezefile.txt");
           // File.AppendAllText("leesdezefile.txt", "hallo" + Environment.NewLine);
            
            File.Move(source, dest);
            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}
