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

    public void TestGameLogic()
    {
        Console.WriteLine("Выберите длинну примера: ");
        int choise = Convert.ToInt32(Console.ReadLine());
        int[] numbersgen = new int[choise]; // Хранит числа примера
        string[] symbols = new string[] { "+", "-", "/", "*" }; // Хранит мат. символы
        string[] symbolgen = new string[choise - 1]; // Вставляет символы рандомно (-1 для того, чтобы символ не стоял в конце всего примера)
        for (int i = 0; i < numbersgen.Length; i++)
        {
            int rndsymbgen = random.Next(0, 4); // Рандомно выбираем мат.символ
            if(i < symbolgen.Length)
            {
                symbolgen[i] = symbols[rndsymbgen];
            }
            numbersgen[i] = random.Next(10, 1000); // Записываем в массив с числами рандомное число
            if (i < symbolgen.Length)
            {
                Console.Write($"{numbersgen[i]} {symbolgen[i]} ");
            }
            else
            {
                Console.Write($"{numbersgen[i]} ");
            }
        }
    }
}