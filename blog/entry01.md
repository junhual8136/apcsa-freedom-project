# Entry 1
##### X/X/XX

### Content

I decided to choose the tool godot to make a 2d game where you try and get up things. I also want to learn how to use a game engine and learn a different coding language this year. I chose to use C# over GDscript because C# is more useful in the future and it's similar to Java.

Because I chose to use godot with C#, I had to learn the basics of C# first. Since C# is extremely similar to Java, I decided to skim through the [C# documentation](https://www.w3schools.com/cs/index.php) and learn the basics through a simple project with [Rider](https://www.jetbrains.com/rider/) where I create a hangman terminal game which covers loops, conditionals, api requests and other basic concepts. 

```c#
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
```
[full code](../Hangman/Game.cs)


While for godot, I started to learn how to create sprites, collisons and attach scripts to nodes through a [video](https://www.youtube.com/watch?v=5V9f3MT86M8). I then applied it to create my own character node which contains a sprite with animations, collision hitboxes, and a camera that is centered on the sprite.

<img width="258" alt="Screenshot 2024-10-27 at 11 02 40 PM" src="https://github.com/user-attachments/assets/0900c81d-9e90-4888-b274-a06ea583f150">

### EDP

I am on step 1 and 2 of the Engineering Design process where I chose what I wanted to make (climbing game) and researching throught watching [tutorials](ttps://www.youtube.com/watch?v=5V9f3MT86M8) and reading [Documentation](https://www.w3schools.com/cs/index.php) to learn the godot game engine and c#. Which led me to create a console game to learn c# and a character node as a start for my game. My next step is brainstorming possible solutions through learning what each node does and how I can combine multiple sub nodes to create a component for my game.

### Skills

While learning and tinkering with Godot and C#, I had developed How to Google and organization. While trying to learn C#, I had trouble setting up the dontnet console app with vscode. This led to me finding alternative IDEs and found out that Jetbrains recently made Rider and Webstorm free for non-commercial use. With Rider, running and debugging C# was made easier. My organization improved with through Godot. Game development with Godot uses nodes with contain subnodes and scripts which led meant I had to organize each sub node until one another to make a functioning node for each part of my game.

[Next](entry02.md)

[Home](../README.md)
