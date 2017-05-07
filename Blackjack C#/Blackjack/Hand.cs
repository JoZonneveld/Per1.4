using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Hand : IDeck
    {
        public List<Cards> Playerhand = new List<Cards>();

        public List<Cards> cardList
        {
            get { return Playerhand; }
        }

        public void Draw(int i)
        {
            Playerhand.RemoveAt(i);
        }

        public void Add(Cards card)
        {
            Playerhand.Add(card);
        }

        public int getTotal()
        {
            int output = 0;
            for (int i = 0; i < Playerhand.Count; i++)
            {
                output += Playerhand[i].value;
            }
            return output;
        }

        public int Average()
        {
            int count = 0;
            int a = 0;
            for (int i = 0; i < Playerhand.Count; i++)
            {
                count += Playerhand[i].value;
                a++;
            }
            return count / a;
        }
        
        public int ChanceExact(int card)
        {
            throw new NotImplementedException();
        }
    }
}
