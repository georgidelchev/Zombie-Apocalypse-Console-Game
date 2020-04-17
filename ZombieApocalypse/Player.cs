using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
    public class Player
    {
        // PLAYER STATS
        public static string playerName;  // the name of the Player       
        public static double playerFood = 30;  // amount of food that Player have
        public static double playerHunger = 100;
        public static double playerHealth = 175; // health of the player
        public static double playerCoins = 25; // current Player coins
        public static int playerLevel = 0; // current Player level
        public static int currentPlayerLevel = playerLevel;
        public static double playerExp = 0; // current Player Exp
        public static string currentHelmet = string.Empty;
        public static string currentChestplate = string.Empty;
        public static string currentPants = string.Empty;
        public static string currentBoots = string.Empty;
        public static double playerDeffence = 50;
        public static double fuel = 200;

        // RANDOMIZED WEAPON
        public static int playerWeapon;   // player's weapon randomized

        // WEAPON STATS
        public static string currentWeapon = string.Empty; // current weapon of the Player
        public static string weaponName; // the name of the weapon
        public static double weaponDamage; // the damage of the weapon
        public static string weaponClass; // the quality class of the weapon
        public static double currDamage;
        public static double currClass;

        // TAKEN AND DEALED DAMAGE
        public static double dealtDamage = 0;
        public static double tookDamage = 0;

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
}
