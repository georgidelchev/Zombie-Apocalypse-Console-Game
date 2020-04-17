using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
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
}
