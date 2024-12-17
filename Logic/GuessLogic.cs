using games.Variables;

namespace games.Logic;

public class GuessLogic
{
   private GuessVariables guessVer = new GuessVariables();
   private Random rnd = new Random();

   public void GameLogic(int oneRnd, int twoRnd, bool basic)
   {
      if (basic)
      {
         guessVer.randomNumber = rnd.Next(1, 100);
      } else guessVer.randomNumber = rnd.Next(oneRnd, twoRnd);
      
      Console.WriteLine("Программа загадала число. Можете начать угадывать");
      do
      {
         guessVer.userInput = Convert.ToInt32(Console.ReadLine());
         if (guessVer.userInput == guessVer.randomNumber)
         {
            Console.WriteLine($"Вы угадали число {guessVer.randomNumber} за {guessVer.guesses} попыток");
         }
         else if (guessVer.userInput < guessVer.randomNumber)
         {
            Console.WriteLine("Загаданное число больше.");
            guessVer.guesses += 1;
         }
         else
         {
            Console.WriteLine("Загаданное число меньше.");
            guessVer.guesses += 1;
         }
      } while (guessVer.userInput != guessVer.randomNumber);
   }
}