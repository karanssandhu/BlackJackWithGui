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
    public class Deck
    {
        List<Card> cards = new List<Card>();
        public Deck()
        {
            Init();
            Shuffle();
        }

        private void Init()
        {
            for (int i = 1; i < 14; i++)
            {
                MakeSuit("hearts");
                MakeSuit("diamonds");
                MakeSuit("spades");
                MakeSuit("hearts");
            }
        }

        public void MakeSuit(String suitName)
        {
            for (int i = 1; i < 14; i++)
            {
                cards.Add(new Card(suitName, i));
            }
        }

        public void Show()
        {
            foreach (Card c in cards)
            {
                Console.WriteLine(c.GetName());
            }
        }
        public void Shuffle()
        {
            //Random r = new Random();
            
            //for (int i =0; i< 1000; i++)
            //{
            //    int j =  r.Next(0, 51);
            //    Card temp = cards[0];
            //    cards[0] = cards[j];
            //    cards[j] = temp;

            //}

            List<Card> shuffleDeck = new List<Card>();
            Random rnd = new Random();
            int p = 0;
            
            while (cards.Count > 0)
                {
                    p = rnd.Next(0, cards.Count);
                    shuffleDeck.Add(cards[p]);
                    cards.Remove(cards[p]);
                }
                cards = shuffleDeck;

            Random r = new Random();
            Random rnd1 = new Random();
            for (int i =0; i< 1000; i++)
            {
                int j =  r.Next(0, 51);  
                int k = rnd1.Next(0, 51);
                Card temp = cards[k];
                cards[k] = cards[j];
                cards[j] = temp;

            }
        }
        public Card GetTopCard()
        {
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }
       
        public void AddCard(Card c)
        {
            cards.Add(c);
        }
    }
}
