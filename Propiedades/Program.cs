// See https://aka.ms/new-console-template for more information

class Program
{
   static void Main(string[] args)
{
    Sale mySale = new Sale(100, DateTime.Now);
        Console.WriteLine(mySale.Date);

}
}


class Sale
{
    private int total;
    private DateTime date;

    public string Date
    {
        get{
            return date.ToLongDateString();
        }
    }

    public int Total
    {
        get
        {
            return total;
        }
        set
        {
            if (value < 0)
                value = 0;
            total = value;
        }
    }

    public Sale(int total, DateTime date)// Este es un constructor
    {
        this.total = total;
        this.date = date;
          
    }
}