// See https://aka.ms/new-console-template for more information

int k = 0;

while(k < 10)
{
    Console.WriteLine("Iteracion de k "+k);
    k++;
};

int j = 0;
while (j < 100)
{
    if (j > 2)
        break;


    Console.WriteLine("Iteracaion de J " + j);
    j++;
}


string[] friends = new string[7]{
    "pacho",
    "paco",
    "ana",
    "ruben",
    "karla",
    "luis",
    "hector"
};

int index = 0;
while (index < friends.Length)
{
    Console.WriteLine(friends[index]);
    index++;
}


bool run = false;
do
{
    Console.WriteLine("Entra una vez y ya");
} while (run);


static void show()
{
    Console.WriteLine("Entro un vez y ya");
}