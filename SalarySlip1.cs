using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            Car car = new Car();
            Bus bus = new Bus();
           
            //you want to know the rent for 3 vehicles
            int n = 0;
            while (n < 4)
            {
                Console.WriteLine("Enter Vehicle Type:");
                string vehicle = Console.ReadLine();
                Console.WriteLine("Number of hours");
                string num = Console.ReadLine();
                int numOfHrs = Convert.ToInt32(num);
                if (vehicle == "bike")
                {
                    bike.CalculateRent(numOfHrs);
                }
                if (vehicle == "car")
                {
                    car.CalculateRent(numOfHrs);
                }
                if (vehicle == "bus")
                {
                    bus.CalculateRent(numOfHrs);
                }
                n = n + 1;
            }


        }
        class CarParkingCalculator
        {
            public void CalculateRent(int numberOfHrs)
            { }
        }
        class Car : CarParkingCalculator
        {
            public void CalculateRent(int numberOfHrs)
            {
                int threeHrRent = 4;
                double oneHrRent = 1;
                int twentyFourHrRent = 20;
                Console.WriteLine("Rent for" + " " + "Car" + " " + "in dollar=");
                if (numberOfHrs == 3)
                {
                    Console.WriteLine(threeHrRent);
                }
                if (numberOfHrs > 3 & numberOfHrs < 24)
                {
                    Console.WriteLine(threeHrRent + (numberOfHrs - 3) * oneHrRent);
                }
                if (numberOfHrs == 24)
                {
                    Console.WriteLine(twentyFourHrRent);
                }
            }
        }
        class Bike : CarParkingCalculator
        {
            public void CalculateRent(int numberOfHrs)
            {
                int threeHrRent = 2;
                double oneHrRent = 0.5;
                int twentyFourHrRent = 10;
                Console.WriteLine("Rent for" + " " + "bike" + " " + "in dollar=");
                if (numberOfHrs == 3)
                {
                    Console.WriteLine(threeHrRent);
                }
                if (numberOfHrs > 3 & numberOfHrs < 24)
                {
                    Console.WriteLine(threeHrRent + (numberOfHrs - 3) * oneHrRent);
                }
                if (numberOfHrs == 24)
                {
                    Console.WriteLine(twentyFourHrRent);
                }
            }
        }
                class Bus : CarParkingCalculator
                {
                    public void CalculateRent(int numberOfHrs)
                    {
                        int threeHrRent = 6;
                        double oneHrRent = 1.5;
                        int twentyFourHrRent = 30;
                        Console.WriteLine("Rent for" + " " + "bus" + " " + "in dollar=");
                        if (numberOfHrs == 3)
                        {
                            Console.WriteLine(threeHrRent);
                        }
                        if (numberOfHrs > 3 & numberOfHrs < 24)
                        {
                            Console.WriteLine(threeHrRent + (numberOfHrs - 3) * oneHrRent);
                        }
                        if (numberOfHrs == 24)
                        {
                            Console.WriteLine(twentyFourHrRent);
                        }
                    }

                }

            }
        }
 