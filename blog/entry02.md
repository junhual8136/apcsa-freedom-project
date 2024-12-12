# Entry 2
##### 12/12/2024

### Content
I've been learning my tool Godot alongside C# for the past month. I started out with the basics of C# and by looking at the C# documentation which was mentioned in the previous blog. 
I watched a [walkthrough](https://www.youtube.com/watch?v=LOhfqjmasi0) to get the basics of how to do everything. I also went through the godot [documentation](https://docs.godotengine.org/en/3.0/getting_started/step_by_step/ui_main_menu.html) and learned a few things such as:

Rendering text:
```c#
 using Godot;

public class ScoreManager : Node
{
    private Label scoreText;
    private int score = 0;

    public override void _Ready()
    {
        scoreText = GetNode<Label>("game/node2d");
        UpdateScore();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    public void UpdateScore()
    {
       scoreText.Text = $"Score: {_score}";
    }
}
```
When this is attached the a label node, it is possible to edit through the updateScore() method.

I also used `_Input(IntputEvent @event)` to a control node in order to get input and do something with that input such as clicking or pressing `w`
```C#
public override void _Input(InputEvent @event) {
        if (@event is InputEventMouseButton mouseEvent) {
            if (mouseEvent.Pressed && mouseEvent.ButtonIndex == (int)ButtonList.Left) {
                Vector2 clickPosition = mouseEvent.Position;
                if (clickPosition.y == player.position.y) {
                     if (clickPosition.x - 10 > player.position.x || clickPosition + 10 < player.position.x) {
                           // object click thing, i have not created any function when clicked
                     }
                }
            }
        }
    }
```
In my winter break, I want to start creating the basics of my game such as creating a moveable player and a few platforms.


### EDP
I am currently on step 3 of the engineering design process where I'm learning c# and Godot to find out how to create the game through watching [walkthroughs](https://www.youtube.com/watch?v=LOhfqjmasi0)
 and reading [documentation](https://docs.godotengine.org/en/3.0/getting_started/step_by_step/ui_main_menu.html) to learn the methods and nodes relevant to my project. My next step is to plan the most possible solution through creating a proper node tree that would connect all the components on my game together.

### Skills
I developed some new skills such as debugging and How to read throughout the process of learning Godot. For debugging, I used the Rider IDE which recently became free and has a built in debugger which made it easier to identity most of the problems before compiling. I had to debug a lot of code inside Godot methods such as trying to find out what type an API request call is in C#.
```c#
 string response = await _client.GetAsync(url);
```
This returned an error because the response did not return an string. I ended up using `var` which has auto type inference in `C#`.

I also learned how to read the Godot documentation which gives examples and expects you to figure out how to implement your code based on what  you can infer in the example.
```c#
public override void _Input(InputEvent @event)
{
    if (@event is InputEventMouseButton eventMouseButton)
        GD.Print("Mouse Click/Unclick at: ", eventMouseButton.Position);
    else if (@event is InputEventMouseMotion eventMouseMotion)
        GD.Print("Mouse Motion at: ", eventMouseMotion.Position);

}
```
This was the example provided by godot on how to take in mouse inputs.
I ended up replacing the code inside the `if` statements.






[Previous](entry01.md) | [Next](entry03.md)

[Home](../README.md)