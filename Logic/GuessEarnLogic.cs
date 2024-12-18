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
        return Math.Max(coinsEarned, 0); // Проверяем количество монет, должно быть не отрицательное
    }
}