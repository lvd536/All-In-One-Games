using games.Logic;
using games.Variables;

namespace games.Games;

public class GuessGame
{
    private MainVariable mainVar = new MainVariable();
    private GuessLogic guessLogic = new GuessLogic();
    private GuessVariables guessVariables = new GuessVariables();

    public void StartLogic()
    {
        Console.WriteLine("Добро пожаловать в игру *Угадай число* !");
        Console.WriteLine("Ваша задача: угадать число, которое загадала система");
        while (true)
        {
            Console.WriteLine("Хотите настроить диапазон чисел? (1 - Настроить в ручную | 2 - Оставить базовый)");
            mainVar.globalInput = Convert.ToInt32(Console.ReadLine());
            if (mainVar.globalInput == 1)
            {
                Console.WriteLine("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Отлично! Числа будут генерироваться от {num1} до {num2} !");
                guessLogic.GameLogic(num1, num2, false);
            }

            else if (mainVar.globalInput == 2) guessLogic.GameLogic(0, 0, true);
            else {};

            Console.WriteLine("Хотите повторить игру? Y/N");
            ConsoleKey input = Console.ReadKey().Key;
            if (input == ConsoleKey.Y)
            {
                guessVariables.userInput = 0;
            }
            else if (input == ConsoleKey.N)
            {
                break;
            }
            else break;
        }
    }
}