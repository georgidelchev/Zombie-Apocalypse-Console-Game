using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
    public class PlayerHelper
    {
        public static bool isPlayerHaveKidHelper = false;
        public static bool isPlayerHaveDogHelper = false;
        public static bool isPlayerHaveAnCar = false;

        public static double dogDamage = 25;
        public static double dogHealth = 100;
        public static string dogName = "Rex";
        public static double dogHunger = 100;

        public void KidHelper()
        {
            Console.WriteLine($"An little kid is being chased by two zombies..." +
                            $"{Environment.NewLine}What will you do {Player.playerName} ?");
            Console.WriteLine("[0] Save him!");
            Console.WriteLine("[1] Leave him alone...");
            Console.Write(">> ");

            int choice = int.Parse(Console.ReadLine());
            while (choice < 0 || choice > 1)
            {
                Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                Console.Write(">> ");
                choice = int.Parse(Console.ReadLine());
            }

            if (choice == 0)
            {
                Console.WriteLine($"Good job {Player.playerName}.");
                Console.WriteLine($"An little reward for the hero: +5 food.");
                Player.playerFood += 5;
                int chanceToGetKidHelper = new Random().Next(1, 100);
                if (chanceToGetKidHelper >= 1 && chanceToGetKidHelper <= 96) // 98% chance to not have a helper                               
                {

                }
                else if (chanceToGetKidHelper >= 97 && chanceToGetKidHelper <= 99) // 3% chance to have helper
                {
                    Console.WriteLine("The kid is soo appreciated!");
                    Console.WriteLine("He wants to be your partner in this journey!");
                    Console.WriteLine("He's name is Will.");
                    isPlayerHaveKidHelper = true;
                    Kid kid = new Kid();
                    kid.KidWeapon();
                }
            }
            else if (choice == 1)
            {
                Console.WriteLine($"I'm very dissapointed {Player.playerName} ...");
                Thread.Sleep(2000);
                Console.WriteLine("How can you leave him ...");
                Thread.Sleep(3000);

                int minusRandomFood = new Random().Next(1, 5);
                int lostFood = 0;

                switch (minusRandomFood)
                {
                    case 1:
                        Player.playerFood -= 4;
                        lostFood = 4;
                        break;
                    case 2:
                        Player.playerFood -= 6;
                        lostFood = 6;
                        break;
                    case 3:
                        Player.playerFood -= 8;
                        lostFood = 8;
                        break;
                    case 4:
                        Player.playerFood -= 10;
                        lostFood = 10;
                        break;
                    case 5:
                        Player.playerFood -= 12;
                        lostFood = 12;
                        break;
                }

                Console.WriteLine($"{Player.playerName} you lost {lostFood} food for this...");
                Player.playerFood -= lostFood;
                Thread.Sleep(1500);
                Console.WriteLine($"Think about it next time {Player.playerName}.");
                Console.WriteLine();
            }
        }

        public void DogHelper()
        {
            Console.WriteLine($"The dog is appreciated to you {Player.playerName} !");
            int chanceToFollowThePlayer = new Random().Next(1, 4);
            switch (chanceToFollowThePlayer)
            {
                case 1:
                case 2:
                    Console.WriteLine($"Sorry , but the dog ran away {Player.playerName} !");
                    break;
                case 3:
                case 4:
                    Console.WriteLine($"{Player.playerName} the dog obviously decided to follow you in the journey!");
                    Console.WriteLine("He likes you very much :)) !");
                    Console.WriteLine($"{Player.playerName} you need to feed {dogName}!");
                    isPlayerHaveDogHelper = true;
                    break;
            }
        }

        public void PlayersCar()
        {
            Console.WriteLine($"{Player.playerName} you found an car!");
            Console.WriteLine("Is it working?");
            Console.WriteLine("Checking...");
            int condition = new Random().Next(1, 10);
            switch (condition)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine($"{Player.playerName} you have bad luck...");
                    int damageType = new Random().Next(1, 5);
                    int isThereAnyFuel = new Random().Next(1, 2);
                    int howMuchFuel = new Random().Next(1, 5);
                    switch (damageType)
                    {
                        case 1:
                            Console.WriteLine($"The engine is not working.");
                            switch (isThereAnyFuel)
                            {
                                case 1:
                                    switch (howMuchFuel)
                                    {
                                        case 1:
                                            Console.WriteLine($"{Player.playerName} there is 10 fuel.");
                                            Player.fuel += 10;
                                            break;
                                        case 2:
                                            Console.WriteLine($"{Player.playerName} there is 30 fuel.");
                                            Player.fuel += 30;
                                            break;
                                        case 3:
                                            Console.WriteLine($"{Player.playerName} there is 50 fuel.");
                                            Player.fuel += 50;
                                            break;
                                        case 4:
                                            Console.WriteLine($"{Player.playerName} there is 80 fuel.");
                                            Player.fuel += 80;
                                            break;
                                        case 5:
                                            Console.WriteLine($"{Player.playerName} there is 100 fuel.");
                                            Player.fuel += 100;
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine($"{Player.playerName} there is no fuel left.");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine($"There is no tires.");
                            switch (isThereAnyFuel)
                            {
                                case 1:
                                    switch (howMuchFuel)
                                    {
                                        case 1:
                                            Console.WriteLine($"{Player.playerName} there is 2 fuel.");
                                            Player.fuel += 2;
                                            break;
                                        case 2:
                                            Console.WriteLine($"{Player.playerName} there is 6 fuel.");
                                            Player.fuel += 6;
                                            break;
                                        case 3:
                                            Console.WriteLine($"{Player.playerName} there is 8 fuel.");
                                            Player.fuel += 8;
                                            break;
                                        case 4:
                                            Console.WriteLine($"{Player.playerName} there is 10 fuel.");
                                            Player.fuel += 10;
                                            break;
                                        case 5:
                                            Console.WriteLine($"{Player.playerName} there is 15 fuel.");
                                            Player.fuel += 15;
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine($"{Player.playerName} there is no fuel left.");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine($"Brakes doesn't works.");
                            switch (isThereAnyFuel)
                            {
                                case 1:
                                    switch (howMuchFuel)
                                    {
                                        case 1:
                                            Console.WriteLine($"{Player.playerName} there is 8 fuel.");
                                            Player.fuel += 8;
                                            break;
                                        case 2:
                                            Console.WriteLine($"{Player.playerName} there is 13 fuel.");
                                            Player.fuel += 13;
                                            break;
                                        case 3:
                                            Console.WriteLine($"{Player.playerName} there is 18 fuel.");
                                            Player.fuel += 18;
                                            break;
                                        case 4:
                                            Console.WriteLine($"{Player.playerName} there is 20 fuel.");
                                            Player.fuel += 20;
                                            break;
                                        case 5:
                                            Console.WriteLine($"{Player.playerName} there is 35 fuel.");
                                            Player.fuel += 35;
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine($"{Player.playerName} there is no fuel left.");
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine($"The fuel tank is broken through.");
                            break;
                        case 5:
                            Console.WriteLine($"No battery.");
                            switch (isThereAnyFuel)
                            {
                                case 1:
                                    switch (howMuchFuel)
                                    {
                                        case 1:
                                            Console.WriteLine($"{Player.playerName} there is 15 fuel.");
                                            Player.fuel += 15;
                                            break;
                                        case 2:
                                            Console.WriteLine($"{Player.playerName} there is 25 fuel.");
                                            Player.fuel += 25;
                                            break;
                                        case 3:
                                            Console.WriteLine($"{Player.playerName} there is 30 fuel.");
                                            Player.fuel += 30;
                                            break;
                                        case 4:
                                            Console.WriteLine($"{Player.playerName} there is 50 fuel.");
                                            Player.fuel += 50;
                                            break;
                                        case 5:
                                            Console.WriteLine($"{Player.playerName} there is 65 fuel.");
                                            Player.fuel += 65;
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine($"{Player.playerName} there is no fuel left.");
                                    break;
                            }
                            break;
                    }
                    break;
                case 8:
                case 9:
                    Console.WriteLine($"{Player.playerName} you have found an working car!!");
                    isPlayerHaveAnCar = true;
                    Car car = new Car();
                    car.CarType();
                    Console.WriteLine($"{Car.carName}");
                    Console.WriteLine($"{Car.carFuel} fuel");
                    Console.WriteLine($"{Car.carDeffence} deffence");
                    if (Player.fuel < Car.carFuel)
                    {
                        Console.WriteLine($"{Player.playerName} you dont have enough fuel,sorry.");
                        isPlayerHaveAnCar = false;
                    }
                    else
                    {
                        Player.playerDeffence += Car.carDeffence;
                    }
                    break;
            }
        }
    }
}
