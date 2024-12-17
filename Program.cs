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

        GameStart();
        Console.WriteLine("Желаете сыграть еще раз?");
        Console.ReadKey();

        void GameStart()
        {
            Console.WriteLine("Добро пожаловать в All in One Games!");
            Console.WriteLine("Выберите тип игры (1 - Угадайка) :");
            mainVariable.globalInput = Convert.ToInt32(Console.ReadLine());
            if (mainVariable.globalInput == 1)
            {
                guessGame.Start();
                for (int i = 0; i < 999; i++)
                {
                    guessLogic.GameLogic();
                }
            }
        }
    }
}