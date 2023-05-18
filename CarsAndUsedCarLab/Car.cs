using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarLab
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public static List<Car> cars { get; set; } = new List<Car>();

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }

        public Car(string aMake, string aModel, int aYear, decimal aPrice)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
            Price = aPrice;
        }

        public virtual string ToString() // add virtual
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price, 0:C}";

        }

        public static void ListCars()
        {
            int listCount = cars.Count;

            for (int i = 1; i <= listCount; i++)
            {
                    Console.WriteLine($"{i}. {UsedCar.cars[i - 1].ToString()}");
            }
        }
        
        public static void Remove(int input)
        {
            Console.WriteLine(cars[input]);
            cars.RemoveAt(input - 1);
        }
    }
}
