using games.Variables;

namespace games.Logic;

public class semiDataBaseLogic
{
    private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    public static string folder = desktopPath + "\\All-In-One\\";
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

    /*public void Read(string folder, string file, int variable, bool debug)
    {
        if (debug)
        {
            Console.WriteLine($"DEBUG: Patch: {folder + file}");
            //Console.WriteLine($"DEBUG: Reading to variable {variable}");
        }
        variable = Convert.ToInt32(File.ReadAllText(folder + file));
        Console.WriteLine("Variable context: " + variable);
        
    }
    
    public void Write(string folder, string file, int variable, bool debug)
    {
        if (debug)
        {
            Console.WriteLine($"DEBUG: Patch: {folder + file}");
            //Console.WriteLine($"DEBUG: Reading to variable {variable}");
        }
        File.WriteAllText(folder + file, variable.ToString());
        if (debug) Console.WriteLine("Variable context writed: " + variable);
        
    }*/
}