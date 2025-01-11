[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
Hw1 lecture 2 in class activity:
How would you describe this game world in objects
The game world consist of these objects:
UI
Player
Plant
Background
camera
What attributes and actions do these objects have?
UI: 
calculating the amount of seeds
Calculating how many seeds are planted/remains
Player
Movement: up/w,down/s,left/a,right/d
Space: Planting the seed
Plant:
Stays on spot and demonstrates its existence in the rapidly-adapting game world of unity. Wondering the meaning of it’s own life, perhaps the only reason for it to exist is to entertain the watchers of the beyond.
How do these objects act on or affect each other?
The player’s current position affects where the seed is planted
The number of seed objects in the scene affects what is displayed on the UI

Devlog for hw 1
The activity we did with my friends in class influenced on how I built on codes. It has not much differences, with the UI, Player, Plant and background are all present, and that plants will not be on the screen unless the player click "space". The player used the player script for moving and planting. while plantcount ui only used to show how many seeds left. In the PlantCountUI script, I imputed the Updateseeds as apart of the class, and what it will do is that it will update the UI on the screen, thereby telling the player how many seeds are left each time they plant a seed. Then, in the Player script, the movement of the player binded with wasd key, when its horizontal, press ad, and when player want to move vertical, player press ws. In the Vector3move, the x and y are horizontal and vertical input, but the z is 0 becuase this is a 2D game. And when player press space, the "if (Input.GetKeyDown(KeyCode.Space))" will then trigger to plant a seed on the screen. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
https://ghostpixxells.itch.io/pixelfood