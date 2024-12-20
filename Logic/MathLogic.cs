using System.Data;
using games.Variables;

namespace games.Logic;

public class MathLogic
{
    private Random random = new Random();
    private MathVariables mathVar = new MathVariables();
    private int choise;
    private long answer;

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

    public void Launch()
    {
        while (true)
        {
            Console.WriteLine("Выберите тип примеров (0 - Плюс | 1 - Минус | 2 - Деление | 3 - Умножение | Все - 4):");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Выберите длинну примера: ");
            choise = Convert.ToInt32(Console.ReadLine());
            if (choise > 40)
            {
                Console.WriteLine("Вы превысили лимит доступной длины приимера. Максимальная длина - 40. Потоврите ввод");
                choise = Convert.ToInt32(Console.ReadLine());
            }
            else if (choise <= 1)
            {
                Console.WriteLine("Вы выбрали слишком маленький пример. Минимальная длина - 2. Потоврите ввод");
                choise = Convert.ToInt32(Console.ReadLine());
            }
            else {}
            
            switch (userInput)
            {
                case 0:
                    GameCalculateSeparateLogic(0); // { "+" - 1, "-" - 2, "/" - 3, "*" - 4 ALL - 5 }
                    break;
                
                case 1:
                    GameCalculateSeparateLogic(1);
                    break;
                
                case 2:
                    GameCalculateSeparateLogic(2);
                    break;
                
                case 3:
                    GameCalculateSeparateLogic(3);
                    break;
                
                case 4: 
                    GameCalculateLogic();
                    break;
                
                default:
                    
                    break;
            }
            
            Console.WriteLine("Хотите повторить игру? Y/N");
            ConsoleKey input = Console.ReadKey().Key;
            if (input == ConsoleKey.Y) ;
            else if (input == ConsoleKey.N) break;
            else break;
        }
    }

    public void GameCalculateLogic()
    {
        string examResult = String.Empty;
        int[] numbersgen = new int[choise]; // Хранит числа примера
        string[] symbols = new string[4] { "+", "-", "/", "*" }; // Хранит мат. символы
        string[] symbolgen = new string[choise - 1]; // Вставляет символы рандомно (-1 для того, чтобы символ не стоял в конце всего примера)
        Console.Write("Ваш пример: ");
        for (int i = 0; i < numbersgen.Length; i++)
        {
            int rndsymbgen = random.Next(0, 4); // Рандомно выбираем мат.символ
            if (i < symbolgen.Length) // Если i меньше длинны массива symbolgen
            {
                if (symbols[rndsymbgen] == "/") // Если symbols = / меняем знак на : для удобного понимания
                {
                    symbolgen[i] = ":";
                }
                else symbolgen[i] = symbols[rndsymbgen]; // Иначе пропускаем и выводим символ с массива
            }

            numbersgen[i] = random.Next(10, 100); // Записываем в массив с числами рандомное число
            if (i < symbolgen.Length) // Если i меньше длинны symbolgen пишем строку с символом математики в конце
            {
                Console.Write($"{numbersgen[i]} {symbolgen[i]} ");
                if (symbols[rndsymbgen] == ":")
                {
                    symbolgen[i] = "/";
                }
                else symbolgen[i] = symbols[rndsymbgen];

                examResult += numbersgen[i] + " " + symbolgen[i] + " ";
            }
            else
            {
                Console.Write($"{numbersgen[i]} "); // Иначе пишем строку только с числом чтобы не допустить ненужного символа в конце
                examResult += numbersgen[i];
            }
        }

        DataTable dt = new DataTable();
        var res = dt.Compute(examResult, String.Empty);
        long mathRes = Convert.ToInt64(res);
        //Console.WriteLine(mathRes);
        Console.WriteLine("Введите ваш ответ: ");
        answer = Convert.ToInt64(Console.ReadLine());
        if (mathRes == answer) Console.WriteLine("Поздравляем! Вы угадали число.");
        else Console.WriteLine("Вы не угадали число.");
    }
    
    public void GameCalculateSeparateLogic(int mathSymb)
    {
        string examResult = String.Empty;
        int[] numbersgen = new int[choise]; // Хранит числа примера
        string[] symbols = new string[4] { "+", "-", "/", "*" }; // Хранит мат. символы
        string[] symbolgen = new string[choise - 1]; // Вставляет символы рандомно (-1 для того, чтобы символ не стоял в конце всего примера)
        Console.Write("Ваш пример: ");
        for (int i = 0; i < numbersgen.Length; i++)
        {
            //int rndsymbgen = random.Next(0, 4); // Рандомно выбираем мат.символ
            if (i < symbolgen.Length) // Если i меньше длинны массива symbolgen
            {
                if (symbols[mathSymb] == "/") // Если symbols = / меняем знак на : для удобного понимания
                {
                    symbolgen[i] = ":";
                }
                else symbolgen[i] = symbols[mathSymb]; // Иначе пропускаем и выводим символ с массива
            }

            numbersgen[i] = random.Next(10, 100); // Записываем в массив с числами рандомное число
            if (i < symbolgen.Length) // Если i меньше длинны symbolgen пишем строку с символом математики в конце
            {
                Console.Write($"{numbersgen[i]} {symbolgen[i]} ");
                if (symbols[mathSymb] == ":")
                {
                    symbolgen[i] = "/";
                }
                else symbolgen[i] = symbols[mathSymb];

                examResult += numbersgen[i] + " " + symbolgen[i] + " ";
            }
            else
            {
                Console.Write($"{numbersgen[i]} "); // Иначе пишем строку только с числом чтобы не допустить ненужного символа в конце
                examResult += numbersgen[i];
            }
        }

        DataTable dt = new DataTable();
        var res = dt.Compute(examResult, String.Empty);
        long mathRes = Convert.ToInt64(res);
        //Console.WriteLine(mathRes);
        Console.WriteLine("Введите ваш ответ: ");
        answer = Convert.ToInt64(Console.ReadLine());
        if (mathRes == answer) Console.WriteLine("Поздравляем! Вы угадали число.");
        else Console.WriteLine("Вы не угадали число.");
    }
}