using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck : IDeck
    {
        public List<Cards> cardList
        {
            get
            {
                return CardList;
            }
        }

        public List<Cards> CardList = new List<Cards>();

        public Deck()
        {
            // Hearts
            CardList.Add(new Cards("Hearts", "Two", 2));
            CardList.Add(new Cards("Hearts", "Three", 3));
            CardList.Add(new Cards("Hearts", "Four", 4));
            CardList.Add(new Cards("Hearts", "Five", 5));
            CardList.Add(new Cards("Hearts", "Six", 6));
            CardList.Add(new Cards("Hearts", "Seven", 7));
            CardList.Add(new Cards("Hearts", "Eight", 8));
            CardList.Add(new Cards("Hearts", "Nine", 9));
            CardList.Add(new Cards("Hearts", "Ten", 10));
            CardList.Add(new Cards("Hearts", "Jack", 10));
            CardList.Add(new Cards("Hearts", "Queen", 10));
            CardList.Add(new Cards("Hearts", "King", 10));
            CardList.Add(new Cards("Hearts", "Ace", 11));

            // Diamond
            CardList.Add(new Cards("Diamond", "Two", 2));
            CardList.Add(new Cards("Diamond", "Three", 3));
            CardList.Add(new Cards("Diamond", "Four", 4));
            CardList.Add(new Cards("Diamond", "Five", 5));
            CardList.Add(new Cards("Diamond", "Six", 6));
            CardList.Add(new Cards("Diamond", "Seven", 7));
            CardList.Add(new Cards("Diamond", "Eight", 8));
            CardList.Add(new Cards("Diamond", "Nine", 9));
            CardList.Add(new Cards("Diamond", "Ten", 10));
            CardList.Add(new Cards("Diamond", "Jack", 10));
            CardList.Add(new Cards("Diamond", "Queen", 10));
            CardList.Add(new Cards("Diamond", "King", 10));
            CardList.Add(new Cards("Diamond", "Ace", 11));

            //Clubs
            CardList.Add(new Cards("Clubs", "Two", 2));
            CardList.Add(new Cards("Clubs", "Three", 3));
            CardList.Add(new Cards("Clubs", "Four", 4));
            CardList.Add(new Cards("Clubs", "Five", 5));
            CardList.Add(new Cards("Clubs", "Six", 6));
            CardList.Add(new Cards("Clubs", "Seven", 7));
            CardList.Add(new Cards("Clubs", "Eight", 8));
            CardList.Add(new Cards("Clubs", "Nine", 9));
            CardList.Add(new Cards("Clubs", "Ten", 10));
            CardList.Add(new Cards("Clubs", "Jack", 10));
            CardList.Add(new Cards("Clubs", "Queen", 10));
            CardList.Add(new Cards("Clubs", "King", 10));
            CardList.Add(new Cards("Clubs", "Ace", 11));

            //Spades
            CardList.Add(new Cards("Spades", "Two", 2));
            CardList.Add(new Cards("Spades", "Three", 3));
            CardList.Add(new Cards("Spades", "Four", 4));
            CardList.Add(new Cards("Spades", "Five", 5));
            CardList.Add(new Cards("Spades", "Six", 6));
            CardList.Add(new Cards("Spades", "Seven", 7));
            CardList.Add(new Cards("Spades", "Eight", 8));
            CardList.Add(new Cards("Spades", "Nine", 9));
            CardList.Add(new Cards("Spades", "Ten", 10));
            CardList.Add(new Cards("Spades", "Jack", 10));
            CardList.Add(new Cards("Spades", "Queen", 10));
            CardList.Add(new Cards("Spades", "King", 10));
            CardList.Add(new Cards("Spades", "Ace", 11));
        }

        public void Draw(int i)
        {
            CardList.RemoveAt(i);
        }

        public void Add(Cards card)
        {
            CardList.Add(card);
        }

        public void getTotal()
        {
            throw new NotImplementedException();
        }

        public int Average()
        {
            int count = 0;
            int a = 0;
            for (int i = 0; i < CardList.Count; i++)
            {
                count += CardList[i].value;
                a++;
            }
            return count / a;
        }

        public int ChanceExact(int card)
        {
            int amount = 0;
            for (int i = 0; i < CardList.Count; i++)
            {
                if (card == CardList[i].value)
                {
                    amount++;
                }
            }
            int output = (int)Math.Round((double)(100 * amount) / CardList.Count);
            return output;
        }
        

        public Cards RandomCard()
        {
            return null;
        }
    }
}
