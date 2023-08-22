// See https://aka.ms/new-console-template for more information
bool areYouHungry = true; //parametros
bool youHaveMoney = true; //parametros

if (areYouHungry && youHaveMoney && IsOpenRestaurant("TacoBell",11)) { // el && significa que si o si debe cumplir esa condicion en cambio el or || cumpla tenga o no asi sea una falsa
    Console.WriteLine("Come");

}
else
{
    Console.WriteLine("Pues no comas");
}


static bool IsOpenRestaurant(string name, int hour = 0) {
    if (name == "TacoBell" && hour > 8 && hour < 23)
    {
        return true;
    }
    else if(name == "Restaurant 24 horas")
    {
        return true;
    }
   else
    {
        return false;
    }
}
