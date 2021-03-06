﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        public IPlayer player;
        public IPlayer bot;
        public IDeck Deck;
        public bool gameState;
        public bool Player;
        public bool Bot;

        public Game(string name)
        {
            this.player = new Player(name);
            this.bot = new Player("Hans");
            this.Deck = new Deck();
            this.gameState = true;
            this.Player = true;
            this.Bot = true;
        }

        private int Random()
        {
            Random rnd = new Random();
            int output = rnd.Next(Deck.cardList.Count);
            Console.WriteLine(output);
            return output;
        }

        public void StartGame()
        {
            for (int i = 0; i < 2; i++)
            {
                Random rnd = new Random();

                int r1 = rnd.Next(Deck.cardList.Count);
                int r2 = rnd.Next(Deck.cardList.Count);

                player.Hand.cardList.Add(Deck.cardList[r1]);
                bot.Hand.cardList.Add(Deck.cardList[r2]);

                Deck.Draw(r1);
                Deck.Draw(r2);
            }
        }

        public void Draw(IPlayer drawPlayer)
        {
            int i = Random();
            Cards card = Deck.cardList[i];
            drawPlayer.Hand.Add(card);
            Deck.cardList.RemoveAt(i);
        }

        public bool DrawOnChance(IPlayer drawPlayer)
        {
            int diff = 21 - drawPlayer.CheckHand();

            if (Player == false)
            {
                if (player.CheckHand() > 21)
                {
                    return false;
                }
                else if (player.CheckHand() < bot.CheckHand())
                {
                    return false;
                }
                else if (player.CheckHand() == bot.CheckHand() && Deck.ChanceSave(diff) == 100)
                {
                    Draw(drawPlayer);
                    return true;
                }
                else if (player.CheckHand() > bot.CheckHand())
                {
                    Draw(drawPlayer);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Player)
            {
                if (player.CheckHand() > 21)
                {
                    return false;
                }
                else if (player.CheckHand() < bot.CheckHand())
                {
                    return false;
                }
                else if (player.CheckHand() > bot.CheckHand())
                {
                    Draw(drawPlayer);
                    return true;
                }
                else if (player.CheckHand() == bot.CheckHand() && Deck.ChanceSave(diff) == 100)
                {
                    Draw(drawPlayer);
                    return true;
                }
                else if (Deck.ChanceSave(diff) == 100)
                {
                    Draw(drawPlayer);
                    return true;
                }
                else if ((Deck.ChanceExact(diff) > 75 || Deck.ChanceSave(diff) > 50))
                {
                    Draw(drawPlayer);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void CheckHands()
        {
            Console.Out.WriteLine(player.Name + "'s hand: " + player.CheckHand());
        }

        public void Winner()
        {
            if (player.CheckHand() < 22 && bot.CheckHand() < 22)
            {
                if (player.CheckHand() > bot.CheckHand())
                {
                    Console.Out.WriteLine(player.Name + " is the winner");
                    Console.Out.WriteLine(player.Name + "'s hand: " + player.CheckHand());
                    Console.Out.WriteLine("Bots hand: " + bot.CheckHand());
                }
                else if (player.CheckHand() < bot.CheckHand())
                {
                    Console.Out.WriteLine("The bot wins");
                    Console.Out.WriteLine(player.Name + "'s hand: " + player.CheckHand());
                    Console.Out.WriteLine("Bots hand: " + bot.CheckHand());
                }
                else if (player.CheckHand() == bot.CheckHand())
                {
                    Console.Out.WriteLine("Draw!");
                    Console.Out.WriteLine(player.Name + "'s hand: " + player.CheckHand());
                    Console.Out.WriteLine("Bots hand: " + bot.CheckHand());
                }
            }
            else if (player.CheckHand() > 21 && bot.CheckHand() > 21)
            {
                Console.Out.WriteLine("Draw!");
                Console.Out.WriteLine(player.Name + "'s hand: " + player.CheckHand());
                Console.Out.WriteLine("Bots hand: " + bot.CheckHand());
            }
            else if (player.CheckHand() > 21)
            {
                Console.Out.WriteLine("The bot wins");
                Console.Out.WriteLine(player.Name + "'s hand: " + player.CheckHand());
                Console.Out.WriteLine("Bots hand: " + bot.CheckHand());
            }
            else if (bot.CheckHand() > 21)
            {
                Console.Out.WriteLine(player.Name + " is the winner");
                Console.Out.WriteLine(player.Name + "'s hand: " + player.CheckHand());
                Console.Out.WriteLine("Bots hand: " + bot.CheckHand());
            }
        }
    }
}
