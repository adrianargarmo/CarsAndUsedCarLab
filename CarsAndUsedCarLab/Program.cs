using CarsAndUsedCarLab;
using System.Collections.Concurrent;

Car carOne = new Car("Jeep", "Wrangler", 2023, 44396);
Car carTwo = new Car("Lexus", "RX", 2023, 59347);
Car carThree = new Car("Cadillac", "CT4-V", 2023, 69904);

UsedCar usedCarOne = new UsedCar("Dodge", "Journey", 2019, 19700, 35125);
UsedCar usedCarTwo = new UsedCar("Chevrolet", "Traverse", 2014, 15995, 69839);
UsedCar usedCarThree = new UsedCar("Mazda", "Mazda3", 2007, 13445, 101128);

Car.cars.Add(carOne);
Car.cars.Add(carTwo);
Car.cars.Add(carThree);
Car.cars.Add(usedCarOne);
Car.cars.Add(usedCarTwo);
Car.cars.Add(usedCarThree);

Car.ListCars();

Console.WriteLine("Enter the number of the car you would like to remove from the list.");
int input = int.Parse(Console.ReadLine());

Car.Remove(input);

Car.ListCars();

Console.WriteLine("Excellent!  Our finance department will be in touch shortly.");
Console.WriteLine("Have a great day!");