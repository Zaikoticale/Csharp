// See https://aka.ms/new-console-template for more information

class Program { 

    static void Main(string[] args)
      {
        Doctor doctor1 = new Doctor("Juan", 40, "cardiologo");
        Console.WriteLine(doctor1.GetInfo());
        Console.WriteLine(doctor1.GetData());

        Dev dev1 = new Dev("Alejandro", 19, "C#");
        Console.WriteLine(dev1.GetInfo());
        Console.WriteLine(dev1.GetData());
    }

    class People
    {
        private string _name; // cuando tiene el _ por lo general se ve cuando es privado
        private int _age;

        public People(string name, int age) //constructor padre
        {
            _name = name;
            _age = age;
        }

        public string GetInfo()
        {
            return "Su nombre es: "+_name + " "+"Su edad es: "+_age;
        }
    }

    class Doctor : People
    {
        private string _speciality;

        public Doctor(string name, int age, string speciality) : base(name, age) //esto recibe la informacmacion del constructor padre
        {
            _speciality = speciality;
        }

        public string GetData()
        {
            return GetInfo() + " " + _speciality;
        }
    }

    class Dev : People
    {
        private string _language;

        public Dev(string name, int age, string language) : base(name, age) //esto recibe la informacmacion del constructor padre
        {
            _language = language;
        }

        public string GetData()
        {
            return GetInfo() + " " + _language;
        }
    }
}