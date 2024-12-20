using games.Logic;
using games.Variables;

namespace games.Games;

public class MathGame
{
    MathLogic mathLogic = new MathLogic();

    public void StartLogic()
    {
        Console.WriteLine("Добро пожаловать в игру *Математическая Викторина* !");
        Console.WriteLine("Ваша задача: решить пример");
        mathLogic.Launch();
    }
}