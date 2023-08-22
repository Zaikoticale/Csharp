using System;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> numbers = new MyList<int>(10);
        numbers.Add(10);
        numbers.Add(6);

        MyList<string> strings = new MyList<string>(10);
        strings.Add("Alejandro vega");

        MyList<People> people = new MyList<People>(10);
        people.Add(new People() { Name = "Santiago", Country = "Colombia", Age = "19" }) ;
        people.Add(new People() { Name = "juan", Country = "Argentina",Age = "19" });


        Console.WriteLine(numbers.GetString());
        Console.WriteLine(strings.GetString());
        Console.WriteLine(people.GetString());


        Console.WriteLine(numbers.GetElement(11));
        Console.WriteLine(strings.GetElement(0));
    }
}


public class People 
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string Age { get; set; }
 
    public override string ToString()
    {
        return $"Nombre: {Name}, Pais: {Country} su edad es: {Age}";
    }
}


public class MyList<Generico>
{
    private Generico[] _elements;
    private int _index = 0;

    public MyList(int n)
    {
        _elements = new Generico[n];
    }

    public void Add(Generico e)
    {
        if (_index < _elements.Length)
        {
            _elements[_index] = e;
            _index++;
        }
    }
    public Generico GetElement(int i)
    {
        if(i < _index && i >= 0)
        {
            return _elements[i];
        }

        return default(Generico);

    }

    public string GetString()
    { 
        int i = 0;
        string result = "";
        while (i < _index)
        {
            result += _elements[i].ToString() + "|";
            i++;
        }
        return result;
    }
}

