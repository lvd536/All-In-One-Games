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
                    Console.WriteLine("Хотите настроить диапазон чисел? (1 - Настроить в ручную | 2 - Оставить базовый)");
                    mainVariable.globalInput = Convert.ToInt32(Console.ReadLine());
                    if (mainVariable.globalInput == 1)
                    {
                        Console.WriteLine("Введите первое число: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Отлично! Числа будут генерироваться от {num1} до {num2} !");
                        guessLogic.GameLogic(num1, num2, false);
                    }

                    else if (mainVariable.globalInput == 2) guessLogic.GameLogic(0, 0, true);
                    else ;
                    
                    Console.WriteLine("Хотите повторить игру? Y/N");
                    ConsoleKey input = Console.ReadKey().Key;
                    if (input == ConsoleKey.Y)
                    {
                        guessVariables.userInput = 0;
                        guessVariables.guesses = 0;
                    }
                    else if (input == ConsoleKey.N)
                    {
                        break;
                    }
                    else break;
                }
            }
        }
    }
}