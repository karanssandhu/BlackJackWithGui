// BlackJack Asssignment 1
// Made By:
// Aryan Arora 
// Karan Singh Sandhu



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackNS
{
    public class Card
    {
        public String Suit;
        public int Rank;

        public Card(String suit, int rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public string GetName()
        {   
            if(Rank == 11)
            {
                return "Jack of " + Suit;
            }

            if (Rank == 12)
            {
                return "Queen of " + Suit;
            }

            if (Rank == 13)
            {
                return "King of " + Suit;
            }

            if (Rank == 1)
            {
                return "Ace of " + Suit;
            }

            else {
                return Rank + " of " + Suit; 
            }
        }

        public string GetFileName()
        {

            string blackjackRank = Rank.ToString();
            if (Rank == 1)
            {
                blackjackRank = "ace";
            }
            else if (Rank == 11)
            {
                blackjackRank = "jack";
            }
            else if (Rank == 12)
            {
                blackjackRank = "queen";
            }
            else if (Rank == 13)
            {
                blackjackRank = "king";
            }

            return blackjackRank + "_of_" + Suit + ".png";
        }
        public int GetValue()
        {
            if (Rank > 10)
            {
                return 10;
            }
            return Rank;
        }


    }
}
