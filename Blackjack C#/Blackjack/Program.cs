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
            IDeck deck = new Deck();
            IPlayer player = new Player("Joost");

            Console.WriteLine(player.Hand.cardList.Count);

            Console.Out.WriteLine(deck.ChanceExact(10) + "%");

            End();
        }
    }
}
