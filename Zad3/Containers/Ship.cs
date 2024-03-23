using System;
using System.Collections.Generic;

namespace Zad3.Containers
{
    public class Ship: RefrigeratedContainer
    {
        public List<RefrigeratedContainer> Transport { get; set; }
        public double MaxSpeed { get; set; }
        public int MaxContainerNumber { get; set; }
        public double MaxWeight { get; set; }

        public Ship(double maxSpeed, int maxContainerNumber, double maxWeight, PossibleProducts productType, double temperatureNow,
            double temperatureNeeded, double height, double mass, double weight,
            double depth, string serialNumber, double maxPayload): base(productType, temperatureNow, temperatureNeeded,
            height,mass, weight, depth, serialNumber, maxPayload)
        {
            Transport = new List<RefrigeratedContainer>();
            MaxSpeed = maxSpeed;
            MaxContainerNumber = maxContainerNumber;
            MaxWeight = maxWeight;
        }
        
        public void LoadCargoToShip(List<RefrigeratedContainer> container)
        {
            foreach (var cargoload in container)
            {
                if (Transport.Count >= MaxContainerNumber)
                    throw new System.Exception("Error - cannot load more");
                Transport.Add(cargoload);
            }
        }
        
        public void LoadContainerIntoShip(List<RefrigeratedContainer> containers)
        {
            if (containers.Count + Transport.Count > MaxContainerNumber)
                throw new InvalidOperationException("Error - at full capacity");
            Transport.AddRange(containers);
        }
        
        public void UnloadContainer(RefrigeratedContainer container)
        {
            Transport.Remove(container);
        }
        
        public void ReplaceContainerWithGivenNumber(RefrigeratedContainer container1,
            RefrigeratedContainer container2)
        {
            int replace = Transport.IndexOf(container1);
            if (replace != -1)
                Transport[replace] = container2;
            else
                throw new System.Exception("Container does not exist");
        }
        
        public static void TransferBetweenTwoShips(Ship ship1,
            Ship ship2, RefrigeratedContainer container)
        {
            ship1.UnloadContainer(container);
            ship2.LoadCargoToShip(new List<RefrigeratedContainer>
                {
                    container
                }
            );
        }
        
        public void RemoveContainerFromShip(RefrigeratedContainer container)
        {
            UnloadContainer(container);
        }
        
        public void PrintInfoShip()
        {
            Console.WriteLine(" Ship information: Max Speed: " + MaxSpeed +
                              "\n Max Container Number: " + MaxContainerNumber +
                              "\n Max Weight: " + MaxWeight);
            Console.WriteLine("Information about the Containers:");
            foreach (var container in Transport)
            {
                PrintInfoContainer(container);
            }
        }

        public void PrintInfoContainer(RefrigeratedContainer container)
        {
            Console.WriteLine(" Product: "+ container.ProductType +
                              "\n Needed Temperature: " + container.TemperatureNeeded +
                              "\n Current Temperature: " + container.TemperatureNow);
        }
        
        
    }
}