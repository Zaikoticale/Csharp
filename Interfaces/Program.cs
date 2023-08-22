using System;

public class Program
{
    public static void Main(string[] args)
    {
        Shark[] sharks = new Shark[]
        {
            new Shark("Tiburoncin", 56),
            new Shark("Tiburonzon", 40)
        };


        IFish[] fish = new IFish[]
        {
            new Siren(40),
            new Shark("Tiburoncin",100)
        };

        ShowFish(sharks);
        ShowAnimal(sharks);
        ShowFish(fish);

    }

    public static void ShowAnimal(IAnimal[] animals)
    {
        Console.WriteLine("-- Mostramos los Animales --");
        int i = 0;
        while (i < animals.Length)
        {
            Console.WriteLine(animals[i].Name);
            i++;
        }
    }

    public static void ShowFish(IFish[] fish)
    {
        Console.WriteLine("-- Mostramos los Peces --");
        int i = 0;
        while (i < fish.Length)
        {
            Console.WriteLine(fish[i].Swim());
            i++;
        }
    }
}

public class Siren : IFish
{
    public int Speed { get; set; }

    public Siren (int speed)
    {
        this.Speed = speed;
    }

    public string Swim()
    {
        return $"La Sirena nada a {Speed} km/h";
    }
}

public class Shark : IAnimal, IFish
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Shark(string name, int speed)
    {
        this.Name = name;
        this.Speed = speed;
    }

    public string Swim()
    {
        return $"{Name} nada a {Speed} km/h";
    }
}

public interface IAnimal
{
    string Name { get; set; }
}

public interface IFish
{
    int Speed { get; set; }
    string Swim();
}
