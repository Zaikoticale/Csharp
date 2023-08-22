// See https://aka.ms/new-console-template for more information
//La clase la usamos para crear objetos
//Public hace referencia a acceder al objeto si es privado solo se puede acceder en su propia clase
class Program { 
   static void Main(string[] args)
    {
        Sale sale1 = new Sale(100, DateTime.Now);
        Sale sale2 = new Sale(200, DateTime.Now);
        Console.WriteLine(sale1.GetInfo());
        Console.WriteLine(sale2.GetInfo());


    }
}


class Sale
{
    int total;
    DateTime date;

    public Sale(int total, DateTime date)// Este es un constructor
    {
        this.total = total;
        this.date = date;

    }


    public string GetInfo() 
    {
        return total + " " + date.ToLongDateString();
    }


     public void show() //Mala practica
    {
        Console.WriteLine("Hola soy una venta");
    }
}