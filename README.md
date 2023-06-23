# Project Gunboat(WORK IN PROGRESS) 🏴‍☠️🦜
 Simple 3D made Unity game that involves an arcade naval combat.
 
# Dev Diary 1: Creating the water mechanic and the movement of the ship
So, what will the players see the most when they play a naval combat game? Yes, water, so it is very important to offer a good looking and interactive water.
For doing so I created a WaterManager script that focus on this matter, and it interacts well with the ships, also i used a water shader from the asset store of unity for making the water interactive with light and, overrall, it looks much better than mine 😅.
The second thing i wanted to make is the movement, the idea is to allow the player to move only up and down at certain velocity, making a limit around the tile of the water, it was archived in the script PlayerMovement.
![image](https://github.com/rubensysoecho/project-gunboat-unity/assets/95583458/275d5e6b-0e01-4254-828c-31befa482ba6)

# Dev Diary 2: Cannon and cannonballs ⚔🔥
Now that we have the movement, creating the script Shooting does generate a cannonball prefab and throws it forward, also, when the cannonball impacts the boat, the force can make the boat rotate, that would be a problem for the movement, i've solved this freezing the position of the boat in Z and increasing the size of the collider till it contains the boat with a minimum space outside.
After this, we handle the impact with the PlayerController script, and many other things, like particles and sound.
![image](https://github.com/rubensysoecho/project-gunboat-unity/assets/95583458/26a9b9b7-8a01-4cee-a034-649d9aec5755)
![image](https://github.com/rubensysoecho/project-gunboat-unity/assets/95583458/3230ba14-1407-4fcf-8073-4c11f136d99b)



