using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
    public class GameOver
    {
        public void Over()
        {
            Console.Clear();

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red; // making console text color in red

            string[] gameOvr = new string[]
                                        {"                                                                          ",
                                         "                                      ░██████╗░░█████╗░███╗░░░███╗███████╗",
                                         "                                      ██╔════╝░██╔══██╗████╗░████║██╔════╝",
                                         "                                      ██║░░██╗░███████║██╔████╔██║█████╗░░",
                                         "                                      ██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░",
                                         "                                      ╚██████╔╝██║░░██║██║░╚═╝░██║███████╗",
                                         "                                      ░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝",
                                         "                                                                         ",
                                         "                                        ░█████╗░██╗░░░██╗███████╗██████╗░",
                                         "                                        ██╔══██╗██║░░░██║██╔════╝██╔══██╗",
                                         "                                        ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝",
                                         "                                        ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗",
                                         "                                        ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║",
                                         "                                        ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝"};

            for (int i = 0; i < 5; i++)
            {
                foreach (string value in gameOvr)
                {
                    Console.WriteLine(value);
                }
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.Clear();

            foreach (string value in gameOvr)
            {
                Console.WriteLine(value);
            }
            Thread.Sleep(5000);
            Console.WriteLine();

            string[] key = {
                "                                            ",
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
            Console.WriteLine();

            Console.WriteLine($"╔════════════════════════════════╗");
            Console.WriteLine($"║     #=# DEAD STATISTICS #=#    ║");
            Console.WriteLine($"╚════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine($"   ■ Your level: [{Player.playerLevel}]");
            Console.WriteLine($"   ■ Health Diff: [{Math.Abs(Player.playerHealth)}]");
            Console.WriteLine($"   ■ Food left: [{Player.playerFood}]");
            Console.WriteLine($"   ■ Last Weapon: [{Player.currentWeapon}]");
            Console.WriteLine($"   ■ Weapon CLASS: [{Player.currClass}]");
            Console.WriteLine();
            Console.WriteLine($"   ■ Dog: {PlayerHelper.isPlayerHaveDogHelper}");
            Console.WriteLine($"   ■ Kid: {PlayerHelper.isPlayerHaveKidHelper}");
            Console.WriteLine();
            Console.WriteLine($"   ■ Zombie Name : [{ZombiesTypes.zombieType}]");
            Console.WriteLine($"   ■ Zombie HP Diff: [{Math.Abs(ZombiesTypes.zombieHealth)}]");
            Console.WriteLine($"   ■ Zombie Attack: [{ZombiesTypes.zombieDamage}]");
            Console.WriteLine();
            Console.WriteLine($"   ■ Helmet: [{Player.currentHelmet}]");
            Console.WriteLine($"   ■ Chestplate: [{Player.currentChestplate}]");
            Console.WriteLine($"   ■ Pants: [{Player.currentPants}]");
            Console.WriteLine($"   ■ Boots: [{Player.currentBoots}]");
            Console.WriteLine();
            Console.WriteLine($"   ■ Taken Damage: [{Player.tookDamage}]");
            Console.WriteLine($"   ■ Dealed Damage: [{Player.dealtDamage}]");
        }
    }
}
