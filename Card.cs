using System;


namespace DeckOfCards{
    public class Card{

        public string val {get{ //cannot use the variable name 'val' in get or set or you will end up in an infinite loop ///{get; set} will make it behave as noraml
             if(num_val > 1 && num_val < 11){
                return num_val.ToString();
            } 
            // else {
            //     // switch(num{
            //     //     case 11: "J";
            //     // } //not a good idea to mix switch and if/else

            // }
            else if(num_val == 11){ //cannot use val. it will call val get function and get stuck in infinite looop. Instead use "return"
                return "Jack";
            }
            else if(num_val == 12){
                return "Queen";
            }
            else if(num_val == 13){
                return "King";
            }
             else if(num_val == 1){
                return "Ace";
            }
            else{
                return "Joker";
            }
        }
        }

        public int num_val;
        public string suit;
        public Card(string s, int num){
            suit = s;
            num_val = num;  
        }

        public override string ToString(){
            return val + " of " + suit;
        }
    }
}