using games.Variables;

namespace games.Logic;

public class MathEarnLogic
{
    private Random rnd = new Random();
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

        if (!passed)
        {
            try
            {
                MainVariable.globalMoney = Convert.ToInt32(File.ReadAllText(semiDataBaseLogic.folder + "moneyDB.db"));
            } catch(FormatException) {}
            MainVariable.globalMoney += coinsEarned;
            File.WriteAllText(semiDataBaseLogic.folder + "moneyDB.db", MainVariable.globalMoney.ToString());
            
            Console.WriteLine($"У вас убавилось {coinsEarned} монет! Всего монет: {MainVariable.globalMoney}. Решенных примеров: {MainVariable.globalMaths}");
        }
        else
        {
            try
            {
                MainVariable.globalMoney = Convert.ToInt32(File.ReadAllText(semiDataBaseLogic.folder + "moneyDB.db"));
            } catch(FormatException) {}
            MainVariable.globalMoney += coinsEarned;
            File.WriteAllText(semiDataBaseLogic.folder + "moneyDB.db", MainVariable.globalMoney.ToString());            
            try
            {
                MainVariable.globalMaths = Convert.ToInt32(File.ReadAllText(semiDataBaseLogic.folder + "mathsDB.db"));
            } catch(FormatException) {}
            MainVariable.globalMaths ++;
            File.WriteAllText(semiDataBaseLogic.folder + "mathsDB.db", MainVariable.globalMaths.ToString());
            Console.WriteLine($"Получено {coinsEarned} монет! Баланс: {MainVariable.globalMoney}. Решенных примеров: {MainVariable.globalMaths}");
        }
        
        return Math.Max(coinsEarned, 0); // Проверяем количество монет, должно быть не отрицательное
    }
}