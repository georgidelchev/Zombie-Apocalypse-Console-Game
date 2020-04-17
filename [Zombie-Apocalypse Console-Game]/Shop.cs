using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
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
                    Console.WriteLine("[2] - FOOD/FUEL");
                    Console.WriteLine("[3] - ENERGY DRINKS");
                    Console.WriteLine("[4] - EXIT");
                    Console.Write(">> ");

                    int pick = int.Parse(Console.ReadLine());
                    while (pick < 0 || pick > 3)
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
                        Console.WriteLine($"        Current gold: " +
                                                    $"{Player.playerCoins}    ");
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
                    else if (pick == 1)
                    {
                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine();
                        Console.WriteLine($"      ╔══════════════════════╗");
                        Console.WriteLine($"        Current gold: " +
                                                    $"{Player.playerCoins}     ");
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
                    else if (pick == 2)
                    {
                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine();
                        Console.WriteLine($"      ╔══════════════════════╗");
                        Console.WriteLine($"        Current gold: " +
                                                    $"{Player.playerCoins}     ");
                        Console.WriteLine($"      ╚══════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");
                        Console.WriteLine($"║     #=# FOOD/FUEL MENU #=#     ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[0] -  30 FOOD - [50G]          ║");
                        Console.WriteLine($"║          [+10 food]            ║");
                        Console.WriteLine($"║[1] -  50 FOOD - [80G]          ║");
                        Console.WriteLine($"║          [+50 food]            ║");
                        Console.WriteLine($"║[2] -  100 FOOD - [110G]        ║");
                        Console.WriteLine($"║          [+100 food]           ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[3] -  100 FUEL - [200G]        ║");
                        Console.WriteLine($"║          [+100 fuel]           ║");
                        Console.WriteLine($"║[4] -  200 FUEL - [500G]        ║");
                        Console.WriteLine($"║          [+200 dmg]            ║");
                        Console.WriteLine($"╚════════════════════════════════╝");
                        Console.WriteLine($"   [5] - EXIT | [6] - PREV. PAGE  ");

                        int order = int.Parse(Console.ReadLine());
                        while (order < 0 || order > 6)
                        {
                            Console.WriteLine($"Please enter an valid operation-{Player.playerName}! :");
                            Console.Write(">> ");
                            order = int.Parse(Console.ReadLine());
                        }

                        if (order == 6)
                        {
                            goto case 0;
                        }
                        else if (order == 5)
                        {
                            break;
                        }
                        else if (order == 4)
                        {
                            if (Player.playerCoins >= 500)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 200 FUEL!");
                                Player.playerCoins -= 500;
                                Player.fuel += 200;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {500 - Player.playerCoins} more");
                            }
                        }
                        else if (order == 3)
                        {
                            if (Player.playerCoins >= 200)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 100 FUEL!");
                                Player.playerCoins -= 200;
                                Player.fuel += 100;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {500 - Player.playerCoins} more");
                            }
                        }
                        else if (order == 2)
                        {
                            if (Player.playerCoins >= 110)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 100 FOOD!");
                                Player.playerCoins -= 110;
                                Player.playerFood += 100;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {110 - Player.playerCoins} more");
                            }
                        }
                        else if (order == 1)
                        {
                            if (Player.playerCoins >= 80)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 50 FOOD!");
                                Player.playerCoins -= 80;
                                Player.playerFood += 50;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {110 - Player.playerCoins} more");
                            }
                        }
                        else if (order == 0)
                        {
                            if (Player.playerCoins >= 50)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 30 FOOD!");
                                Player.playerCoins -= 50;
                                Player.playerFood += 30;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {110 - Player.playerCoins} more");
                            }
                        }
                    }
                    else if (pick == 3)
                    {
                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine();
                        Console.WriteLine($"      ╔══════════════════════╗");
                        Console.WriteLine($"        Current gold: " +
                                                    $"{Player.playerCoins}     ");
                        Console.WriteLine($"      ╚══════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");
                        Console.WriteLine($"║   #=# ENERGY DRINKS MENU #=#   ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[0] -  10 Cans - [100G]         ║");
                        Console.WriteLine($"║          [+25 HP]              ║");
                        Console.WriteLine($"║[1] -  25 Cans - [200G]         ║");
                        Console.WriteLine($"║          [+65 HP]              ║");
                        Console.WriteLine($"║[2] -  50 Cans - [330G]         ║");
                        Console.WriteLine($"║          [+100 HP]             ║");
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
                            if (Player.playerCoins >= 330)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 50 Cans!");
                                Player.playerCoins -= 330;
                                Player.playerHealth += 100;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {330 - Player.playerCoins} more");
                            }
                        }
                        else if (order == 1)
                        {
                            if (Player.playerCoins >= 200)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 20 Cans!");
                                Player.playerCoins -= 200;
                                Player.playerHealth += 65;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {200 - Player.playerCoins} more");
                            }
                        }
                        else if (order == 0)
                        {
                            if (Player.playerCoins >= 100)
                            {
                                Console.WriteLine($"{Player.playerName} you just bought 10 Cans!");
                                Player.playerCoins -= 100;
                                Player.playerHealth += 25;
                            }
                            else
                            {
                                Console.WriteLine($"{Player.playerName} you dont have enough money!" +
                                    $"{Environment.NewLine}You need {110 - Player.playerCoins} more");
                            }
                        }

                    }

                    break;
            }
        }

    }
}
