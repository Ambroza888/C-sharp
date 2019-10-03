using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Card
    {
        //====== attributes============
        public string stringVal; // (Ace,2,3,4,5,6,7,8,9,10,Jack,Queen,King)
        public string suit; // (Clubs,Spades,Hearts,Diamonds)
        public int val; // (numerical value of the card 1-13 as intregers)
        public Card(string strv,string st,int vl)
        {
            stringVal = strv;
            suit = st;
            val = vl;
        }
    }
    class Deck
    {
        //=========== attributes=============
        public  List<Card> cards;
        public string[] strVal = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        public string[] suit = {"Clubs","Spades","Hearths","Diamonds"};
        public int[] val = {1,2,3,4,5,6,7,8,9,10,11,12,13};
        //========= Constructor========
        public Deck()
        {
            GenerateDeck();
        }
        //==========Methods=============
        public void GenerateDeck()
        {
            cards = new List<Card>();
            for (int i =0 ; i < suit.Length;i++){
                for (int j=0 ; j < val.Length;j++){
                    Card nCard = new Card(strVal[j],suit[i],val[j]);
                    // Console.WriteLine($"the Value is :{nCard.val} THE STRVALUE :{nCard.stringVal} suit is : {nCard.suit}");
                    cards.Add(nCard);
                }
            }
        }
        public Card PopTopCard()
        {
            Card c = cards[cards.Count-1];
            cards.RemoveAt(cards.Count-1);
            return c;
        }
        public void ResetDeck()
        {
            cards.Clear();
            GenerateDeck();
        }
        public void Shuffle()
        {
                Random rand = new Random();
            int num1;
            int num2;
            Card temp;
            for (var i = 0 ; i < 100;i++){

                num1 = rand.Next(0,cards.Count);
                num2 = rand.Next(0,cards.Count);
                temp = cards[num1];
                cards[num1] = cards[num2];
                cards[num2] = temp;
            }
        }
    } 
        class Player
        {
            //======= Attributes============
            public string name;
            public List<Card> hand;
            // ===== Constructor =====
            public Player(string nam)
            {
                name = nam;
                hand = new List<Card>();
            }
            //====== Methods ========
            public Card draw()
            {
                Deck d = new Deck();
                Card playerC = d.PopTopCard();
                this.hand.Add(playerC);
                return playerC;
            }
            public Card discard (int idx)
            {
                if (idx < hand.Count)
                {
                Card y = hand[idx];
                hand.RemoveAt(idx);
                return y;
                }
                else
                {
                    return null;
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Deck d = new Deck();
            // Card t = d.PopTopCard();
            // d.Shuffle();
            // d.Shuffle();
            // d.ResetDeck();
            // d.Shuffle();
            // d.ResetDeck();
            Player veso = new Player("Veso");
            veso.draw();
            veso.draw();
            veso.draw();
            // Card disc = veso.discard(2);

            Console.WriteLine(veso.draw().stringVal);
            // System.Console.WriteLine(card2.val);
            // System.Console.WriteLine(card3.suit);
            // System.Console.WriteLine(disc.stringVal);
            // System.Console.WriteLine(disc.val);
            // System.Console.WriteLine(disc.suit);

        }
    }
    
}
