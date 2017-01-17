using System;

class Vegetables
{
    static void Main(string[] args)
    {
        var PriceOfVegetables = double.Parse(Console.ReadLine());
        var PriceOfFruits = double.Parse(Console.ReadLine());
        var QuantytOfVegetables = int.Parse(Console.ReadLine());
        var QuantytyOfFruits = int.Parse(Console.ReadLine());

        var EuroRate = 1.94;

        var Profit = (PriceOfFruits * QuantytyOfFruits +
            PriceOfVegetables * QuantytOfVegetables) / EuroRate;
        Console.WriteLine(Profit);
    }
}

