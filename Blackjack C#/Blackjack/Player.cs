using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player : IPlayer
    {
        public string Name { get; }
        public IDeck Hand { get; }

        public Player(string name)
        {
            this.Name = name;
            this.Hand = new Hand();
        }
        
        public int CheckHand()
        {
            int output = 0;

            for (int i = 0; i < this.Hand.cardList.Count; i++)
            {
                output += this.Hand.cardList[i].value;
            }

            return output;
        }

        
    }
}
