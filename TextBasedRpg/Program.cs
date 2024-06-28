using Introduction=TextBasedRpg.Introduction;

Console.WriteLine("Welcome to Eldoria, brave adventurer! What is your name?");
string name = Console.ReadLine();
Introduction story=new Introduction(name);
story.Story();