using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
    public class ZombieApocalypse
    {
        public void Zombie()
        {
            Console.ForegroundColor = ConsoleColor.Red; // making console text color in red

            string[] zombie = new string[]
                                        {"                                                                              ",
                                         "                                ███████╗░█████╗░███╗░░░███╗██████╗░██╗███████╗",
                                         "                                ╚════██║██╔══██╗████╗░████║██╔══██╗██║██╔════╝",
                                         "                                ░░███╔═╝██║░░██║██╔████╔██║██████╦╝██║█████╗░░",
                                         "                                ██╔══╝░░██║░░██║██║╚██╔╝██║██╔══██╗██║██╔══╝░░",
                                         "                                ███████╗╚█████╔╝██║░╚═╝░██║██████╦╝██║███████╗",
                                         "                                ╚══════╝░╚════╝░╚═╝░░░░░╚═╝╚═════╝░╚═╝╚══════╝",
                                         "                                                                                                ",
                                         "               ░█████╗░██████╗░░█████╗░░█████╗░░█████╗░██╗░░░░░██╗░░░██╗██████╗░░██████╗███████╗",
                                         "               ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░╚██╗░██╔╝██╔══██╗██╔════╝██╔════╝",
                                         "               ███████║██████╔╝██║░░██║██║░░╚═╝███████║██║░░░░░░╚████╔╝░██████╔╝╚█████╗░█████╗░░",
                                         "               ██╔══██║██╔═══╝░██║░░██║██║░░██╗██╔══██║██║░░░░░░░╚██╔╝░░██╔═══╝░░╚═══██╗██╔══╝░░",
                                         "               ██║░░██║██║░░░░░╚█████╔╝╚█████╔╝██║░░██║███████╗░░░██║░░░██║░░░░░██████╔╝███████╗",
                                         "               ╚═╝░░╚═╝╚═╝░░░░░░╚════╝░░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░░░░╚═════╝░╚══════╝"};

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
}
