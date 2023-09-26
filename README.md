# Hopeless

![Screenshot](screenshot.png)

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
| `BallControl.cs`      | Controls the behavior of a ball, including its initial launch and how it interacts with player objects.  |
| `GameManager.cs`      | Manages the scores of two players in a game, updates the UI to display the scores, and checks for a win condition where a player reaches a score of 20 to trigger a scene change to the main menu. |
| `PlayerControls.cs`   | Allows the player object to move up and down within specified bounds using the "moveUp" and "moveDown" keys. The script continuously updates the player's position and velocity based on user input and ensures the player stays within the defined bounds.               |
| `SceneManagement.cs`  | Allows for the switching of game scenes by providing the name of the target scene to the "ChangeScene" method. It also enables the player to exit the game application using the "QuitApp" method.       |
| `SideWall.cs`         | Designed to be attached to side walls and serves for scoring by keeping track of when a ball collides with it, identifies the specific wall that was hit, and updates the player's score accordingly. It also can be used to restart the game by sending a message to the ball object to restart the game, possibly after a brief delay, by invoking the "RestartGame" method defined in the "BallControl" script.                 |


## Contributions

We welcome contributions from the community. If you'd like to contribute to this project, please follow these steps:

1. Fork this repository.
2. Create a new branch with your feature or bug fix.
3. Submit a pull request to the main repository.

## Contact

If you have any questions or suggestions, you can contact us via email at [williamwijaya010803@gmail.com].

Thank you for using Glowing 2D Pong!
