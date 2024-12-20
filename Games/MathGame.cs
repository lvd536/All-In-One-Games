using games.Logic;
using games.Variables;

namespace games.Games;

public class MathGame
{
    MathVariables mathVariables = new MathVariables();
    MathLogic mathLogic = new MathLogic();

    public void Start()
    {
        Console.WriteLine("Добро пожаловать в игру *Математическая Викторина* !");
        Console.WriteLine("Ваша задача: решить пример");
    }

    public void StartLogic()
    {
        Start();
        mathLogic.Launch();
    }
}