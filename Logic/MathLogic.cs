using games.Variables;

namespace games.Logic;

public class MathLogic
{
    private Random random = new Random();
    private MathVariables mathVar = new MathVariables();

    public void GameLogic(int choise)
    {
        void PlusLogic()
        {
            do
            {
                mathVar.ex1 = random.Next(10, 1000);
                mathVar.ex2 = random.Next(10, 1000);
                Console.WriteLine($"Ваш пример: {mathVar.ex1} + {mathVar.ex2}");
                mathVar.userInput = Convert.ToInt32(Console.ReadLine());
                if (mathVar.ex1 + mathVar.ex2 == mathVar.userInput)
                {
                    Console.WriteLine("Пример решен верно! Ответ: " + (mathVar.ex1 + mathVar.ex2));
                }
                else Console.WriteLine("Неправильный ответ");
            } while (mathVar.ex1 + mathVar.ex2 != mathVar.userInput);
        }

        void MinusLogic()
        {
            do
            {
                mathVar.ex1 = random.Next(10, 1000);
                mathVar.ex2 = random.Next(10, 1000);
                Console.WriteLine($"Ваш пример: {mathVar.ex1} - {mathVar.ex2}");
                mathVar.userInput = Convert.ToInt32(Console.ReadLine());
                if (mathVar.ex1 - mathVar.ex2 == mathVar.userInput)
                {
                    Console.WriteLine("Пример решен верно! Ответ: " + (mathVar.ex1 - mathVar.ex2));
                }
                else Console.WriteLine("Неправильный ответ");
            } while (mathVar.ex1 - mathVar.ex2 != mathVar.userInput);
        }


        void DegreeLogic()
        {
            do
            {
                mathVar.ex1 = random.Next(5, 100);
                mathVar.ex2 = random.Next(5, 100);
                Console.WriteLine($"Ваш пример: {mathVar.ex1} : {mathVar.ex2}");
                mathVar.userInput = Convert.ToInt32(Console.ReadLine());
                if (mathVar.ex1 / mathVar.ex2 == mathVar.userInput)
                {
                    Console.WriteLine("Пример решен верно! Ответ: " + (mathVar.ex1 / mathVar.ex2));
                }
                else Console.WriteLine("Неправильный ответ");
            } while (mathVar.ex1 / mathVar.ex2 != mathVar.userInput);
        }

        void MultipleLogic()
        {
            do
            {
                mathVar.ex1 = random.Next(5, 100);
                mathVar.ex2 = random.Next(5, 100);
                Console.WriteLine($"Ваш пример: {mathVar.ex1} * {mathVar.ex2}");
                mathVar.userInput = Convert.ToInt32(Console.ReadLine());
                if (mathVar.ex1 * mathVar.ex2 == mathVar.userInput)
                {
                    Console.WriteLine("Пример решен верно! Ответ: " + (mathVar.ex1 * mathVar.ex2));
                }
                else Console.WriteLine("Неправильный ответ");
            } while (mathVar.ex1 * mathVar.ex2 != mathVar.userInput);
        }
    }
}