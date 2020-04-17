using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
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
            Console.WriteLine("This is zombie apocalypse game , you will fight with several zombies with different difficulty.");
            Thread.Sleep(1500);
            Console.WriteLine("There is a chance to find a car,kid and a dog.");
            Thread.Sleep(1500);
            Console.WriteLine("With the car you can go to 4 locations with different rewards each.");
            Thread.Sleep(1500);
            Console.WriteLine("When you find a kid,he will be your partner in this journey.He is dealing bonus damage to the monsters.");
            Thread.Sleep(1500);
            Console.WriteLine("When you find a dog he also will be your partner , he is dealing some damage to the zombies and eating some of your food");
            Thread.Sleep(1500);
            Console.WriteLine("Good luck!");
            Thread.Sleep(1500);
            Console.WriteLine();
        }
        public void Story()
        {
            Console.Clear();
            Console.WriteLine();

            Console.CursorVisible = false;

            string[] first = {$"{Player.playerName}"," ","you"," ","are"," ","a"," ","cop"," ",
                "shooted"," ","by"," ","a"," ","thief",".","\n", // first line
            "You've"," ","been",""," ","in"," ","a"," ","hospital"," ",
                "for"," ","ten"," ","months"," ","in"," ","a"," ","coma",".","\n", // second line
            "One"," ","day"," ","you"," ","wake"," ","up",","," ","but"," ",
                "there"," ","is"," ","no"," ","one",".","\n", // third line
                "You"," ","decided"," ","to"," ","look"," ","around","."," ",
                "You"," ","took"," ","your"," ","clothes"," ","and"," ","dressed"," ",
                "then"," ","you"," ","toured"," ","the"," ","hospital",".","\n", // forth line
                "YIKES"," ","the"," ","hospital"," ","is"," ","ruined",","," ",
                "full"," ","of"," ","dead"," ","bodies",".","\n",// fifth line
                "Lets's"," ","go"," ","Outside"," ",$"{Player.playerName}",".","\n", //sixth line
                "There"," ","is"," ","full"," ","of"," ","crashed"," ","cars",","," ","bodies,","\n",
                "dirty"," ","streets"," ","and"," ","ruined"," ","houses",".",".",".","\n", //seventh line
                "What"," ","is"," ","happening"," ","here","???","\n",//eighth line
                "Let's"," ","find"," ","out"," ","and"," ","try"," ","to"," ","survive"," ","this.",
            };

            for (int i = 0; i < first.Length; i++)
            {
                Console.Write($"{first[i]}");
                Thread.Sleep(130);
            }
        }
    }
}
