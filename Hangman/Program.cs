
namespace Hangman
{
    class MainProgram
    {
        static async Task Main(string[] args)
        { 
            await start();
        }

        public static async Task start()
        {
            Console.WriteLine("enter word length");
            int wordLength = Convert.ToInt32(Console.ReadLine());
            Game game = new Game(wordLength);
            var finished = await game.startGame();

        }
    }
}