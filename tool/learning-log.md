# Tool Learning Log

## Tool: Godot

## Project: Endless platformer

---

### 10/19/24:
* Installed Godot
* Installed .net SDK
* skimmed through [C# documentation](https://www.w3schools.com/cs/index.php)
    * It seems like it's very similar to Java with some slight differences like `Console.WriteLine()` instead of `System.out.println()` or `namespace` instead of `package`
    * Both Java and C# have the same OOP concepts

### 10/25/24:
* <img width="258" alt="Screenshot 2024-10-27 at 11 02 40 PM" src="https://github.com/user-attachments/assets/fd6c234c-245a-441c-a50d-592679d68505">
* Sprite2D creates a sprite with the texture 
* camera will add a camera that is fixed to the Sprite so it's always centered in the screen
* static body 2d adds a hitbox
* Collison polygon 2d creates a collision with tiles

### 11/8/24:
<img width="243" alt="Screenshot 2024-11-08 at 12 19 06 PM" src="https://github.com/user-attachments/assets/19cfcc58-e832-499e-bd62-d2ab5f8ef343">
* Tilemap is used to create individual tiles with certain properties
* creating a tilemap like the one on top will create one tile set level 
   * draging in tiles and selecting the property 
*

```c#
public override void _Ready()
{
    var button = new Button();
    button.Text = "Start";
    button.Pressed += ButtonPressed;
    AddChild(button);
}

private void ButtonPressed()
{
    // load the scene 
}
```
* this should create a button that when pressed, loads the scene when I learn how to.


### 11/17/24
* I watched a full walkthrough [tutorial](https://www.youtube.com/watch?v=LOhfqjmasi0) on how to make a 2d godot game.
* <img width="268" alt="Screenshot 2024-11-17 at 1 05 04 PM" src="https://github.com/user-attachments/assets/4aed67fc-f2b6-4720-9f73-c8cf8f97034b">   
   * I found that you can make a tile animated and move in game by changing the values in the transform section.
* I read the godot [documentation](https://docs.godotengine.org/en/3.0/getting_started/step_by_step/ui_main_menu.html) on how to create menus and made a start menu   
   *

### 11/24/24
* Render text:
  
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
   * _Ready() is automatically called at the start
<!--
* Links you used today (websites, videos, etc)
* Things you tried, progress you made, etc
* Challenges, a-ha moments, etc
* Questions you still have
* What you're going to try next
-->
