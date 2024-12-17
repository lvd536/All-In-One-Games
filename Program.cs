using games.Games;
using games.Logic;
using games.Variables;

public class Program
{
    static void Main(string[] args)
    {
        GuessGame guessGame = new GuessGame();
        GuessLogic guessLogic = new GuessLogic();
        MainVariable mainVariable = new MainVariable();
        GuessVariables guessVariables = new GuessVariables();

        GameStart();

        void GameStart()
        {
            Console.WriteLine("Добро пожаловать в All in One Games!");
            Console.WriteLine("Выберите тип игры (1 - Угадайка) :");
            mainVariable.globalInput = Convert.ToInt32(Console.ReadLine());
            if (mainVariable.globalInput == 1)
            {
                guessGame.Start();
                while (true)
                {
                    guessLogic.GameLogic();
                    Console.WriteLine("Хотите повторить игру? Y/N");
                    ConsoleKey input = Console.ReadKey().Key;
                    if (input == ConsoleKey.Y)
                    {
                        guessVariables.userInput = 0;
                        guessVariables.restartForGuess = true;
                    }
                    else if (input == ConsoleKey.N)
                    {
                        guessVariables.restartForGuess = false;
                        break;
                    }
                    else break;
                }
            }
        }
    }
}