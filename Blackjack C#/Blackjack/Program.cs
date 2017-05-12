using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        public static void End()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            bool Game = true;
            Console.Out.WriteLine("Tell me your name");
            string Name = Console.ReadLine();

            while (Game)
            {
                
                Game game = new Game(Name);
                game.StartGame();
                

                if (game.player.CheckHand() == 21 || game.bot.CheckHand() == 21)
                {
                    game.gameState = false;
                }

                while (game.gameState)
                {
                    Console.Clear();
                    game.CheckHands();
                    if (game.Player)
                    {
                        Console.Out.WriteLine("Wilt u nog een kaart?");
                        ConsoleKeyInfo card = Console.ReadKey();

                        if (card.KeyChar == 'y')
                        {
                            game.Draw(game.player);
                            game.Bot = game.DrawOnChance(game.bot);

                        }
                        else
                        {
                            game.Player = false;
                            game.Bot = game.DrawOnChance(game.bot);
                        }
                    }
                    else if (game.Bot)
                    {
                        game.Bot = game.DrawOnChance(game.bot);
                    }
                    else
                    {
                        game.gameState = false;
                    }

                    if (game.player.CheckHand() == 21 || game.bot.CheckHand() == 21 || game.player.CheckHand() > 21 || game.bot.CheckHand()>21)
                    {
                        break;
                    }
                }

                Console.Clear();

                game.Winner();

                Console.Out.WriteLine("Do you wanna play another game?");
                ConsoleKeyInfo again = Console.ReadKey();

                if (again.KeyChar == 'n')
                {
                    Game = false;
                }
            }
        }
    }
}
