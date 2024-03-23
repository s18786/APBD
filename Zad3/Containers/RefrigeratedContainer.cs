using System;

namespace Zad3.Containers
{
    public class RefrigeratedContainer: Container
    {
        public PossibleProducts ProductType { get; set; }
        public double TemperatureNow { get; set; }
        public double TemperatureNeeded { get; set; }

        public RefrigeratedContainer(PossibleProducts productType, double temperatureNow,
            double temperatureNeeded, double height, double mass, double weight,
            double depth, string serialNumber, double maxPayload): base(height, mass,
            weight,depth, serialNumber, maxPayload)
        {
            ProductType = productType;
            TemperatureNow = temperatureNow;
            TemperatureNeeded = temperatureNeeded;
            if (TemperatureNow > temperatureNeeded && temperatureNeeded > 0)
            {
                if (TemperatureNow > TemperatureNeeded + 10)
                {
                    throw new System.Exception(
                        "Error - temperature too high");
                }

                if (TemperatureNeeded < 0 && TemperatureNow > TemperatureNeeded)
                {
                    throw new System.Exception(
                        "Error - temperature too high");
                }
            }

            if (temperatureNow < temperatureNeeded && temperatureNeeded > 0)
            {
                throw new System.Exception(
                    "Error - temperature too low");
            }
        }

        private double GetTemperature(PossibleProducts products)
        {
            switch (products)
            {
                case PossibleProducts.Bananas:
                    return 13.3;
                case PossibleProducts.Chocolate:
                    return 18;
                case PossibleProducts.Fish:
                    return 2;
                case PossibleProducts.Meat:
                    return -15;
                case PossibleProducts.IceCream:
                    return -18;
                case PossibleProducts.FrozenPizza:
                    return -30;
                case PossibleProducts.Cheese:
                    return 7.2;
                case PossibleProducts.Sausages:
                    return 5;
                case PossibleProducts.Butter:
                    return 20.5;
                case PossibleProducts.Eggs:
                    return 19;
                default:
                    throw new System.Exception("Product not listed");
            }
        }

        public void SetTemperature(double temperature)
        {
            if (temperature < TemperatureNeeded)
                throw new System.Exception(
                    "Error - temperature lower than the temperature required by product");
            TemperatureNow = temperature;
        }

    }
}