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
        while (true)
        {
            Console.WriteLine("Выберите тип примеров (1 - Плюс | 2 - Минус | 3 - Деление | 4 - Умножение):");
            mathVariables.userInput = Convert.ToInt32(Console.ReadLine());
            mathLogic.GameLogic(mathVariables.userInput);
            Console.WriteLine("Хотите повторить игру? Y/N");
            ConsoleKey input = Console.ReadKey().Key;
            if (input == ConsoleKey.Y)
            {
                mathVariables.userInput = 0;
            }
            else if (input == ConsoleKey.N)
            {
                break;
            }
            else break;
        }
    }
}