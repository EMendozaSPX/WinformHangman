Written in C# using the Monogame/Xna Framework and classes originally written by CodingMadeEasy

29/07/18
Created a new class called CustomImage, designed to make image objects to draw onto the screen
After compilation received error -
System.NullReferenceException: 'Object reference not set to an instance of an object.'
content.Unload() in customimage class
content was null.
The object should have existed, so i will create a new branch, delete the customimage class and use another method to load images
