using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }

        

        //Metodos


        public void AddCombatCard(CombatCard combatCard, int playerId)
        {
            string typeOfCard = combatCard.Type;
            if (typeOfCard == "melee")
            {
                this.meleeCards[playerId].Add(combatCard);
            }
            else if (typeOfCard == "range")
            {
                this.rangeCards[playerId].Add(combatCard);
            }
            else if (typeOfCard == "long range")
            {
                this.longRangeCards[playerId].Add(combatCard);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        

        public void AddMeleeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddLongRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }


        public void DestroyCombatCard(int playerId)
        {
            this.meleeCards[playerId].Clear();
            this.rangeCards[playerId].Clear();
            this.longRangeCards[playerId].Clear();
        }

        public void DestroySpecialCard(int playerId)
        {
            this.specialMeleeCards[playerId].Clear();
            this.specialRangeCards[playerId].Clear();
            this.specialLongRangeCards[playerId].Clear();
         }



        public void DestroyMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyWeatherCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public int[] GetMeleeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
    }
}
