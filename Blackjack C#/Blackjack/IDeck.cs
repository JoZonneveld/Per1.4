﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    // interface for Hand & Deck
    interface IDeck
    {
        List<Cards> cardList { get; }

        void Draw(int i);
        void Add(Cards card);
        int getTotal();
        int Average();
        int ChanceExact(int card);
        int ChanceSave(int Hand);
    }
}
