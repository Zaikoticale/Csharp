// See https://aka.ms/new-console-template for more information

string[] games  = new string[7]{
    "PlayStation",
    "Xbox",
    "Nintendo",
    "Sega",
    "Atari",
    "NeoGeo",
    "GameCube"
};
bool run= true;

for (int i = 0; i<games.Length && run; i++)
{
    Console.WriteLine(games[i]);
}