using games.Variables;

namespace games.Logic;

public class GuessLogic
{
   private GuessVariables guessVer = new GuessVariables();
   private Random rnd = new Random();

   public void GameLogic()
   {
      guessVer.randomNumber = rnd.Next(1, 10);
      
      Console.WriteLine("Загаданно число от 1 до 100. Можете начать угадывать");
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