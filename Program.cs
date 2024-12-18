using games.Games;
using games.Logic;
using games.Variables;

public class Program
{
    static void Main(string[] args)
    {
        GuessGame guessGame = new GuessGame();
        MainVariable mainVariable = new MainVariable();

        GameStart();

        void GameStart()
        {
            Console.WriteLine("Добро пожаловать в All in One Games!");
            Console.WriteLine("Выберите тип игры (1 - Угадайка) :");
            mainVariable.globalInput = Convert.ToInt32(Console.ReadLine());
            if (mainVariable.globalInput == 1)
            {
                //guessGame.Start();
                guessGame.StartLogic();
            }
        }
    }
}