using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CarsAndUsedCarLab
{
    internal class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string aMake, string aModel, int aYear, decimal aPrice, double miles) : base(aMake, aModel, aYear, aPrice)
        {
            Mileage = miles;
        }

        public override string ToString() //overriding
        {
            return $"{base.ToString()}, (Used) Mileage: {Mileage}";
        }
    }
}