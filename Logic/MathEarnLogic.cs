using System.Text.Json.Serialization.Metadata;
using games.Variables;

namespace games.Logic;

public class MathEarnLogic
{
    private Random rnd = new Random();
    private semiDataBaseLogic dbLogic = new semiDataBaseLogic();
    private MainVariable mainVar = new MainVariable(); 
    public int CalculateCoinsEarned(int lenght, int difficulty, int result, bool passed)
    {
        int baseCoins = 100; // бейсик количество монет
        int difficultyMultiplier = (result / 10) * difficulty; // Множитель сложности
        int lenghtEarn = lenght * difficultyMultiplier ; // минус за кол-во попыток
        int randomBonus = rnd.Next(1, 11); // бонус от 1 до 10 (т.к 11 не считается)
        int coinsEarned;
        if (passed)
        {
            coinsEarned = baseCoins + difficultyMultiplier + lenghtEarn + randomBonus;
        }
        else
        {
            coinsEarned = 150 - difficultyMultiplier - lenghtEarn / 10 + randomBonus;
        }
        if (coinsEarned < 0 && passed)
        {
            coinsEarned = coinsEarned * -1;
        }
        
        return Math.Max(coinsEarned, 0); // Проверяем количество монет, должно быть не отрицательное
    }
}