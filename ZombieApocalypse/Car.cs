using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
    public class Car
    {
        public static string carName = string.Empty;
        public static double carFuel;
        public static double carDeffence;

        public static int carType = new Random().Next(1, 6);

        public void CarType()
        {
            switch (carType)
            {
                case 1:
                    carName = "Volvo";
                    carFuel = 100;
                    carDeffence = 50;
                    break;
                case 2:
                    carName = "Citroen";
                    carFuel = 95;
                    carDeffence = 60;
                    break;
                case 3:
                    carName = "BMW";
                    carFuel = 80;
                    carDeffence = 75;
                    break;
                case 4:
                    carName = "Mercedes";
                    carFuel = 75;
                    carDeffence = 100;
                    break;
                case 5:
                    carName = "VW";
                    carFuel = 70;
                    carDeffence = 130;
                    break;
                case 6:
                    carName = "Audi";
                    carFuel = 60;
                    carDeffence = 150;
                    break;

            }
        }
    }
}
