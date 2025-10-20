# Game Design Document (Devcon 1, Rapid Prototype 2)

## Desired Game Mechanic
The desired game mechanic for this rapid prototype is the ability to teleport a tile or two in front of where you are currently standing. This mechanic would be used in a 2D top-down game (Think Zelda), and the enemy the player faces will be completely invincible from the front, but vulnerable from the back. The player will have to teleport behind the enemy to damage it.

## Objective Statement
Is it satisfying to avoid projectiles and then teleport behind an enemy at the right time?

## Intended Experience
The intended experience is for the player to "line up" the character so that they can teleport behind the enemy, invoking timing, strategy and excitement. This mechanic is unique because instead of the normal gameplay loop of running up and hitting an enemy, this mechanic adds an extra step to dealing damage, causing the player to rethink their strategy.

## Design Rationale
This mechanic would be found in a dungeon, which would be one area in a larger open world. There would be multiple dungeons, probably around eight or nine, each with a new unlockable ability required to reach the next dungeon. The ability in the prototype's dungeon is, of course, the teleporting. What makes this mechanic unique is the fact that the player needs to be thinking about where they are in relation to the enemy to line up the teleport correctly, instead of just walking up and hitting it. It also allows for many different uses of this mechanic, like teleporting to solve puzzles or fighting tougher enemies that have different weak points and timing.

## The Enemy
The only enemy in the prototype is a monster that has complete protection on it's front side. it moves side-to-side in a very simple pattern, and every couple of seconds it spits out three projectiles that slowly spread out. If the player gets hit by a projectile, it's game over. 
[RapidPrototype2_Art1.pdf](https://mohawkcollege365.sharepoint.com/:b:/r/sites/NexGenStudiosGAME10016DigitalPrototypeDevelopmentcopy2-Team11/Shared%20Documents/Team%2011/RapidPrototype2_Art1.pdf?csf=1&web=1&e=cdqD9A)
[RapidPrototype2_Art2.pdf](https://mohawkcollege365.sharepoint.com/:b:/r/sites/NexGenStudiosGAME10016DigitalPrototypeDevelopmentcopy2-Team11/Shared%20Documents/Team%2011/RapidPrototype2_Art2.pdf?csf=1&web=1&e=S8l8Ck)

## 1. GDD Section: Specification

- **1.1 Concept**
The concept of the greater game surrounding our prototype would be an experience where the player would be constantly unlocking new, more powerful spells to help defeat unique enemies that require said spells.

- **1.2 Setting**
The game would be set in a fantasy setting, like Lord of the Rings.

- **1.3 Game Structure**
The game would be in an open world, with around eight dungeons for the player to complete. Each dungeon would contain a new spell to unlock (example: teleporting). The player would be able to tackle the dungeons in any order they want. After all eight dungeons are complete and all spells unlocked, the final area would be open: requiring the player to use every spell to complete.

- **1.4 Players**
The game would be single player only.

- **1.5 Actions**
The player would be able to move around using WASD or arrow keys, and would be able to change the direction the character is facing using a mouse. There would be a dedicated button for attacking and another for using a spell. The player would cycle through spells with number keys or the scroll wheel.

## Citations
#### Guides
"2D look at mouse position." *Unity Discussions*, Sep. 2014, https://discussions.unity.com/t/2d-look-at-mouse-position-z-rotation-c/117860/2

"Cooldown Timers." *Unity Scripting*, https://unityscripting.com/cooldown-timers/

"Instantiate Projectiles and Explosions." *Unity Documentation*, https://docs.unity3d.com/6000.0/Documentation/Manual/instantiating-prefabs-projectiles.html
