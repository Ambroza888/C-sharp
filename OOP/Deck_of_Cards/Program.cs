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
                    cards.Add(new Card(strVal[j],suit[i],val[j]));
                }
            }
            System.Console.WriteLine("DECK IS MADE!!!");
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





    }








    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck d = new Deck();
            Console.WriteLine($"The val is : {d.PopTopCard().val} and suit is {d.PopTopCard().suit} and {d.PopTopCard().stringVal}");

        }
    }
}
