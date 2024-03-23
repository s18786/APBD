using System;
using System.Collections.Generic;
using Zad3.Containers;

namespace Zad3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //LiquidContainer liquidContainer = new LiquidContainer(24, 100, 20, 22, "KON-C-1", 220);
            //GasContainer gasContainer = new GasContainer(18, 100, 30, 22, "KON-C-2", 200, 5);
            RefrigeratedContainer container1 = new RefrigeratedContainer(PossibleProducts.FrozenPizza, 13, -30, 12,
                100, 20, 22, "KON-C-3", 120);
            
            //check if error will sound
            //RefrigeratedContainer container2 = new RefrigeratedContainer(PossibleProducts.FrozenPizza, -30, -30, 12,100, 20, 22, "KON-C-4", 120);
            
            RefrigeratedContainer container3 = new RefrigeratedContainer(PossibleProducts.Butter, 20.6, 20.5, 10, 10, 20, 22,
                "KON-C-5", 50);

            Ship ship = new Ship(30, 100, 4000, PossibleProducts.Meat, -15,
                -15, 40,100,27,40,"K0N-C-6", 200);



            ship.LoadContainerIntoShip(new List<RefrigeratedContainer> { container1, container3 });
            ship.PrintInfoShip();
            ship.UnloadContainer(container1);
            ship.PrintInfoShip();
            RefrigeratedContainer newContainer = new RefrigeratedContainer(PossibleProducts.Meat, -15, -15, 10, 20, 10, 15, "KON-C-5", 30);
            ship.ReplaceContainerWithGivenNumber(container3, newContainer);
            ship.PrintInfoShip();
            Ship ship2 = new Ship(30, 100, 4000, PossibleProducts.Sausages, 5,
                5, 40,100,27,40,"K0N-C-7", 200);
            Ship.TransferBetweenTwoShips(ship, ship2, newContainer);
            Console.WriteLine("Information ship1: ");
            ship.PrintInfoShip();
            Console.WriteLine("\nInformation ship2: ");
            ship2.PrintInfoShip();
        }
    }
}