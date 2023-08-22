// See https://aka.ms/new-console-template for more informatio111n

class Program {
    static void Main(string[] args) { 

    People people1 = new People()
    {
        Name = "ytrewq",
        Age = 43
    };


        People people2 = new People()
        {
            Name = "qwerty",
            Age = 34
        };

        Console.WriteLine(People.GetCount());
    }

    public class People
    {
        public static int Count = 0;

        public string Name { get; set; }

        public int Age { get; set; }

        public People()
        {
            Count++;
        }

        public static string GetCount()
        {
            return $"Esta clase se ha utilizado {Count} veces";
        }
    }
}