using games.Variables;

namespace games.Logic;

public class GuessLogic
{
   private GuessVariables guessVer = new GuessVariables();
   
   private Random rnd = new Random();

   public void GameLogic()
   {
      guessVer.randomNumber = rnd.Next(1, 100);
      Console.WriteLine("Загаданно число от 1 до 100. Можете начать угадывать");
      do
      {
         guessVer.userInput = Convert.ToInt32(Console.ReadLine());
         if (guessVer.userInput == guessVer.randomNumber)
         {
            Console.WriteLine($"Вы угадали число {guessVer.randomNumber} за {guessVer.guesses} попыток");
            break;
         }
         else if (guessVer.userInput < guessVer.randomNumber)
         {
            Console.WriteLine("Загаданное число больше.");
            guessVer.guesses += 1;
            //guessVer.userInput = Convert.ToInt32(Console.ReadLine());
         }
         else
         {
            Console.WriteLine("Загаданное число меньше.");
            guessVer.guesses += 1;
            //guessVer.userInput = Convert.ToInt32(Console.ReadLine());
         }
      }
      while (guessVer.userInput != guessVer.randomNumber);
   }
}