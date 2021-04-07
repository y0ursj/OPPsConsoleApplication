using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Drink
    {
        public string Name;
        public string Carbonated;
        public string Description;

    }

    public class Juice : Drink 
    {
        public string FruitType;

    }

    public class Beer : Drink
    {
        public string AlcoholContent; 
    }


    public class Soda : Drink
    {

    }

   class Program
    {
        static void Main(string[] args)
        {
         
            var drinkList = new List<Drink>();
            drinkList.Add(new Juice() { Name = "Sunkist", Carbonated = "Not Carbonated", Description = "Healthy Orange Drink", FruitType = "Made From Oranges"});
            drinkList.Add(new Soda() { Name = "Pepsi", Carbonated = "Not Carbonated", Description = "Healthy Orange Drink" });
            drinkList.Add(new Beer() { Name = "Coors Lite", Carbonated = "Carbonated", Description = "Mountain Fresh Beer", AlcoholContent = "5%" });

            foreach (var drink in drinkList)
            {
            Console.WriteLine("{0} {1} {2} {3} {4}", drink.Name, drink.Carbonated, drink.Description, (drink as Juice)?.FruitType, (drink as Beer)?.AlcoholContent);
        }
           
           
            Console.ReadLine();
        }

    }

