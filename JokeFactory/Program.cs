using System;
string asciiBot = @"
[ ]
(o o)
---| |---
|_|
";
Console.WriteLine(asciiBot);
Console.WriteLine("BEEP BOOP. I AM JokeFactory 3000.");
Console.WriteLine("-----------------------------");

string[,] jokesDatabase = new string[3, 3]
{
{
"Why do programmers prefer dark mode? Because light attracts bugs.",
"How many programmers does it take to change a light bulb? None, that's a hardware problem.",
"There are 10 types of people in the world: those who understand binary, and those who don't."
},
{
"I'm reading a book on anti-gravity. I just can't put it down.",
"Hi Hungry, I'm Dad.",
"What do you call a fake noodle? An impasta."
},
{
"What do you call a bear with no teeth? A gummy bear.",
"Why don't scientists trust atoms? Because they make up everything!",
"What do you get from a pampered cow? Spoiled milk."
}
};


Console.Read();
