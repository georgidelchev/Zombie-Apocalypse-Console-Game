using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZombieApocalypse
{
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
}
