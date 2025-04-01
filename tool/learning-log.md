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

### 12/1/24
basic godot implentation to get the mouse clicked location
```c#
public override void _Input(InputEvent @event)
{
    if (@event is InputEventMouseButton eventMouseButton)
        GD.Print("Mouse Click/Unclick at: ", eventMouseButton.Position);
    else if (@event is InputEventMouseMotion eventMouseMotion)
        GD.Print("Mouse Motion at: ", eventMouseMotion.Position);

}
```
* I used this to check to make sure that the player is at least near the object before they can click it
```c#
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

12/8/24
* Learned a new way to make game buttons and HUDs through the control node which as properties such as button and label, you can add a script to it for it to perform something when the buttons are pressed

<img width="1461" alt="Screenshot 2024-12-08 at 12 27 32 PM" src="https://github.com/user-attachments/assets/b7d60d98-a9f9-4e68-b096-a0144d23b012">

12/11/24
* I learned how to add a script to the Buttons and UI
* ```c#
  public partial class MyUIScript : Control
{
private Label labelNode;
private Button buttonNode;
```c#
    public override void _Ready()
    {
        buttonNode.Connect("pressed", this, nameof(_OnButtonPressed));
    }

    private void _OnButtonPressed()
    {
        labelNode.Text = "Button clicked!";
    }
}

```

12/20/24
* I did some testing with running sprite animations.
```c#
using Godot;

public partial class Sprite2D : Node2D
{
    [Export]
    public Texture2D SpriteSheet;

    [Export]
    public Vector2 FrameSize;

    private int _currentFrame;
    private float _animationTimer;
    private float _frameRate = 10f; 

    public override void _Process(double delta)
    {
        _animationTimer += (float)delta;

        if (_animationTimer >= 1f / _frameRate)
        {
            _animationTimer = 0f;
            _currentFrame = (_currentFrame + 1) % (SpriteSheet.GetWidth() / FrameSize.x);

            var frameRect = new Rect2(_currentFrame * FrameSize.x, 0, FrameSize.x, FrameSize.y);
            TextureRegion region = new TextureRegion(SpriteSheet, frameRect);
            this.Texture = region;
        }
    }
}


```
1/12/25
* Tested different sprite animations with godot 


2/4/25
* watched [a menu tutorial](https://www.youtube.com/watch?v=vsKxB66_ngw)
* Learned that the 2d plane is centered and I had to move all my buttons into the middle
* boilerplate code generated by godot:
 ```c#
public class MyButton : Button
{
public override void _Ready()
{
  Pressed += OnButtonPressed;
}

private void OnButtonPressed() {
  Scene.load("main");
}
}
```

3/2/25
starting working on the player sprite and added control/player movement and spawn location
```
using Godot;
public partial class Player : CharacterBody2D
{
    public override void _Ready()
    {
        Position = new Vector2(0, 0);  
    }

    public override void _PhysicsProcess(double delta)
    {
        Vector2 velocity = Vector2.Zero;

        if (Input.IsActionPressed("move_right"))
            velocity.X += 1;
        if (Input.IsActionPressed("move_left"))
            velocity.X -= 1;
        if (Input.IsActionPressed("move_down"))
            velocity.Y += 1;
        if (Input.IsActionPressed("move_up"))
            velocity.Y -= 1;
    }
}
```

3/30/25
* Figured out how to use the godot physics engine through (the documentation)[https://docs.godotengine.org/en/stable/tutorials/physics/physics_introduction.html]
* through the use of a rigidBody2D or a characterBody2D node, I can attach the script
* Also found out you can just create getters and setters for primtiives in objects by just adding {get; set;} after the name in c#
* `IsOnFloor()` checks if the player/character node is standing on something solid for the gravity to not pull the player further down
  ```c#
 using Godot;

public partial class Player : CharacterBody2D
{
    private float Gravity { get; set; } = 980.0f;

    private Vector2 velocity = 100;

    public override void _PhysicsProcess(double delta) {
        if (!IsOnFloor()) {
            velocity.Y += Gravity * (float)delta;
        }
        else {
            velocity.Y = 0; // Reset vertical velocity when on the ground
        }

      
    }
}
  ```



<!--
* Links you used today (websites, videos, etc)![Uploading Screenshot 2024-12-08 at 12.27.32 PM.png…]()

* Things you tried, progress you made, etc
* Challenges, a-ha moments, etc
* Questions you still have
* What you're going to try next
-->




