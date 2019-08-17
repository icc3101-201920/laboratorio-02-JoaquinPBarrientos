using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Hand : Deck
    {
        private const int MAX_HAND_CARDS = 5;
       

        public Hand(List<CombatCard> cc,  List<SpecialCard> sc) :base(cc,sc)
        {
        }


        
    }
}

