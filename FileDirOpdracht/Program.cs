namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\svenj\OneDrive\Documents\Ma dingen\bewijzenmap\Jaar 1\periode 4\prog\2023P4ProgCs2");
            foreach (var fi in dir.GetFiles())
            {
                Console.WriteLine(fi.Name);

            }

        }
    }
}
