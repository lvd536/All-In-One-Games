using games.Variables;

namespace games.Logic;

public class semiDataBaseLogic
{
    private MainVariable mainVariable = new MainVariable();
    private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    public string folder = desktopPath + "\\All-In-One\\";
    public void InitDB(bool debug)
    { 
        Create(folder, "moneyDB.db", debug);
        Create(folder, "guessesDB.db", debug);
        Create(folder, "mathsDB.db", debug);
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
            File.Create(folder + file).Dispose();
            if (debug) Console.WriteLine("DEBUG: Created file: " + file);
        }
        else
        {
            if (debug) Console.WriteLine($"DEBUG: File {file} exists!");
        }
    }
}