// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Poker",
                Brand = "Bavaria"
            };
            // string json = "{\"Name\":\"Poker\",\"Brand\":\"Bavaria\"}";
            string json = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);

            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                Name = "Poker",
                Brand = "Bavaria"
                },
                new Beer()
                {
                    Name="Aguila",
                    Brand="Marca"
                }
            };

            //    string json2 = "[" +
            //        "{\"Name\":\"Poker\",\"Brand\":\"Bavaria\"}," +
            //        "{\"Name\":\"Aguila\",\"Brand\":\"Marca\"}" +
            //        "]";

            string json2 = JsonSerializer.Serialize(beers);
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }
    }
}
