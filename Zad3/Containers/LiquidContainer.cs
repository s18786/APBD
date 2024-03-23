using System;
using System.Globalization;
using Zad3.Interfaces;

namespace Zad3.Containers
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        public LiquidContainer(double height, double mass, double weight,
            double depth, string serialNumber, double maxPayload) : base(height, mass,
            weight, depth, serialNumber, maxPayload)
        {
            Height = height;
            Mass = mass;
            Depth = depth;
            SerialNumber = serialNumber;
            MaxPayload = maxPayload;
        }
    

        public override void Load(double cargoMass)
        {
            if (Cargo > 0) {
                if (cargoMass > MaxPayload * 0.5)
                {
                    Notification(SerialNumber.ToString());
                    throw new System.Exception("Cannot load more than 50% of capacity with hazardous cargo");
                }
            }
            else {
                if (cargoMass > MaxPayload * 0.9) {
                    throw new System.Exception("Dangerous operation - container at 90% capacity");
                }
            }

            base.Load(cargoMass);
        }

        public void Notification(string numberOfContainer) {
            throw new NotImplementedException("Hazardous event at container");
        }
    }
}