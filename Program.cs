//Greeting adventurer
string greeting = "Greetings Adventurer, what is thine name?";
Console.WriteLine(greeting);

string userName = Console.ReadLine();
string questionName = "So your name is " + userName + ", is that correct? Please answer with yes or no.";
Console.WriteLine(questionName);

string confirmName = Console.ReadLine();
if (confirmName == "yes")
{
    Console.WriteLine("Well then Adventurer " + userName + ", come with me, adventure awaits!");
}
else if (confirmName == "no")
{
    Console.WriteLine("Well then little girl and or boy what do be thine name?");
}
else
{
    Console.WriteLine("Please speak up I'm not wearing my glasses so I can't hear you properly");
}