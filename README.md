Written in C# using the Monogame/Xna Framework and classes originally written by CodingMadeEasy

29/07/18
Created a new class called CustomImage, designed to make image objects to draw onto the screen
After compilation received error -
System.NullReferenceException: 'Object reference not set to an instance of an object.'
content.Unload() in customimage class
content was null.
The object should have existed, so i will create a new branch, delete the customimage class and use another method to load images

01/08/18
Having issues transitioning objects and screen issues, tried a bunch of diffrent ways but nothing seems to be working

05/08/18
In xna there is a method named update that gets called repeatedly every frame, 
I have created a list of resources 'List<Texture2D> textures = {texture1, texture2},
I have a private integer variable 'int index = 0' in my class that gets updated every 3 seconds,
'++index', the draw method is supposed to update after the update method updates drawing that texture, but it is not.
https://gamedev.stackexchange.com/questions/17787/xna-game-loop-update-and-draw

12/08/18
After a week of not making progress on updating texture to draw on screen, I switched libraries from Xna to windows form

