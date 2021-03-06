# Unity-procedural-project

My project is a dynamic audio visualiser. The goal was to create a dyanamic and variable systems that would allow players to create a new visualiser every time they play. I wanted to add some light elements of interaction so players would feel a little more invested in creating the visualiser each time. 

When the player begins, a giant checkerboard canvas is generated. The player must find "Seed generators": These are objects in the level that, when clicked, disperse "Seeds", rigidbody cubes with random HSV colours attatched to them. Once the seeds touch the ground, the floor at that spot will change to the colour of that same seed, and then grow. The size the cube will grow to is dependant on particular hue value it has been assigned from its seed, and the colour of the cube also determines what band of frequencies of the song that will be represented on that cube. For instance any cube that is red will move in time with lower frequencies. I created some flying creatures that move in a sin wave motion while following a randomly generated path above the level, to add a bit of flair.

The AudioAnalyser, tailAnimator and FPScontroller scripts are taken directly from GE1 examples. Every other script is original work or takes code from examples and heavily modifies it, inlcuding the scripts that generates the floor, all behaviour with seed spawners and seeds, and their interactions with floor tiles, the script for the head movement of the flying creature and its pathfinding throughout the level, as well as changing its colour. I also had to heavily modify the original audio visualiser example code from class so it would pass in the right values to each new block created.

I am most proud of how the overall effect looks after enough seeds have fallen, since cubes pulsating at the same frequencies have both the same size and colour, its easy to see them together in the scene so the it feels very cohesive.

[![YouTube](http://img.youtube.com/vi/ALuans6N6X0/0.jpg)](https://www.youtube.com/watch?v=ALuans6N6X0)
