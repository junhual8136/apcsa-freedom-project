using System.Runtime.CompilerServices;
using System.Linq;
namespace Hangman;

public class Game
{
    string url;
    int length; 
    int left;
    public Game(int length)
    {
        this.url = $"https://random-word-api.herokuapp.com/word?length={length}";
        this.length = length;
        this.left = 7;

    }

    

    public async Task<bool> startGame()
    {
        string word = await Api.Get(this.url);
        word = word.Trim(new char[] { '[', ']', '"' }); 
        
        string[] blanks = new string[word.ToString().Length];
        for (int i = 0; i < this.length; i++)
        {
            blanks[i] = "_";
        }
        // debug
      
        while (true) 
        {
            Console.Clear();
            
            Console.WriteLine(word);
            Console.WriteLine($"you have {this.left} guesses left");

            if (!blanks.Contains("_"))
            {
                Console.WriteLine("You guessed it!");
                return true;
            }

            if (left == 0)
            {
                Console.WriteLine("You failed");
                return true;
            }
            Console.WriteLine(string.Join("", blanks));
            string input = Console.ReadLine();
            if (input.Length != 1)
            {
                Console.WriteLine("Wrong input");
                continue;
            }
            bool guessedCorrect = false;
            for (int i = 0; i < blanks.Length; i++)
            {
                
                if (input.Equals(word[i].ToString()))
                {
                    blanks[i] = input;
                    guessedCorrect = true;
                }
            }

            if (!guessedCorrect) this.left--;
        }
    }
}