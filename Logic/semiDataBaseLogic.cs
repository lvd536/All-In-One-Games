namespace games.Logic;

public class semiDataBaseLogic
{
    private DbVariables dbVar = new DbVariables();
    public void InitDB(bool debug)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        dbVar.folder = desktopPath + "\\All-In-One\\";
        Create(dbVar.folder, "moneyDB.db", debug);
        Create(dbVar.folder, "guessesDB.db", debug);
        Create(dbVar.folder, "mathsDB.db", debug);
        Read(dbVar.folder, "moneyDB.db", debug);
        Read(dbVar.folder, "guessesDB.db", debug);
        Read(dbVar.folder, "mathsDB.db", debug);
    }
    
    private void Create(string folder, string file, bool debug)
    {
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder); 
            if (debug) Console.WriteLine("DEBUG: Created folder: " + folder);
            
        }
        else
        {
            if (debug) Console.WriteLine($"DEBUG: Folder {folder} exists!");
        }

        if (!File.Exists(folder + file))
        {
            File.Create(folder + file);
            if (debug) Console.WriteLine("DEBUG: Created file: " + file);
        }
        else
        {
            if (debug) Console.WriteLine($"DEBUG: File {file} exists!");
        }
    }

    public void Write(string folder, string file, string content, bool debug)
    {
        File.WriteAllText(folder + file, content);
        if (debug) Console.WriteLine("DEBUG: Wrote file: " + file);
    }

    public void Read(string folder, string file, bool debug)
    {
        File.ReadAllText(folder + file);
        if (debug) Console.WriteLine("DEBUG: Read file: " + file);
    }

    public void Delete(string folder, string file, bool debug)
    {
        File.Delete(folder + file);
        if (debug) Console.WriteLine("DEBUG: Deleted file: " + file);
    }

    public void Clear(string folder, string file)
    {
        File.WriteAllText(folder + file, "");
    }
}