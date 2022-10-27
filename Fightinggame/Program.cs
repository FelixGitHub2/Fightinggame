
Console.WriteLine("Press Enter To TEST YOUR MIGHT");

Console.ReadLine();


int playerhp = 100;
int enemyhp = 100;

Console.WriteLine("You're name is?");

string playername; 
playername = Console.ReadLine();
 
Console.WriteLine($"Welcome to hell {playername}");

Console.WriteLine("Who will be your opponent?");
string enemyname;
enemyname = Console.ReadLine();

Console.WriteLine($"{playername} VS {enemyname}");

Console.ReadLine();


Random generator = new Random();

while (playerhp > 0 && enemyhp > 0)
{
    Console.WriteLine("New Round");
    Console.WriteLine("START");
    Console.WriteLine($"{playername} has {playerhp} hp left. {enemyname} has {enemyhp} hp left");

    int playerdmg = generator.Next(10);
    enemyhp -= playerdmg;
    enemyhp = Math.Max(0, playerhp);
    Console.WriteLine($"{playername} does {playerdmg} to {enemyname}");

    int enemydmg = generator.Next(10);
    playerhp -= enemydmg;
    playerhp = Math.Max(0, playerhp);
    Console.WriteLine($"{enemyname} does {enemydmg} to {playername}");

    Console.WriteLine("Press Enter to continue");
    Console.ReadKey();
}

Console.WriteLine("The Carnage Is Complete");

if (playerhp == 0 && enemyhp == 0)
{
    Console.WriteLine("Draw bruh");
}
else if (playerhp == 0)
{
    Console.WriteLine($"{enemyname} won");
}
else
{
    Console.WriteLine($"{playername} won");
}

Console.WriteLine("Press Enter to end");
Console.ReadKey();
