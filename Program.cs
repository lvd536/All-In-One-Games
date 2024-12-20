using games.Games;
using games.Logic;
using games.Variables;

public class Program
{
    static void Main(string[] args)
    {
        GuessGame guessGame = new GuessGame();
        MainVariable mainVariable = new MainVariable();
        MathGame mathGame = new MathGame();
        semiDataBaseLogic semiDBLogic = new semiDataBaseLogic();
        Console.Title = "All in One game | by lvd.";
        semiDBLogic.InitDB(true);
        GameStart();

        void GameStart()
        {
            Console.WriteLine("Добро пожаловать в All in One Games!");
            Console.WriteLine("Выберите тип игры (1 - Угадайка | 2 - Математическая викторина) :");
            try
            {
                mainVariable.globalInput = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine($"Вы ввели некорректное число");
            }
            if (mainVariable.globalInput == 1)
            {
                guessGame.StartLogic();
            }
            else if (mainVariable.globalInput == 2)
            {
                mathGame.StartLogic();
            }
        }
    }
}