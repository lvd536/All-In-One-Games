namespace games.Logic;

public class semiDataBaseLogic
{
    public void InitDB()
    {
        Create("C:\\Users\\lvd\\Desktop\\All-In-One\\", "moneyDB.db");
        Create("C:\\Users\\lvd\\Desktop\\All-In-One\\", "guessesDB.db");
        Create("C:\\Users\\lvd\\Desktop\\All-In-One\\", "mathsDB.db");
    }
    
    private void Create(string folder, string file)
    {
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
            Console.WriteLine("DEBUG: Created folder: " + folder);
        }

        if (!File.Exists(folder + file))
        {
            File.Create(folder + file);
            Console.WriteLine("DEBUG: Created file: " + file);
        }
    }

    public void Write(string folder, string file, string content)
    {
        File.WriteAllText(folder + file, content);
        Console.WriteLine("DEBUG: Wrote file: " + file);
    }

    public void Read(string folder, string file)
    {
        File.ReadAllText(folder + file);
        Console.WriteLine("DEBUG: Read file: " + file);
    }

    public void Delete(string folder, string file)
    {
        File.Delete(folder + file);
        Console.WriteLine("DEBUG: Deleted file: " + file);
    }

    public void Clear(string folder, string file)
    {
        File.WriteAllText(folder + file, "");
    }
}