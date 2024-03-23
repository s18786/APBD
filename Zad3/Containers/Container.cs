using System;
using Zad3.Exceptions;
using Zad3.Interfaces;

namespace Zad3.Containers
{
    public abstract class Container : IContainers
    {
        public double Cargo { get; set; }
        public double Height { get; set; }
        public double Mass { get; set; }
        public double Weight { get; set; }
        public double Depth { get; set; }
        public string SerialNumber { get; set; }
        public double MaxPayload { get; set; }

        protected Container(double height, double mass, double weight,
            double depth, string serialNumber, double maxPayload)
        {
            Height = height;
            Mass = mass;
            Weight = weight;
            Depth = depth;
            SerialNumber = serialNumber;
            MaxPayload = maxPayload;
        }

        public virtual void Empty()
        {
            Mass = 0;
        }

        public virtual void Load(double cargoMass)
        {
            if (Mass > MaxPayload)
            {
                throw new OverfillException();
            }

            Mass = cargoMass;
        }


        public void UnLoad()
        {
            throw new NotImplementedException();
        }
    }
}