using System;
using Zad3.Exceptions;
using Zad3.Interfaces;

namespace Zad3.Containers
{
    public class GasContainer : Container, IHazardNotifier
    {
        public double Pressure { get; set; }

        public GasContainer(double height, double mass, double weight,
            double depth, string serialNumber, double maxPayload, double pressure)
            : base(height, mass, weight, depth, serialNumber, maxPayload)
        {
            Pressure = pressure;
        }

        public override void Empty()
        {
            Mass *= 0.05;
        }

        public void Notification(string numberOfContainer)
        {
            throw new HazardException("Hazardous event at container");
        }

        public override void Load(double cargoMass)
        {
            if (cargoMass > MaxPayload)
            {
                throw new OverfillException("Exceeds max payload.");
            }

            base.Load(cargoMass);
        }
    }
}