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
            throw new NotImplementedException();
        }

        public void Add(Cards card)
        {
            throw new NotImplementedException();
        }

        public void getTotal()
        {
            throw new NotImplementedException();
        }

        public int Average()
        {
            throw new NotImplementedException();
        }
        
        public int ChanceExact(int card)
        {
            throw new NotImplementedException();
        }

        public Cards RandomCard()
        {
            throw new NotImplementedException();
        }
    }
}
