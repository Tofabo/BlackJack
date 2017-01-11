using System;
using System.Collections.Generic;

namespace DeckOfCards{
    public class Player{
        public string name{get; set;}
        public List<Card> hand = new List<Card>();

        public Player(string n){
            name = n;
        }
        public void Draw(Deck deck){
            hand.Add(deck.deal());
        }

        public bool Discard(Card card){
            return hand.Remove(card); //look at how .Remove() works and how it returns true/false
        }

        public Card Discard(int CardIdx){
            if(hand[CardIdx] != null){
                Card toReturn = hand[CardIdx];
                hand.RemoveAt(CardIdx);
                return toReturn; 
            }
            return null;
        }
    }
}