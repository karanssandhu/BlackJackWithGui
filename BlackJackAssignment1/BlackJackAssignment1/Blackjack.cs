// BlackJack Asssignment 1
// Made By:
// Aryan Arora 
// Karan Singh Sandhu

using System;
using System.Collections.Generic;

namespace BlackjackNS
{
    public class Blackjack
    {
        Deck deck = new Deck();
        public List<Card> Playercards = new List<Card>();
        public List<Card> Dealercards = new List<Card>();
        public int playerSum;

        public int Hit()
        {
            DealCardToPlayer();
            if (GetPlayerSum() > 21)
            {
                return 0;
            }

            if (GetPlayerSum() == 21)
            {
                return -1;
            }

            return 1;
        }
        public int Stand()
        {
            while (GetDealerSum() < 15)
            {
                DealCardToDealer();
            }
            if (GetDealerSum() > 21)
            {
                return 0;
            }
            if (GetDealerSum() == GetPlayerSum())
            {
                return 1;
            }
            if (GetDealerSum() > GetPlayerSum())
            {
                return 2;
            }
            return 0;
        }
        public void Start()
        {
            DealCardToPlayer();
            DealCardToDealer();
            DealCardToPlayer();
            DealCardToDealer();
        }


        public void End()
        {

            Playercards.Clear();
            Dealercards.Clear();
            deck = new Deck();

        }

        public void DealCardToPlayer()
        {
            Card c = deck.GetTopCard();
            Playercards.Add(c);
        }
        public void DealCardToDealer()
        {
            Card c = deck.GetTopCard();
            Dealercards.Add(c);
        }

        public List<Card> GetPlayerCards()
        {
            return Playercards;
        }
        public List<Card> GetDealerCards()
        {
            return Dealercards;
        }
        internal int GetPlayerSum()
        {
            int sum = 0;
            foreach (Card c in Playercards)
            {
                sum += GetBlackjackValue(c);
              
            }
            playerSum  = sum;
            
            if (playerSum > 21)
            {
                sum = 0;
                foreach (Card c in Playercards)
                {
                    sum += GetBlackjackValue(c);

                }
            }
            playerSum = sum;
            return sum;
        }

        internal int GetDealerSum()
        {
            int sum = 0;
            foreach (Card c in Dealercards)
            {
                sum += GetBlackjackValue(c);
            }

            return sum;
        }

        internal int GetDealerSum(bool isDealing)
        {
            int count = 0;
            int sum = 0;
            if (isDealing)
            {
                foreach (Card c in Dealercards)
                {
                    if (count == 0)
                    {
                        sum += GetBlackjackValue(c);
                    }
                    count++;
                }
            }

            return sum;
        }

        public int GetBlackjackValue(Card c)
        {
           
            if (c.Rank == 1)
            {
                if ( playerSum<= 21)
                {
                   
                    return 11;
                }
                else{
                    c.Rank = 1;
                    return 1;
                }
            }

            if (c.Rank > 10)
            {
                return 10;
            }
            else
            {
                return c.Rank;
            }

        }

    }
}
