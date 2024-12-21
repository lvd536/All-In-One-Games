using games.Variables;

namespace games.Logic;

public class GuessEarnLogic
{
    private Random rnd = new Random();

    public int CalculateCoinsEarned(int guesses, int oneRnd, int twoRnd)
    {
        int baseCoins = 100; // бейсик количество монет
        int difficultyMultiplier = (twoRnd - oneRnd) / 10; // Множитель сложности
        int guessFuckup = guesses * 5; // минус за кол-во попыток
        int randomBonus = rnd.Next(1, 11); // бонус от 1 до 10 (т.к 11 не считается)

        int coinsEarned = baseCoins + difficultyMultiplier - guessFuckup + randomBonus;
        try
        {
            MainVariable.globalMoney = Convert.ToInt32(File.ReadAllText(semiDataBaseLogic.folder + "moneyDB.db"));
        } catch(FormatException) {}
        MainVariable.globalMoney += coinsEarned;
        File.WriteAllText(semiDataBaseLogic.folder + "moneyDB.db", MainVariable.globalMoney.ToString());
        try
        {
            MainVariable.globalGuesses = Convert.ToInt32(File.ReadAllText(semiDataBaseLogic.folder + "guessesDB.db"));
        } catch(FormatException) {}
        MainVariable.globalGuesses ++;
        File.WriteAllText(semiDataBaseLogic.folder + "guessesDB.db", MainVariable.globalGuesses.ToString());
        
        Console.WriteLine($"Получено {coinsEarned} монет! Баланс: {MainVariable.globalMoney}. Угаданных чисел: {MainVariable.globalGuesses}");


        return Math.Max(coinsEarned, 0); // Проверяем количество монет, должно быть не отрицательное
    }
}