CSCI 4168 Final Project

Horizon
Created by: Jason Parsons

This is a game being created in Unity3D as the final project for CSCI 4168 (Game Design and Development). Horizon is a combination of 3D and 2D game designs. The 3D portions are meant to be an arcade style shmup set in 3D. These space shooter sequences are broken up by 2D sections set aboard a variety of space stations. These stations contain an array of NPC characters to converse with. These conversations allow for player choice, and will allow for a deeper narrative to what would ordinarily be a straightforward action game.

The project began in the last two weeks of October, and is due on December 5th of this year. Thus, the project in its current state is a work in progress. This README file will be updated accordingly as each phas of the project progresses.

Current state:

The game has all three levels, as well as cutscenes, a prologue, and an ending screen. The ship, enemy, and station models are all imported into the project and are present in the game. However, the combat isn't finished and will need more time to complete beyond the scope of the class project. This work will be carried out in the weeks and months to come. The 2D station scenes are not complete as of yet, and have text based cutscenes as placeholders for now to relay story to the player.

The game has a complete game play loop that takes you from the title screen, to a prologue, to the first level, to the first cutscene and so on until all three levels are complete and the user is shown the game ending screen. Some of these screens have intentional pauses put in for dramatic effect, so please be patient while playing the game.

Current issues:

Object pooling has been implemented, but needs more refinement. Firing by both player and enemies is a work in progress. Currently the player can fire one shot, and the enemies none.

Codebase note:

The object pooling occurs in the script Main.cs which is attached to the main camera in each of the three action levels if you are looking for this specifically. This script also spawns the starfield that populates each of these levels.

Current game controls:

To control the ship, the following commands are currently in place.

Up Arrow: Moves the ship and camera forward
Down Arrow: Moves the ship and camera in reverse
W Key: Moves the camera up
S Key: Moves the camera down
A Key: Rotates the ship and camera left
D Key: Rotates the ship and camera right
Space Bar: Fires primary weapon