using System;
using System.Threading;

namespace ZombieApocalypse
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Zombie Apocalypse v1.0"; // console title

            // resizing console
            for (int i = 1; i <= 120; i++)
            {
                Console.SetWindowSize(i, 40);
                Thread.Sleep(20);
            }

            Player player = new Player();                                    // -\
            BeginningInformation welcomeInfo = new BeginningInformation();   //   |
            Fighting fighting = new Fighting();                              //   |=> declaring the classes
            GameOver gameOver = new GameOver();                              //   |
            ClearingLine clr = new ClearingLine();                           //   |
            ZombieApocalypse text = new ZombieApocalypse();                  // -/

            welcomeInfo.Information();

            Console.WriteLine($"Press any key to continue!");
            Console.ReadKey(); // reading key

            text.Zombie(); // starting message Zombie Apocalypse + more messages
            Thread.Sleep(2000); // 2 seconds cooldown

            welcomeInfo.WelcomeInfo(); // welcome info + more messages
            player.PlayerName(); // message to enter your name 
            welcomeInfo.Story(); // story

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"{Player.playerName} press any key to continue!");
            Console.ReadKey(); // reading key
            clr.ClearingLines(); // clearing lines
            Console.Clear(); // clearing all the console

            Console.WriteLine($"Hello {Player.playerName}! Nice to meet you!"); // hello message
            Console.WriteLine(); // empty line

            fighting.Fight(); // whole fight logic
            gameOver.Over(); // when game is over statistics,info etc..
        }
    }
    public class ClearingLine
    {
        public void ClearingLines()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Thread.Sleep(4500);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}