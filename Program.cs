using System;//Thread.Sleep
using System.Threading;
namespace TEST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ZombieApocalypse text = new ZombieApocalypse();
            text.Zombie();


            Player player = new Player();
            BeginningInformation welcomeInfo = new BeginningInformation();
            Fighting fighting = new Fighting();
            GameOver gameOver = new GameOver();
            ClearingLine clr = new ClearingLine();


            Thread.Sleep(2000);
            Console.WriteLine();
            welcomeInfo.WelcomeInfo();
            player.PlayerName(); // message to enter your name 


            Console.WriteLine($"{Player.playerName} press any key to continue!");
            Console.ReadKey();
            clr.ClearingLines();
            Console.Clear();

            //Thread.Sleep(2000); // 2 seconds of sleep
            Console.WriteLine($"Hello {Player.playerName}! Nice to meet you!"); // hello message
            Console.WriteLine(); // empty line

            fighting.Fight(); // whole fight logic
            gameOver.Over(); // when game is over statistics,info etc..
        }
    }

    public class ZombieApocalypse
    {
        public void Zombie()
        {
            Console.ForegroundColor = ConsoleColor.Red; // making console text color in red
            string[] zombie = new string[]
                                        {"                                                                            ",
                                         "                              ███████╗░█████╗░███╗░░░███╗██████╗░██╗███████╗",
                                         "                              ╚════██║██╔══██╗████╗░████║██╔══██╗██║██╔════╝",
                                         "                              ░░███╔═╝██║░░██║██╔████╔██║██████╦╝██║█████╗░░",
                                         "                              ██╔══╝░░██║░░██║██║╚██╔╝██║██╔══██╗██║██╔══╝░░",
                                         "                              ███████╗╚█████╔╝██║░╚═╝░██║██████╦╝██║███████╗",
                                         "                              ╚══════╝░╚════╝░╚═╝░░░░░╚═╝╚═════╝░╚═╝╚══════╝",
                                         "                                                                                              ",
                                         "             ░█████╗░██████╗░░█████╗░░█████╗░░█████╗░██╗░░░░░██╗░░░██╗██████╗░░██████╗███████╗",
                                         "             ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░╚██╗░██╔╝██╔══██╗██╔════╝██╔════╝",
                                         "             ███████║██████╔╝██║░░██║██║░░╚═╝███████║██║░░░░░░╚████╔╝░██████╔╝╚█████╗░█████╗░░",
                                         "             ██╔══██║██╔═══╝░██║░░██║██║░░██╗██╔══██║██║░░░░░░░╚██╔╝░░██╔═══╝░░╚═══██╗██╔══╝░░",
                                         "             ██║░░██║██║░░░░░╚█████╔╝╚█████╔╝██║░░██║███████╗░░░██║░░░██║░░░░░██████╔╝███████╗",
                                         "             ╚═╝░░╚═╝╚═╝░░░░░░╚════╝░░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░░░░╚═════╝░╚══════╝"};


            ClearingLine clr = new ClearingLine();


            for (int i = 0; i < zombie.Length; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.WriteLine(zombie[y]);
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            foreach (string value in zombie)
            {
                Console.WriteLine(value);
            }

            Thread.Sleep(5000);
            Console.WriteLine();
            string[] key = {
                "                                          ",
                "P", "r", "e", "s", "s", " ",
                "a", "n", "y", " ",
                "k", "e", "y", " ",
                "t", "o", " ",
                "c", "o", "n", "t", "i", "n", "u", "e", ":" };

            for (int i = 0; i < key.Length; i++)
            {
                Console.Write(key[i]);
                Thread.Sleep(350);
            }
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan; // making console text color in cyan

            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            for (int i = 0; i <= 100; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
                Console.WriteLine($"{i}/100%");
                Console.SetCursorPosition(0, 1);
                Thread.Sleep(100);
            }
            Thread.Sleep(2500);
            Console.Clear();
        }
    }
    public class BeginningInformation
    {
        public void WelcomeInfo()
        {
            Console.Write("Please enter your name: ");
            Console.WriteLine();
            Console.Write(">> ");
        }
        public void Information()
        {
            // TODO ADD INFORMATION
        }
        public void Story()
        {
            // TODO ADD STORY !!
            Console.WriteLine("an test of STORY!");  // testing
            Console.WriteLine(Player.playerName);    // testing
            Console.WriteLine(Player.playerFood -= 5); // testing
        }
    }
    public class Player
    {
        // PLAYER STATS
        public static string playerName;  // the name of the Player       
        public static double playerFood = 10;  // amount of food that Player have
        public static double playerHunger = 100;
        public static double playerHealth = 1; // health of the player
        public static string playerGear;  // current Player gear
        public static double playerCoins = 25; // current Player coins
        public static int playerLevel = 0; // current Player level
        public static int currentPlayerLevel = playerLevel;
        public static double playerExp = 0; // current Player Exp
        public static string currentHelmet = string.Empty;
        public static string currentChestplate = string.Empty;
        public static string currentPants = string.Empty;
        public static string currentBoots = string.Empty;
        public static double playerDeffence = 50;
        public static double fuel = 0;
        // RANDOMIZED WEAPON
        public static int playerWeapon;   // player's weapon randomized

        // WEAPON STATS
        public static string currentWeapon = string.Empty; // current weapon of the Player
        public static string weaponName; // the name of the weapon
        public static double weaponDamage; // the damage of the weapon
        public static string weaponClass; // the quality class of the weapon
        public static double currDamage;
        public static double currClass;


        // EQUIPMENT
        public static string[] leatherArmor = { "Leather Helmet", "Leather Chestplate", "Leather Pants", "Leather Boots", }; // Leather armor - 2 deff points
        public static string[] chainArmor = { "Chain Helmet", "Chain Chestplate", "Chain Pants", "Chain Boots", }; // Chain Armor - 5 deff points
        public static string[] ironArmor = { "Iron Helmet", "Iron Chestplate", "Iron Pants", "Iron Boots", }; // Iron armor - 7 deff points

        public static string[] weapons = { "Shotgun", "M4", "Machete" };


        public static double weaponClassCheck = 0;
        double maxClass = double.MinValue;
        public void PlayerName()
        {
            playerName = Console.ReadLine(); // entering the name of the Player

        }
        public void PlayerWeapon() // choosing randomly an weapon
        {
            playerWeapon = new Random().Next(1, 100); // dropping chance

            if (playerWeapon >= 1 && playerWeapon <= 39) // 40% drop chance
            {
                weaponName = "Pan";
                weaponDamage = 35;
                weaponClass = "[2/10]";
                weaponClassCheck = 2;
            }
            else if (playerWeapon >= 40 && playerWeapon <= 59) // 20% drop chance
            {
                weaponName = "Stone Axe";
                weaponDamage = 40;
                weaponClass = "[3.5/10]";
                weaponClassCheck = 3.5;
            }
            else if (playerWeapon >= 60 && playerWeapon <= 79) // 20% drop chance
            {
                weaponName = "Iron Pickaxe";
                weaponDamage = 45;
                weaponClass = "[5.5/10]";
                weaponClassCheck = 5.5;
            }
            else if (playerWeapon >= 80 && playerWeapon <= 91) // 12% drop chance
            {
                weaponName = "Gun";
                weaponDamage = 65;
                weaponClass = "[7.5/10]";
                weaponClassCheck = 7.5;
            }
            else if (playerWeapon >= 92 && playerWeapon <= 99) // 8% drop chance
            {
                weaponName = "AK-47";
                weaponDamage = 100;
                weaponClass = "[10/10]";
                weaponClassCheck = 10;
            }

            if (weaponClassCheck > maxClass)
            {
                maxClass = weaponClassCheck;
                currentWeapon = weaponName;
                currDamage = weaponDamage;
                currClass = weaponClassCheck;
                Console.WriteLine();
                Console.WriteLine($"{Player.playerName} you've found an new better weapon - {weaponName}!");
            }

        }

    }
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
    public class Kid
    {
        public static string kidName = "Will";  // the name of the Kid       
        public static double kidFood = 15;  // amount of food that Kid have
        public static double kidHealth = 100; // health of the Kid
        public static string kidGear;  // current Kid gear
        public static double kidCoins = 50; // current Kid coins

        public static int kidWeapon;


        public static string currentKidHelmet = string.Empty;
        public static string currentKidChestplate = string.Empty;
        public static string currentKidPants = string.Empty;
        public static string currentKidBoots = string.Empty;

        public static string currentKidWeapon = string.Empty; // current weapon of the Kid
        public static string kidWeaponName; // the name of the weapon
        public static double kidWeaponDamage; // the damage of the weapon
        public static string kidWeaponClass; // the quality class of the weapon

        public static string[] clothes = { "Black hat", "Leather Jacket", "Jeans", "Moccassins", }; // Basic clothes - 2 deff points
        public static string[] ironArmor = { "Iron Helmet", "Iron Chestplate", "Iron Pants", "Iron Boots", }; // Iron armor - 7 deff points

        public void KidWeapon()
        {
            kidWeapon = new Random().Next(1, 100); // dropping chance

            if (kidWeapon >= 1 && kidWeapon <= 39) // 40% drop chance
            {
                kidWeaponName = "Wooden Stick";
                kidWeaponDamage = 1;
                kidWeaponClass = "[1/10]";
            }
            else if (kidWeapon >= 40 && kidWeapon <= 59) // 20% drop chance
            {
                kidWeaponName = "Wooden Axe";
                kidWeaponDamage = 3;
                kidWeaponClass = "[3/10]";
            }
            else if (kidWeapon >= 60 && kidWeapon <= 79) // 20% drop chance
            {
                kidWeaponName = "Iron Spear";
                kidWeaponDamage = 7;
                kidWeaponClass = "[5.5/10]";
            }
            else if (kidWeapon >= 80 && kidWeapon <= 91) // 12% drop chance
            {
                kidWeaponName = "Bow with arrows";
                kidWeaponDamage = 10;
                kidWeaponClass = "[7.5/10]";
            }
            else if (kidWeapon >= 92 && kidWeapon <= 99) // 8% drop chance
            {
                kidWeaponName = "Molotov";
                kidWeaponDamage = 15;
                kidWeaponClass = "[10/10]";
            }
            currentKidWeapon = kidWeaponName;
            kidWeapon = 0;
        }
    }
    public class PlayerHelper
    {
        public static bool isPlayerHaveKidHelper = false;
        public static bool isPlayerHaveDogHelper = false;
        public static bool isPlayerHaveAnCar = false;
        public static double dogDamage = 25;
        public static double dogHealth = 100;
        public static string dogName = "ReX";
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
                //Thread.Sleep(2000);
                Console.WriteLine("How can you leave him ...");
                //Thread.Sleep(3000);
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
                //Thread.Sleep(1500);
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
    public class ZombiesTypes
    {
        // ZOMBIES STATS
        public static string zombieType = string.Empty;     // the type of the Zombie
        public static double zombieDamage = 0;                 // damage of the Zombie
        public static double zombieHealth = 0;                 // health of the Zombie       
        public void BabyZombie()
        {
            zombieType = "Baby Zombie";
            zombieDamage = 5;
            zombieHealth = 10;
        }
        public void CommonZombie()
        {
            zombieType = "Common Zombie";
            zombieDamage = 10;
            zombieHealth = 20;
        }
        public void LittleZombie()
        {
            zombieType = "Little Zombie";
            zombieDamage = 15;
            zombieHealth = 30;
        }
        public void MediumZombie()
        {
            zombieType = "Medium Zombie";
            zombieDamage = 20;
            zombieHealth = 40;
        }
        public void HighZombie()
        {
            zombieType = "High Zombie";
            zombieDamage = 25;
            zombieHealth = 50;
        }
        public void AngryZombie()
        {
            zombieType = "Angry Zombie";
            zombieDamage = 27;
            zombieHealth = 60;
        }
        public void PoisonedZombie()
        {
            zombieType = "Poisoned Zombie";
            zombieDamage = 28;
            zombieHealth = 70;
        }
        public void ZombieWithKnife()
        {
            zombieType = "Zombie with an knife";
            zombieDamage = 29;
            zombieHealth = 80;
        }
        public void ZombieBoss()
        {
            zombieType = "Zombie BOSS";
            zombieDamage = 30;
            zombieHealth = 100;
        }

    }
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

                } // Under working !

                if (actionType != 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Player.playerName} you've met an {ZombiesTypes.zombieType} with {ZombiesTypes.zombieHealth} Health and {ZombiesTypes.zombieDamage} Attack.");
                    //Thread.Sleep(2000);
                    clearing.ClearingLines();
                    Console.WriteLine($"Be careful {Player.playerName}! Good luck!");
                    //Thread.Sleep(1000);
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
                    Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{Player.playerHealth}]      ");
                    Console.WriteLine($"║#=# Choose an action to  do: #=#║           ║Current Deffence: [{Player.playerDeffence}]   ");
                    Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{Player.currDamage}]      ");
                    Console.WriteLine($"║ [0] - Fight with the zombie.   ║           ║Current Coins: [{Player.playerCoins}]        ");
                    Console.WriteLine($"║ [1] - Run Away from the zombie.║           ║Zombie Type : [{ZombiesTypes.zombieType}]        ");
                    Console.WriteLine($"║ [2] - Hide somewhere.          ║           ║Zombie HP: [{ZombiesTypes.zombieHealth}]         ");
                    Console.WriteLine($"╚════════════════════════════════╝           ║Zombie Attack: [{ZombiesTypes.zombieDamage}]");

                    Console.Write(">> ");
                    int actionToDo = int.Parse(Console.ReadLine());
                    while (actionToDo < 0 || actionToDo > 2)
                    {
                        Console.WriteLine($"                     Please enter an valid operation-{Player.playerName}! :");
                        Console.WriteLine();
                        Console.WriteLine($" Player LVL: [{Player.playerLevel}]  -  EXP: [{Player.playerExp}/100]                                                            ");
                        Console.WriteLine($"Hunger: {Player.playerHunger}/100    -  Food: {Player.playerFood}");
                        Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{Player.playerHealth}]      ");
                        Console.WriteLine($"║#=# Choose an action to  do: #=#║           ║Current Deffence: [{Player.playerDeffence}]   ");
                        Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{Player.currDamage}]      ");
                        Console.WriteLine($"║ [0] - Fight with the zombie.   ║           ║Current Coins: [{Player.playerCoins}]        ");
                        Console.WriteLine($"║ [1] - Run Away from the zombie.║           ║Zombie Type : [{ZombiesTypes.zombieType}]        ");
                        Console.WriteLine($"║ [2] - Hide somewhere.          ║           ║Zombie HP: [{ZombiesTypes.zombieHealth}]         ");
                        Console.WriteLine($"╚════════════════════════════════╝           ║Zombie Attack: [{ZombiesTypes.zombieDamage}]");
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
                                Console.WriteLine();
                                Thread.Sleep(2000);

                                Player.playerFood += 30;
                                Player.playerHealth += 10;
                                Player.playerExp += 20;
                                Player.playerCoins += 25;

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

                                    Console.WriteLine($"New Level : {Player.currentPlayerLevel} -> {Player.playerLevel}");
                                    Player.currentPlayerLevel = Player.playerLevel;

                                    Console.WriteLine();
                                    Console.WriteLine($"{Player.playerName} your reward is:");
                                    Console.WriteLine($"+50 Food");
                                    Console.WriteLine($"+20 Health");
                                    Console.WriteLine($"+50 Coins");
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
                                        //Thread.Sleep(2000);
                                        Console.WriteLine($"An a DOG!");
                                        Console.WriteLine("Is this your new friend in this journey?");
                                        Console.WriteLine($"Do you want to feed him {Player.playerName}?");
                                        int feedChoice = int.Parse(Console.ReadLine());
                                        Console.WriteLine("[0] FEED");
                                        Console.WriteLine("[1] DONT FEED");

                                        if (feedChoice == 0)
                                        {
                                            Console.WriteLine(">.< ...");
                                        }
                                        else if (feedChoice == 1)
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
    public class GameOver
    {
        public void Over()
        {
            Console.WriteLine($"╔════════════════════════════════╗");
            Console.WriteLine($"║     #=# DEAD STATISTICS #=#    ║");
            Console.WriteLine($"╚════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine($"    Health Diff: [{Math.Abs(Player.playerHealth)}]");
            Console.WriteLine($"    Last Weapon: [{Player.weaponName}]");
            Console.WriteLine($"    Weapon CLASS: [{Player.currClass}]");
            Console.WriteLine();
            Console.WriteLine($"    Dog: {PlayerHelper.isPlayerHaveDogHelper}");
            Console.WriteLine($"    Kid: {PlayerHelper.isPlayerHaveKidHelper}");
            Console.WriteLine();
            Console.WriteLine($"    Zombie Name : [{ZombiesTypes.zombieType}]");
            Console.WriteLine($"    Zombie HP Diff: [{Math.Abs(ZombiesTypes.zombieHealth)}]");
            Console.WriteLine($"    Zombie Attack: [{ZombiesTypes.zombieDamage}]");
        }
    } // to upgrade this class
    public class Shop
    {
        public void ShopMenu()
        {
            Console.WriteLine($"Welcome to the shop menu {Player.playerName}");
            Console.WriteLine($"Do you want to look at the shop?");
            Console.WriteLine("[0] - YES");
            Console.WriteLine("[1] - NO");
            int shopChoice = int.Parse(Console.ReadLine());
            while (shopChoice < 0 || shopChoice > 1)
            {
                Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                Console.Write(">> ");
                shopChoice = int.Parse(Console.ReadLine());
            }
            switch (shopChoice)
            {
                case 0:
                    Console.WriteLine("[0] - ARMORS");
                    Console.WriteLine("[1] - WEAPONS");
                    Console.WriteLine("[2] - EXIT");
                    Console.Write(">> ");

                    int pick = int.Parse(Console.ReadLine());
                    while (pick < 0 || pick > 2)
                    {
                        Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                        Console.Write(">> ");
                        pick = int.Parse(Console.ReadLine());
                    }
                    if (pick == 0)
                    {

                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine();
                        Console.WriteLine($"      ╔══════════════════════╗");
                        Console.WriteLine($"      ║ Current gold: " +
                                                    $"{Player.playerCoins}    ║");
                        Console.WriteLine($"      ╚══════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");
                        Console.WriteLine($"║       #=# ARMORS MENU #=#      ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[0] - Leather Armor - [100G]    ║");
                        Console.WriteLine($"║      [+10 deff] [+10 hp]       ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[1] - Chain Armor - [250G]      ║");
                        Console.WriteLine($"║      [+18 deff] [+20 hp]       ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[2] - Iron Armor - [500G]       ║");
                        Console.WriteLine($"║      [+35 deff] [+25 hp]       ║");
                        Console.WriteLine($"╚════════════════════════════════╝");
                        Console.WriteLine($"   [3] - EXIT | [4] - PREV. PAGE  ");

                        int order = int.Parse(Console.ReadLine());
                        while (order < 0 || order > 4)
                        {
                            Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                            Console.Write(">> ");
                            order = int.Parse(Console.ReadLine());
                        }
                        if (order == 4)
                        {
                            goto case 0;
                        }
                        else if (order == 3)
                        {
                            break;
                        }
                        else if (order == 2)
                        {
                            if (Player.playerCoins >= 500)
                            {
                                Player.playerCoins -= 500;
                                Console.Write($"{Player.playerName} you just bought an Iron Armor for");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" 500 Coins");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Environment.NewLine}You have: +35 deff and + 25 hp.");
                                Player.playerHealth += 25;
                                Player.playerDeffence += 35;
                                Player.currentHelmet = Player.ironArmor[0];
                                Player.currentChestplate = Player.ironArmor[1];
                                Player.currentPants = Player.ironArmor[2];
                                Player.currentBoots = Player.ironArmor[3];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(Player.playerCoins - 500);
                                Console.WriteLine($"Not enought money {Player.playerName} !" +
                                    $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 1)
                        {
                            if (Player.playerCoins >= 250)
                            {
                                Player.playerCoins -= 250;
                                Console.Write($"{Player.playerName} you just bought an Chain Armor for");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" 250 Coins");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Environment.NewLine}You have: +18 deff and + 20 hp.");
                                Player.playerHealth += 20;
                                Player.playerDeffence += 18;
                                Player.currentHelmet = Player.chainArmor[0];
                                Player.currentChestplate = Player.chainArmor[1];
                                Player.currentPants = Player.chainArmor[2];
                                Player.currentBoots = Player.chainArmor[3];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(Player.playerCoins - 250);
                                Console.WriteLine($"Not enought money {Player.playerName} !" +
                                    $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 0)
                        {
                            if (Player.playerCoins >= 100)
                            {
                                Player.playerCoins -= 100;
                                Console.Write($"{Player.playerName} you just bought an Leather Armor for");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" 100 Coins");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"{Environment.NewLine}You have: +10 deff and + 10 hp.");
                                Player.playerHealth += 10;
                                Player.playerDeffence += 10;
                                Player.currentHelmet = Player.leatherArmor[0];
                                Player.currentChestplate = Player.leatherArmor[1];
                                Player.currentPants = Player.leatherArmor[2];
                                Player.currentBoots = Player.leatherArmor[3];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(Player.playerCoins - 100);
                                Console.WriteLine($"Not enought money {Player.playerName} !" +
                                    $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                    }
                    if (pick == 1)
                    {
                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine();
                        Console.WriteLine($"      ╔══════════════════════╗");
                        Console.WriteLine($"      ║ Current gold: " +
                                                    $"{Player.playerCoins}    ║");
                        Console.WriteLine($"      ╚══════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");
                        Console.WriteLine($"║      #=# WEAPONS MENU #=#      ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[0] -  Shotgun - [200G]         ║");
                        Console.WriteLine($"║          [+10 dmg]             ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[1] -    M4 - [300G]            ║");
                        Console.WriteLine($"║          [+15 dmg]             ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[2] -  Machete - [500]          ║");
                        Console.WriteLine($"║         [+40 dmg]              ║");
                        Console.WriteLine($"╚════════════════════════════════╝");
                        Console.WriteLine($"   [3] - EXIT | [4] - PREV. PAGE  ");

                        int order = int.Parse(Console.ReadLine());
                        while (order < 0 || order > 4)
                        {
                            Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                            Console.Write(">> ");
                            order = int.Parse(Console.ReadLine());
                        }
                        if (order == 4)
                        {
                            goto case 0;
                        }
                        else if (order == 3)
                        {
                            break;
                        }
                        else if (order == 2)
                        {
                            if (Player.playerCoins >= 500)
                            {
                                Player.playerCoins -= 500;
                                Console.Write($"{Player.playerName} you just bought an Machete for");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" 500 Coins");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"{Environment.NewLine}You have: +40 Attack.");
                                Player.weaponDamage += 40;
                                Player.currentWeapon = Player.weapons[2];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(Player.playerCoins - 500);
                                Console.WriteLine($"Not enought money {Player.playerName} !" +
                                    $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 1)
                        {
                            if (Player.playerCoins >= 300)
                            {
                                Player.playerCoins -= 300;
                                Console.Write($"{Player.playerName} you just bought an M4 for");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" 300 Coins");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"{Environment.NewLine}You have: +15 Attack");
                                Player.weaponDamage += 15;
                                Player.currentWeapon = Player.weapons[1];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(Player.playerCoins - 300);
                                Console.WriteLine($"Not enought money {Player.playerName} !" +
                                    $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 0)
                        {
                            if (Player.playerCoins >= 200)
                            {
                                Player.playerCoins -= 200;
                                Console.Write($"{Player.playerName} you just bought an Shotgun for");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" 200 Coins");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"{Environment.NewLine}You have: +10 Attack");
                                Player.weaponDamage += 10;
                                Player.currentWeapon = Player.weapons[0];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(Player.playerCoins - 200);
                                Console.WriteLine($"Not enought money {Player.playerName} !" +
                                    $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }

                    }
                    break;
            }
        }

    }
    public class ClearingLine
    {
        public void ClearingLines()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            //Thread.Sleep(4500);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}