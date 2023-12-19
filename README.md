# Hopeless

<img width="960" alt="hopeless" src="https://github.com/William3152/Hopeless/assets/116702856/46dffc32-4c92-431b-a21b-0cc797801919">

Hopeless is a platformer game with dark and creepy theme. 
In this game, players must go from the start point to end point while dodging obstacle and unlocking path by solving the puzzle.
One of the exciting features of this game is the dazzling light effects that add a visually captivating element to the gameplay.

## Features

- Platformer game with a dark and creepy theme.
- Single player mode.
- Eerie sound effects and background music.

## Player Control 

Player can use these button to control the paddle on the game 

| Key          | Function          | Description             |
| ------------ | ----------------- | ----------------------- |
| A            | Player Move Left  | Move the player's character to the left direction |
| D            | Player Move Right | Move the player's character to the right direction|
| [Space] Button | Player Jump Move| Move the player's up by making a jump action  |

## Supporting Scripts

These are scripts that used to help run the game.

| Script Name           | Description                                          |
| --------------------- | ---------------------------------------------------- |
| `BucketGravity.cs`    | Simulates the physics of gravity and falling for an object. |
| `GameManager.cs`      | Handles the game management features, such as changing scenes, pausing and resuming the game, managing the player's level, and resetting the level. |
| `PlayerMovement.cs`   | Handles the player's movement, including walking and jumping. It uses a combination of physics-based movement (using the Rigidbody2D component) and scripting-based movement (using the transform.Translate() method). |
| `PlayerPositionHandler.cs`  | Attached to a game object with a trigger collider to handle checkpoint and trap collisions and trigger the corresponding methods. Additionally, this script requires a scriptable object (TransformData) to store the player's position data.       |
| `TriggerEvent.cs`     | Ensures that the player's position is correctly saved and loaded, and the player's position is correctly changed when they collide with checkpoints or traps. |
| `UIGameplay.cs`       | Ensures that the pause and resume functionality of the game is correctly handled, and the user can navigate between different game states using the buttons in the UI. |
| `UIMenu.cs`           | Handles user interface and navigation between different game states are correctly, and the user can easily navigate between the different panels and levels using the buttons in the UI.
| `VerticalMovement.cs` | Move a game object up and down vertically along a sine wave path. The sine wave path can be controlled by setting the distance, speed, and timeStart variables in the Unity editor.

## Contributions

We welcome contributions from the community. If you'd like to contribute to this project, please follow these steps:

1. Fork this repository.
2. Create a new branch with your feature or bug fix.
3. Submit a pull request to the main repository.

## Contact

If you have any questions or suggestions, you can contact us via email at [williamwijaya010803@gmail.com].

Thank you for using Glowing 2D Pong!
