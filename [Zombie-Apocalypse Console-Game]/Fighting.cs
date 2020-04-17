using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
    public class Fighting
    {
        public static int actionType = 0;
        //public static bool isPlayerHaveKidHelper = false;
        public static bool isPlayerAlive = true;
        public static int shopCounter = 0;

        public void Fight()
        {
            Shop shop = new Shop();
            ZombiesTypes zombieTypes = new ZombiesTypes();
            Player playerWeapon = new Player();
            ClearingLine clearing = new ClearingLine();

            while (isPlayerAlive)
            {
                playerWeapon.PlayerWeapon();
                shopCounter++;
                if (shopCounter % 3 == 0)
                {
                    shop.ShopMenu();
                }

                actionType = new Random().Next(1, 9);

                bool isPlayerWinner = false;
                switch (actionType)
                {
                    case 1:
                        zombieTypes.ZombieBoss();
                        break;
                    case 2:
                        zombieTypes.BabyZombie();
                        break;
                    case 3:
                        zombieTypes.CommonZombie();
                        break;
                    case 4:
                        zombieTypes.LittleZombie();
                        break;
                    case 5:
                        zombieTypes.MediumZombie();
                        break;
                    case 6:
                        zombieTypes.HighZombie();
                        break;
                    case 7:
                        zombieTypes.AngryZombie();
                        break;
                    case 8:
                        zombieTypes.PoisonedZombie();
                        break;
                    case 9:
                        zombieTypes.ZombieWithKnife();
                        break;

                }

                if (actionType != 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Player.playerName} you've met an {ZombiesTypes.zombieType} with {ZombiesTypes.zombieHealth} Health and {ZombiesTypes.zombieDamage} Attack.");
                    Thread.Sleep(2000);
                    clearing.ClearingLines();
                    Console.WriteLine($"Be careful {Player.playerName}! Good luck!");
                    Thread.Sleep(1000);
                    clearing.ClearingLines();
                }

                while (isPlayerAlive && !isPlayerWinner)
                {
                    if (Player.playerHunger <= 30)
                    {
                        if (Player.playerHunger < 0)
                        {
                            Player.playerHunger = 0;
                        }

                        Console.WriteLine($"Consume some food {Player.playerName}?" +
                        $"{Environment.NewLine}Your hunger bar is : {Player.playerHunger}/100");

                        Console.WriteLine($"{Player.playerName} you have {Player.playerFood} food");

                        Console.WriteLine($"[0] - CONSUME");
                        Console.WriteLine($"[1] - DONT CONSUME");
                        Console.Write(">> ");

                        int eating = int.Parse(Console.ReadLine());
                        while (eating < 0 || eating > 1)
                        {
                            Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                            Console.Write(">> ");
                            eating = int.Parse(Console.ReadLine());
                        }

                        if (eating == 0)
                        {
                            if (Player.playerFood <= 0)
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enought food. Find somewhere fast!");
                            }
                            else
                            {
                                if (Player.playerFood + Player.playerHunger > 100)
                                {
                                    double leftFood = Player.playerFood - (100 - Player.playerHunger);

                                    Player.playerHunger = 100;

                                    Player.playerFood = leftFood;

                                    Console.WriteLine($"{Player.playerName} you fed yourself.");
                                    Console.WriteLine($"Hunger bar: {Player.playerHunger}/100");
                                    Console.WriteLine($"Left Food: {leftFood}");
                                }
                                else
                                {
                                    Player.playerHunger += Player.playerFood;
                                    Player.playerFood = 0;
                                    Console.WriteLine($"{Player.playerName} you didn't fed yourself , you need a little more food.");
                                    Console.WriteLine("Please find somewhere!");
                                    Console.WriteLine($"Hunger bar: {Player.playerHunger}/100");
                                    Console.WriteLine($"Food left: {Player.playerFood}");
                                }

                            }
                            Console.WriteLine($"{Player.playerName} you just consumed 10 Food" +
                                $"{Environment.NewLine}Hunger bar: {Player.playerHunger}/100");
                        }
                    }

                    if (PlayerHelper.isPlayerHaveAnCar == true && Player.fuel >= Car.carFuel)
                    {
                        Console.WriteLine($"{Player.playerName} you can take a ride to other city.");
                        Console.WriteLine("Did you want to?");
                        Console.WriteLine();
                        Thread.Sleep(2000);

                        Console.WriteLine();
                        Console.WriteLine("[0] TAKE A RIDE");
                        Console.WriteLine("[1] DONT");

                        int rideChoice = int.Parse(Console.ReadLine());
                        while (rideChoice < 0 || rideChoice > 1)
                        {
                            Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                            rideChoice = int.Parse(Console.ReadLine());
                        }

                        if (rideChoice == 0)
                        {
                            Console.WriteLine($"{Player.playerName} you decided to take a ride!!");
                            Console.WriteLine();
                            Console.WriteLine("Which way you choose?");
                            Console.WriteLine();

                            Console.WriteLine("     N");
                            Console.WriteLine("    [0]");
                            Console.Write("W[1]");
                            Console.WriteLine("   [3]E");
                            Console.WriteLine("    [2]");
                            Console.WriteLine("     S");

                            int way = int.Parse(Console.ReadLine());
                            while (way < 0 || way > 3)
                            {
                                Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                                way = int.Parse(Console.ReadLine());
                            }

                            switch (way)
                            {
                                case 0:
                                    Console.WriteLine("Wohoo taking a ride to the North!");
                                    Console.WriteLine("Let's see whats there ;).");
                                    Console.WriteLine($"-{Car.carFuel} fuel , Current fuel: {Player.fuel}");
                                    Player.fuel -= Car.carFuel;
                                    Thread.Sleep(5000);
                                    Console.WriteLine();

                                    Console.WriteLine($"{Player.playerName} you've found:");
                                    Console.WriteLine("+25 Food");
                                    Console.WriteLine("+25 Defence items");
                                    Console.WriteLine("+25 EXP");

                                    Player.playerFood += 25;
                                    Player.playerDeffence += 25;
                                    Player.playerExp += 25;
                                    break;
                                case 1:
                                    Console.WriteLine("Wohoo taking a ride to the West!");
                                    Console.WriteLine("Let's see whats there ;).");
                                    Console.WriteLine($"-{Car.carFuel} fuel , Current fuel: {Player.fuel}");
                                    Player.fuel -= Car.carFuel;
                                    Thread.Sleep(5000);
                                    Console.WriteLine();

                                    Console.WriteLine($"{Player.playerName} you've found:");
                                    Console.WriteLine("+65 Food");
                                    Console.WriteLine("+15 Defence items");
                                    Console.WriteLine("+35 EXP");

                                    Player.playerFood += 65;
                                    Player.playerDeffence += 15;
                                    Player.playerExp += 35;
                                    break;
                                case 2:
                                    Console.WriteLine("Wohoo taking a ride to the East!");
                                    Console.WriteLine("Let's see whats there ;).");
                                    Console.WriteLine($"-{Car.carFuel} fuel , Current fuel: {Player.fuel}");
                                    Player.fuel -= Car.carFuel;
                                    Thread.Sleep(5000);
                                    Console.WriteLine();

                                    Console.WriteLine($"{Player.playerName} you've found:");
                                    Console.WriteLine("+52 Food");
                                    Console.WriteLine("+35 Defence items");
                                    Console.WriteLine("+78 EXP");

                                    Player.playerFood += 52;
                                    Player.playerDeffence += 35;
                                    Player.playerExp += 78;
                                    break;
                                case 3:
                                    Console.WriteLine("Wohoo taking a ride to the South!");
                                    Console.WriteLine("Let's see whats there ;).");
                                    Console.WriteLine($"-{Car.carFuel} fuel , Current fuel: {Player.fuel}");
                                    Player.fuel -= Car.carFuel;
                                    Thread.Sleep(5000);
                                    Console.WriteLine();

                                    Console.WriteLine($"{Player.playerName} you've found:");
                                    Console.WriteLine("+142 Food");
                                    Console.WriteLine("+52 Defence items");
                                    Console.WriteLine("+15 EXP");

                                    Player.playerFood += 142;
                                    Player.playerDeffence += 52;
                                    Player.playerExp += 15;
                                    break;
                            }
                        }
                    }

                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine($"Weapon: [{Player.currentWeapon}] | " +
                                              $"{ Environment.NewLine}" +
                                              $"Helmet: [{Player.currentHelmet}] | " +
                                              $"Chestplate: [{Player.currentChestplate}] | " +
                                              $"Pants: [{Player.currentPants}] | " +
                                              $"Boots: [{Player.currentBoots}]");

                    Console.WriteLine();

                    Console.WriteLine($"Player LVL: [{Player.playerLevel}]  -  EXP: [{Player.playerExp}/100]                                                            ");
                    Console.WriteLine($"Hunger: {Player.playerHunger}/100   -  Food: {Player.playerFood}");
                    Console.WriteLine($"Fuel: {Player.fuel} Car:{PlayerHelper.isPlayerHaveAnCar} Kid:{PlayerHelper.isPlayerHaveKidHelper} Dog:{PlayerHelper.isPlayerHaveDogHelper}");
                    Console.WriteLine($"╔════════════════════════════════╗           Current Health: [{Player.playerHealth}]      ");
                    Console.WriteLine($"║#=# Choose an action to  do: #=#║           Current Deffence: [{Player.playerDeffence}]   ");
                    Console.WriteLine($"║════════════════════════════════║           Current Damage: [{Player.currDamage}]      ");
                    Console.WriteLine($"║ [0] - Fight with the zombie.   ║           Current Coins: [{Player.playerCoins}]        ");
                    Console.WriteLine($"║ [1] - Run Away from the zombie.║           Zombie Type : [{ZombiesTypes.zombieType}]        ");
                    Console.WriteLine($"║ [2] - Hide somewhere.          ║           Zombie HP: [{ZombiesTypes.zombieHealth}]         ");
                    Console.WriteLine($"╚════════════════════════════════╝           Zombie Attack: [{ZombiesTypes.zombieDamage}]");

                    Console.Write(">> ");
                    int actionToDo = int.Parse(Console.ReadLine());
                    while (actionToDo < 0 || actionToDo > 2)
                    {
                        Console.WriteLine($"                     Please enter an valid operation-{Player.playerName}! :");
                        Console.WriteLine();
                        Console.WriteLine($" Player LVL: [{Player.playerLevel}]  -  EXP: [{Player.playerExp}/100]                                                            ");
                        Console.WriteLine($"Hunger: {Player.playerHunger}/100    -  Food: {Player.playerFood}");
                        Console.WriteLine($"Fuel: {Player.fuel} Car:{PlayerHelper.isPlayerHaveAnCar} Kid:{PlayerHelper.isPlayerHaveKidHelper} Dog:{PlayerHelper.isPlayerHaveDogHelper}");
                        Console.WriteLine($"╔════════════════════════════════╗           Current Health: [{Player.playerHealth}]      ");
                        Console.WriteLine($"║#=# Choose an action to  do: #=#║           Current Deffence: [{Player.playerDeffence}]   ");
                        Console.WriteLine($"║════════════════════════════════║           Current Damage: [{Player.currDamage}]      ");
                        Console.WriteLine($"║ [0] - Fight with the zombie.   ║           Current Coins: [{Player.playerCoins}]        ");
                        Console.WriteLine($"║ [1] - Run Away from the zombie.║           Zombie Type : [{ZombiesTypes.zombieType}]        ");
                        Console.WriteLine($"║ [2] - Hide somewhere.          ║           Zombie HP: [{ZombiesTypes.zombieHealth}]         ");
                        Console.WriteLine($"╚════════════════════════════════╝           Zombie Attack: [{ZombiesTypes.zombieDamage}]");
                        actionToDo = int.Parse(Console.ReadLine());
                        Console.Write(">> ");
                        Console.WriteLine();
                    }

                    double diff = 0;
                    PlayerHelper helper = new PlayerHelper();

                    if (actionToDo == 0) // fighting with the zombies
                    {
                        while (isPlayerAlive && !isPlayerWinner)
                        {
                            if (Player.currDamage >= ZombiesTypes.zombieDamage)
                            {
                                Player.dealtDamage += ZombiesTypes.zombieHealth;
                            }
                            else if (ZombiesTypes.zombieHealth > Player.currDamage)
                            {
                                Player.dealtDamage += Player.currDamage;
                            }

                            if (ZombiesTypes.zombieDamage >= Player.playerHealth)
                            {
                                Player.tookDamage += Player.playerHealth;
                            }
                            else if (Player.playerHealth > ZombiesTypes.zombieDamage)
                            {
                                Player.tookDamage += ZombiesTypes.zombieDamage;
                            }

                            if (PlayerHelper.isPlayerHaveKidHelper == true)
                            {
                                ZombiesTypes.zombieHealth -= Kid.kidWeaponDamage;
                            }
                            if (PlayerHelper.isPlayerHaveDogHelper == true)
                            {
                                ZombiesTypes.zombieHealth -= PlayerHelper.dogDamage;
                                PlayerHelper.dogHealth -= ZombiesTypes.zombieDamage / 2;
                                Player.playerFood -= 10; // feeding the dog!
                                if (PlayerHelper.dogHunger <= 90)
                                {
                                    PlayerHelper.dogHunger += 10;
                                    PlayerHelper.dogHealth += 10;
                                }
                            }

                            if (Player.playerDeffence > ZombiesTypes.zombieDamage)
                            {
                                Player.playerDeffence -= ZombiesTypes.zombieDamage;
                            }
                            else if (ZombiesTypes.zombieDamage >= Player.playerDeffence)
                            {
                                diff = ZombiesTypes.zombieDamage - Player.playerDeffence;
                                Math.Abs(Player.playerDeffence -= ZombiesTypes.zombieDamage);

                                Player.playerHealth -= diff;
                            }

                            ZombiesTypes.zombieHealth -= Player.currDamage;

                            if (PlayerHelper.dogHealth <= 0)
                            {
                                Console.WriteLine($"{Player.playerName} , {PlayerHelper.dogName} is dead...");
                                PlayerHelper.isPlayerHaveDogHelper = false;
                            }

                            if (Player.playerDeffence < 0)
                            {
                                Player.playerDeffence = 0;
                            }

                            if (Player.playerHealth <= 0)
                            {
                                Console.WriteLine($"Sorry {Player.playerName} .. you are dead.");
                                isPlayerAlive = false;
                                break;
                            }
                            else if (ZombiesTypes.zombieHealth <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Good job {Player.playerName} , you killed" +
                                    $"{Environment.NewLine}successfully {ZombiesTypes.zombieType}.");
                                Console.WriteLine();

                                Console.WriteLine($"{Player.playerName} your reward is:");
                                Console.WriteLine($"+30 Food");
                                Console.WriteLine($"+10 Health");
                                Console.WriteLine($"+20 Exp");
                                Console.WriteLine($"+25 Coins");
                                Console.WriteLine($"+25 Fuel");
                                Console.WriteLine();
                                Thread.Sleep(2000);

                                Player.playerFood += 30;
                                Player.playerHealth += 10;
                                Player.playerExp += 20;
                                Player.playerCoins += 25;
                                Player.fuel += 25;

                                if (Player.playerExp >= 100)
                                {
                                    string[] leveledUp = { "Y", "O", "U ",
                                                "L", "E", "V", "E", "L", "E", "D ",
                                                "U","P", ", ", "C", "O", "N", "G", "R","A","T","S",};

                                    Console.WriteLine();

                                    for (int i = 0; i < leveledUp.Length; i++)
                                    {
                                        Console.Write($"{leveledUp[i]}");
                                        Thread.Sleep(300);
                                    }
                                    Console.WriteLine();

                                    Player.playerLevel++;
                                    Player.playerHealth += 20;
                                    Player.playerExp -= 100;
                                    Player.playerCoins += 50;
                                    Player.playerFood += 50;
                                    Player.fuel += 50;

                                    Console.WriteLine($"New Level : {Player.currentPlayerLevel} -> {Player.playerLevel}");
                                    Player.currentPlayerLevel = Player.playerLevel;

                                    Console.WriteLine();
                                    Console.WriteLine($"{Player.playerName} your reward is:");
                                    Console.WriteLine($"+50 Food");
                                    Console.WriteLine($"+20 Health");
                                    Console.WriteLine($"+50 Coins");
                                    Console.WriteLine($"+50 Fuel");
                                    Console.WriteLine();
                                }

                                isPlayerWinner = true;
                            }
                            int takingHunger = new Random().Next(1, 6);
                            switch (takingHunger) // average hunger when he is fighting
                            {
                                case 1:
                                    Player.playerHunger -= 2;
                                    break;
                                case 2:
                                    Player.playerHunger -= 4;
                                    break;
                                case 3:
                                    Player.playerHunger -= 6;
                                    break;
                                case 4:
                                    Player.playerHunger -= 8;
                                    break;
                                case 5:
                                    Player.playerHunger -= 10;
                                    break;
                                case 6:
                                    Player.playerHunger -= 12;
                                    break;
                            }

                            if (Player.playerHunger < 0)
                            {
                                Player.playerHealth -= 5;
                                Console.WriteLine();
                                Console.WriteLine($"{Player.playerName} you are hungry! Eat some food");
                                Console.WriteLine("-5 HP");
                            }
                        }
                    }
                    else if (actionToDo == 1) // running away
                    {
                        int didPlayerTookDamage = new Random().Next(1, 4);

                        if (didPlayerTookDamage == 1 || didPlayerTookDamage == 2)
                        {
                            Console.WriteLine($"{Player.playerName} ran away from these successfully " +
                               "without taking any damage!");
                        }
                        else if (didPlayerTookDamage == 3 || didPlayerTookDamage == 4)
                        {
                            Player.playerHealth -= ZombiesTypes.zombieDamage / 2;
                            double took = ZombiesTypes.zombieDamage / 2;
                            Console.WriteLine($"Oh {Player.playerName}.... you were too slow..");
                            Console.WriteLine($"You took {took} damage.");
                        }

                        if (Player.playerHealth <= 0)
                        {
                            Console.WriteLine($"Sorry {Player.playerName} .. you are dead.");
                            isPlayerAlive = false;
                            break;
                        }

                        int takingHunger = new Random().Next(1, 6);
                        switch (takingHunger) // more food when he runs
                        {
                            case 1:
                                Player.playerHunger -= 5;
                                break;
                            case 2:
                                Player.playerHunger -= 8;
                                break;
                            case 3:
                                Player.playerHunger -= 10;
                                break;
                            case 4:
                                Player.playerHunger -= 13;
                                break;
                            case 5:
                                Player.playerHunger -= 15;
                                break;
                            case 6:
                                Player.playerHunger -= 20;
                                break;
                        }

                        if (Player.playerHunger < 0)
                        {
                            Player.playerHealth -= 5;
                            Console.WriteLine($"{Player.playerName} you are hungry! Eat some food");
                            Console.WriteLine("-5 HP");
                        }
                        break;
                    }
                    else if (actionToDo == 2) // hiding somewhere
                    {
                        int didPlayerHided = new Random().Next(1, 4);

                        if (didPlayerHided == 1 || didPlayerHided == 2 || didPlayerHided == 3 || didPlayerHided == 4)
                        {
                            int wherePlayerHided = new Random().Next(1, 8);
                            int didHeTookDamage = new Random().Next(1, 4);

                            int takingHunger = new Random().Next(1, 6);
                            switch (takingHunger) // less food when he is hiding
                            {
                                case 1:
                                    Player.playerHunger -= 1;
                                    break;
                                case 2:
                                    Player.playerHunger -= 2;
                                    break;
                                case 3:
                                    Player.playerHunger -= 4;
                                    break;
                                case 4:
                                    Player.playerHunger -= 6;
                                    break;
                                case 5:
                                    Player.playerHunger -= 7;
                                    break;
                                case 6:
                                    Player.playerHunger -= 8;
                                    break;
                            }

                            if (Player.playerHunger < 0)
                            {
                                Player.playerHealth -= 5;
                                Console.WriteLine($"{Player.playerName} you are hungry! Eat some food");
                                Console.WriteLine("-5 HP");
                            }

                            switch (wherePlayerHided)
                            {
                                case 1:
                                case 2:
                                    Console.WriteLine($"{Player.playerName} you just hided in the bushes.");

                                    if (didHeTookDamage == 1 || didHeTookDamage == 2)
                                    {
                                        Console.WriteLine($"With minor injuries -10 health.");
                                        Player.playerHealth -= 10;
                                    }
                                    else if (didHeTookDamage == 3 || didHeTookDamage == 4)
                                    {
                                        Console.WriteLine("Without any injuries.");
                                    }

                                    if (PlayerHelper.isPlayerHaveDogHelper == false)
                                    {
                                        Console.WriteLine($"There is something next to you {Player.playerName}???");
                                        Thread.Sleep(2000);
                                        Console.WriteLine($"An a DOG!");
                                        Console.WriteLine("Is this your new friend in this journey?");
                                        Console.WriteLine($"Do you want to feed him {Player.playerName}?");

                                        Console.WriteLine("[0] FEED");
                                        Console.WriteLine("[1] DONT FEED");
                                        int feedChoice = int.Parse(Console.ReadLine());
                                        if (feedChoice == 1)
                                        {
                                            Console.WriteLine(">.< ...");
                                        }
                                        else if (feedChoice == 0)
                                        {
                                            Player.playerFood -= 10;
                                            helper.DogHelper();
                                        }
                                    }

                                    break;
                                case 3:
                                case 4:
                                    Console.WriteLine($"{Player.playerName} you just hided behind a car.");

                                    if (didHeTookDamage == 1 || didHeTookDamage == 2)
                                    {
                                        Console.WriteLine($"With minor injuries -10 health.");
                                        Player.playerHealth -= 10;
                                    }
                                    else if (didHeTookDamage == 3 || didHeTookDamage == 4)
                                    {
                                        Console.WriteLine("Without any injuries.");
                                    }
                                    if (PlayerHelper.isPlayerHaveAnCar == false)
                                    {
                                        helper.PlayersCar();
                                    }
                                    break;
                                case 5:
                                case 6:
                                    Console.WriteLine($"{Player.playerName} you just hided in a shop.");

                                    if (didHeTookDamage == 1 || didHeTookDamage == 2)
                                    {
                                        Console.WriteLine($"With minor injuries -10 health.");
                                        Player.playerHealth -= 10;
                                    }
                                    else if (didHeTookDamage == 3 || didHeTookDamage == 4)
                                    {
                                        Console.WriteLine("Without any injuries.");
                                    }

                                    int didHeFoundSomething = new Random().Next(1, 2);
                                    switch (didHeFoundSomething)
                                    {
                                        case 1:
                                            int whatHeFound = new Random().Next(1, 6);
                                            switch (whatHeFound)
                                            {
                                                case 1:
                                                    Console.WriteLine($"{Player.playerName} you found 50 food!");
                                                    Player.playerFood += 50;
                                                    break;
                                                case 2:
                                                    Console.WriteLine($"{Player.playerName} you found 75 fuel!");
                                                    Player.fuel += 75;
                                                    break;
                                                case 3:
                                                    Console.WriteLine($"{Player.playerName} you found 25 deffensive items!");
                                                    Player.playerFood += 25;
                                                    break;
                                                case 4:
                                                    Console.WriteLine($"{Player.playerName} you found a med kit!");
                                                    Console.WriteLine("+50 Health");
                                                    Player.playerHealth += 50;
                                                    break;
                                                case 5:
                                                    Console.WriteLine($"{Player.playerName} you found 100 coins!");
                                                    Player.playerCoins += 100;
                                                    break;
                                                case 6:
                                                    Console.WriteLine($"{Player.playerName} you found chest!");
                                                    int chest = new Random().Next(1, 3);
                                                    switch (chest)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("+25 deff");
                                                            Player.playerDeffence += 25;
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("+15 health");
                                                            Player.playerHealth += 15;
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("+75 coins");
                                                            Player.playerCoins += 75;
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                                case 7:
                                case 8:
                                    Console.WriteLine($"{Player.playerName} you just hided in a house.");

                                    if (didHeTookDamage == 1 || didHeTookDamage == 2)
                                    {
                                        Console.WriteLine($"With minor injuries -10 health.");
                                        Player.playerHealth -= 10;
                                    }
                                    else if (didHeTookDamage == 3 || didHeTookDamage == 4)
                                    {
                                        Console.WriteLine("Without any injuries.");
                                    }

                                    if (PlayerHelper.isPlayerHaveKidHelper == false)
                                    {
                                        Console.WriteLine($"There is someone {Player.playerName}!!!");
                                        PlayerHelper playerHelper = new PlayerHelper();
                                        playerHelper.KidHelper();
                                    }

                                    break;
                            }
                            if (Player.playerHealth <= 0)
                            {
                                Console.WriteLine($"Sorry {Player.playerName} .. you are dead.");
                                isPlayerAlive = false;
                                break;
                            }
                        }
                    }
                }

            }
        }
    }
}
