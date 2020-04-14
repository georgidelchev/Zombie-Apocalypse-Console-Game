using System;
using System.Threading;

namespace TEST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //=============================/\ :CORRECTLY: /\===================================================\\
            Player player = new Player();
            BeginningInformation welcomeInfo = new BeginningInformation();
            welcomeInfo.WelcomeInfo();
            Console.Write(">> ");
            player.PlayerName(); // message to enter your name 
            //Thread.Sleep(2000); // 2 seconds of sleep
            Console.WriteLine($"Hello {Player.playerName}! Nice to meet you!"); // hello message
            Console.WriteLine(); // empty line
            player.PlayerWeapon();
            Fighting fighting = new Fighting();
            fighting.Fight();

            GameOver gameOver = new GameOver();
            gameOver.Over();


            Console.WriteLine(Player.weaponName);


            //===========================\/ :TESTING: \/==============================================\\
            // testing 
            //int i = 0;                                         // testing the weapon drop chances!
            //while (i < 10)                                  // testing the weapon drop chances!
            //{                                                  // testing the weapon drop chances!
            // testing the weapon drop chances!
            //    Player.playerExp += 10;        // testing the weapon drop chances!
            //    i++;                                           // testing the weapon drop chances!
            //}                                                  // testing the weapon drop chances!
            ////// testing 
            //Console.WriteLine(Player.playerExp);
            //
            //
            //
            //welcomeInfo.Story();            // testing

            //===========================/\ :TESTING: /\==============================================\\

        }
    }
    public class BeginningInformation
    {
        public void WelcomeInfo()
        {
            Console.Write("Please enter your name: ");
            Console.WriteLine();
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
        public static double playerHealth = 50; // health of the player
        public static string playerGear;  // current Player gear
        public static double playerCoins = 50; // current Player coins
        public static int playerLevel = 0; // current Player level
        public static int currentPlayerLevel = playerLevel;
        public static double playerExp = 0; // current Player Exp
        public static string currentHelmet = string.Empty;
        public static string currentChestplate = string.Empty;
        public static string currentPants = string.Empty;
        public static string currentBoots = string.Empty;
        // RANDOMIZED WEAPON
        public static int playerWeapon;   // player's weapon randomized

        // WEAPON STATS
        public static string currentWeapon = string.Empty; // current weapon of the Player
        public static string weaponName; // the name of the weapon
        public static double weaponDamage; // the damage of the weapon
        public static string weaponClass; // the quality class of the weapon


        // EQUIPMENT
        public static string[] leatherArmor = { "Leather Helmet", "Leather Chestplate", "Leather Pants", "Leather Boots", }; // Leather armor - 2 deff points
        public static string[] chainArmor = { "Chain Helmet", "Chain Chestplate", "Chain Pants", "Chain Boots", }; // Chain Armor - 5 deff points
        public static string[] ironArmor = { "Iron Helmet", "Iron Chestplate", "Iron Pants", "Iron Boots", }; // Iron armor - 7 deff points

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
                weaponDamage = 3;
                weaponClass = "[2/10]";
            }
            else if (playerWeapon >= 40 && playerWeapon <= 59) // 20% drop chance
            {
                weaponName = "Stone Axe";
                weaponDamage = 5;
                weaponClass = "[3.5/10]";
            }
            else if (playerWeapon >= 60 && playerWeapon <= 79) // 20% drop chance
            {
                weaponName = "Iron Pickaxe";
                weaponDamage = 7;
                weaponClass = "[5.5/10]";
            }
            else if (playerWeapon >= 80 && playerWeapon <= 91) // 12% drop chance
            {
                weaponName = "Gun";
                weaponDamage = 10;
                weaponClass = "[7.5/10]";
            }
            else if (playerWeapon >= 92 && playerWeapon <= 99) // 8% drop chance
            {
                weaponName = "AK-47";
                weaponDamage = 15;
                weaponClass = "[10/10]";
            }
            currentWeapon = weaponName;
            playerWeapon = 0;
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
    public class ZombiesTypes
    {
        // ZOMBIES STATS
        public static string zombieType = string.Empty;     // the type of the Zombie
        public static double zombieDamage = 0;                 // damage of the Zombie
        public static double zombieHealth = 0;                 // health of the Zombie

        public void BabyZombie()
        {
            zombieType = "Baby Zombie";
            zombieDamage = 1;
            zombieHealth = 10;
        }
        public void CommonZombie()
        {
            zombieType = "Common Zombie";
            zombieDamage = 3;
            zombieHealth = 20;
        }
        public void LittleZombie()
        {
            zombieType = "Little Zombie";
            zombieDamage = 5;
            zombieHealth = 30;
        }
        public void MediumZombie()
        {
            zombieType = "Medium Zombie";
            zombieDamage = 7;
            zombieHealth = 40;
        }
        public void HighZombie()
        {
            zombieType = "High Zombie";
            zombieDamage = 8;
            zombieHealth = 50;
        }
        public void AngryZombie()
        {
            zombieType = "Angry Zombie";
            zombieDamage = 9;
            zombieHealth = 60;
        }
        public void PoisonedZombie()
        {
            zombieType = "Poisoned Zombie";
            zombieDamage = 11;
            zombieHealth = 70;
        }
        public void ZombieWithKnife()
        {
            zombieType = "Zombie with an knife";
            zombieDamage = 12;
            zombieHealth = 80;
        }
        public void ZombieBoss()
        {
            zombieType = "Zombie BOSS";
            zombieDamage = 20;
            zombieHealth = 100;
        }

    }
    public class Fighting
    {
        public static int actionType = 0;
        public static bool isPlayerHaveKidHelper = false;
        public static bool isPlayerAlive = true;

        public void Fight()
        {
            ZombiesTypes zombieTypes = new ZombiesTypes();
            ClearingLine clearing = new ClearingLine();
            while (isPlayerAlive)
            {
                if (isPlayerHaveKidHelper == false)
                {
                    actionType = new Random().Next(1, 10);
                }
                else
                {
                    actionType = new Random().Next(2, 10);
                }
                bool isPlayerWinner = false;
                switch (actionType)
                {
                    case 1:
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
                                continue;
                            }
                            else if (chanceToGetKidHelper >= 97 && chanceToGetKidHelper <= 99) // 3% chance to have helper
                            {
                                Console.WriteLine("The kid is soo appreciated!");
                                Console.WriteLine("He wants to be your partner in this journey!");
                                Console.WriteLine("He's name is Will.");
                                isPlayerHaveKidHelper = true;
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
                    case 10:
                        zombieTypes.ZombieBoss();
                        break;

                } // Under working !

                if (actionType != 1)
                {
                    Console.WriteLine($"{Player.playerName} you've met an {ZombiesTypes.zombieType} with {ZombiesTypes.zombieHealth} Health and {ZombiesTypes.zombieDamage} Attack.");
                    //Thread.Sleep(2000);
                    clearing.ClearingLines();
                    Console.WriteLine($"Be careful {Player.playerName}! Good luck!");
                    //Thread.Sleep(1000);
                    clearing.ClearingLines();
                }

                while (isPlayerAlive && !isPlayerWinner)
                {
                    Console.WriteLine($"Weapon: [{Player.currentWeapon}] | " +
                                              $"{ Environment.NewLine}" +
                                              $"Helmet: [{Player.currentHelmet}] | " +
                                              $"Chestplate: [{Player.currentChestplate}] | " +
                                              $"Pants: [{Player.currentPants}] | " +
                                              $"Boots: [{Player.currentBoots}]");
                    Console.WriteLine();

                    Console.WriteLine($" Player LVL: [{Player.playerLevel}]  -  EXP: [{Player.playerExp}/100]                                                            ");
                    Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{Player.playerHealth}]      ");
                    Console.WriteLine($"║#=# Choose an action to  do: #=#║           ║Current Deffence: []   ");
                    Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{Player.weaponDamage}]      ");
                    Console.WriteLine($"║ [0] - Fight with the zombie.   ║           ║Current Coins: [{Player.playerCoins}]        ");
                    Console.WriteLine($"║ [1] - Run Away from the zombie.║           ║Zombie Name : [{ZombiesTypes.zombieType}]        ");
                    Console.WriteLine($"║ [2] - Hide somewhere.          ║           ║Zombie HP: [{ZombiesTypes.zombieHealth}]         ");
                    Console.WriteLine($"╚════════════════════════════════╝           ║Zombie Attack: [{ZombiesTypes.zombieDamage}]");

                    Console.Write(">>");
                    int actionToDo = int.Parse(Console.ReadLine());
                    while (actionToDo < 0 || actionToDo > 2)
                    {
                        Console.WriteLine($"                     Please enter an valid operation-{Player.playerName}! :");
                        Console.WriteLine();
                        Console.WriteLine($" Player LVL: [{Player.playerLevel}]  -  EXP: [{Player.playerExp}/100]                                                            ");
                        Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{Player.playerHealth}]      ");
                        Console.WriteLine($"║#=# Choose an action to  do: #=#║           ║Current Deffence: []   ");
                        Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{Player.weaponDamage}]      ");
                        Console.WriteLine($"║ [0] - Fight with the zombie.   ║           ║Current Coins: [{Player.playerCoins}]        ");
                        Console.WriteLine($"║ [1] - Run Away from the zombie.║           ║Zombie Name : [{ZombiesTypes.zombieType}]        ");
                        Console.WriteLine($"║ [2] - Hide somewhere.          ║           ║Zombie HP: [{ZombiesTypes.zombieHealth}]         ");
                        Console.WriteLine($"╚════════════════════════════════╝           ║Zombie Attack: [{ZombiesTypes.zombieDamage}]");
                        actionToDo = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }
                    if (actionToDo == 0)
                    {
                        while (isPlayerAlive && !isPlayerWinner)
                        {
                            ZombiesTypes.zombieHealth -= Player.weaponDamage;
                            Player.playerHealth -= ZombiesTypes.zombieDamage;
                            if (Player.playerHealth <= 0)
                            {
                                Console.WriteLine($"Sorry {Player.playerName} .. you are dead.");
                                isPlayerAlive = false;
                                break;
                            }
                            else if (ZombiesTypes.zombieHealth <= 0)
                            {
                                Console.WriteLine($"Good job {Player.playerName} , you killed" +
                                    $"{Environment.NewLine}successfully {ZombiesTypes.zombieType}.");
                                Console.WriteLine();
                                Console.WriteLine($"{Player.playerName} your reward is:");
                                Console.WriteLine($"+10 Food");
                                Console.WriteLine($"+10 Health");
                                Console.WriteLine($"+5 Attack");
                                Console.WriteLine($"+10 Exp");
                                Console.WriteLine($"+10 Coins");
                                Player.playerFood += 10;
                                Player.playerHealth += 10;
                                Player.weaponDamage += 5;
                                Player.playerExp += 10;
                                Player.playerCoins += 10;

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
                                    Player.weaponDamage += 5;
                                    Player.playerHealth += 10;
                                    Player.playerExp -= 100;
                                    Player.playerCoins += 10;

                                    Console.WriteLine($"New Level : {Player.currentPlayerLevel} -> {Player.playerLevel}");
                                    Player.currentPlayerLevel = Player.playerLevel;
                                }
                                isPlayerWinner = true;
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
            Console.WriteLine($"║Health Diff: [{Math.Abs(Player.playerHealth)}]      ");
            Console.WriteLine($"║Last Weapon: [{Player.weaponName}]  CLASS: [{Player.weaponClass}]      ");
            Console.WriteLine($"║Current Coins: [{Player.playerCoins}]        ");
            Console.WriteLine("          You lost VS:                              ");
            Console.WriteLine($"║Zombie Name : [{ZombiesTypes.zombieType}]    ");
            Console.WriteLine($"║Zombie HP: [{ZombiesTypes.zombieHealth}]       ");
            Console.WriteLine($"║Zombie Attack: [{ZombiesTypes.zombieDamage}] ");
        }
    }
    public class Shop
    {

    }
    public class ClearingLine
    {
        public void ClearingLines()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
           // Thread.Sleep(4500);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}
