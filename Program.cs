using games.Games;
using games.Logic;

GuessGame guessGame = new GuessGame();
GuessLogic guessLogic = new GuessLogic();
//GuessVariables guessVar = new GuessVariables();

GameStart();


void GameStart()
{
    int globalInput;
    Console.WriteLine("Добро пожаловать в All in One Games!");
    Console.WriteLine("Выберите тип игры (1 - Угадайка) :");
    globalInput = Convert.ToInt32(Console.ReadLine());
    if (globalInput == 1)
    {
        guessGame.Start();
        for (int i = 0; i < 999; i++)
        {
            guessLogic.GameLogic();
        }
    }
}