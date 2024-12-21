using games.Variables;

namespace games.Logic;

public class GuessLogic
{
    private GuessVariables guessVar = new GuessVariables();
    private Random rnd = new Random();
    private GuessEarnLogic guessEarn = new GuessEarnLogic();
    private MainVariable mainVar = new MainVariable();
    private semiDataBaseLogic semiDBLogic = new semiDataBaseLogic();

    public void GameLogic(int oneRnd, int twoRnd, bool basic)
    {
        if (basic)
        {
            oneRnd = 1;
            twoRnd = 100;
            guessVar.randomNumber = rnd.Next(oneRnd, twoRnd);
        }
        else guessVar.randomNumber = rnd.Next(oneRnd, twoRnd);

        Console.WriteLine("Программа загадала число. Можете начать угадывать");
        Console.WriteLine(guessVar.randomNumber);
        do
        {
            guessVar.userInput = Convert.ToInt32(Console.ReadLine());
            if (guessVar.userInput == guessVar.randomNumber)
            {
                Console.WriteLine($"Вы угадали число {guessVar.randomNumber} за {guessVar.guesses} попыток");
                guessEarn.CalculateCoinsEarned(guessVar.guesses, oneRnd, twoRnd);
            }
            else if (guessVar.userInput < guessVar.randomNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        } while (guessVar.userInput != guessVar.randomNumber);
    }
}