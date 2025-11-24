# Project Milestone 1

## Premise

Apple Waves - You are an apple stuck in a realm of doom, can you escape a seemingly endless volley of saws?

This is a dodge avoidance game with a relatively simple premise, keep the apple away from the dangerous saws. The main mechanic of the game is various attack patterns, which are built on randomly generated vectors. While this iteration of the game is endless, the final is likely going to make use of multiple "waves" with preset attack patterns as well as difficulty scaling. The endgame is either if the player touches a saw or finishes all (hopefully) 10 waves of saws while getting as high of a score as possible.

## Feature List (So Far)

### Gameplay Structure

For now, game operates on an endless game structure, with a preset wave showing off each attack. These waves are dynamic and work off of a coroutine, which triggers other coroutines. This way the obstacles spawn at regular intervals. There is also a restart system implemented using unity's input system and textmesh pro.

### Player Controls

Fully implemented WASD controls for seamless movement.

### Sprites and Animation

Used the Pixel Adventures sprite pack, which has animated saws as well as many creative sprites for a player object.

### Dynamic UI

Scoring UI is functional, with an option to increase score when needed. This will be useful once I begin adding coins/scoring objects, which will likely replace the current time-based system. Restart button is functional as well, though it mostly serves as a control indicator.

### State Management

Restart system is pretty much functional, only triggering when player has lost.

### Scripts/Organization

Used abstract classes for attack types as well as saw types for organization. This way, different types of enemies as well as attack patterns can be implemented later down the line.

## Known Issues

Random command may be flawed - saws may spawn off screen, this is just a matter of knowing the definite vector coordinates of each corner.

AttackManager lacks extension capability - Likely some SOLID principles needed to fully implement the "waves" system; for now, the game only loops a single wave, as it is stuck in a single AttackManager class.

## Next Steps

Waves System - Likely the biggest and most imminent undertaking of the next two weeks, the final goal is to have a series of randomly generated but unique waves which contain certain types of attacks and difficulty scaling.

Difficulty Scaling - Create ways to change the speed and spawn speed of saw prefabs, so the game gets more difficult as you progress.

More Robust UI - Implement a proper restart button, as well as a pause menu that allows for restart capabilities.

Power-Ups System - Should be fairly straightforward to implement, add powerups that change score as well as make player invincible and/or speeds up movement.

Scoring System - Move scoring system from time-based to more object based.

Health System - Possibly add a health counter which provides "I-Frames" to the player when hit.

Difficulty Menu/Options - Likely a stretch for my capabilities, but add a menu which changes difficulty scaling, starting health, and/or obstacle danger.

## How to Play

Simple WASD controls, press any key to go in the direction you want (diagonal is possible). If you hit a saw once, you lose. The current objective of the game is to get the highest score possible, but in future iterations it will be more in depth.