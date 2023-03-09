using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13

        //Suit: numbers 1 - 4
        public enum Suit // gives values 1-4 to each suit respectivley
        {
            Clubs = 1,
            Diamonds,
            Hearts,
            Spades,
        }        //The 'set' methods for these properties could have some validation

        //Error handeling for suits and values test

        public Card()
        {
            suit = 0;

            value = 0;
        }

        // private Suit suit;
        private int value;

        public int Value;
        public Suit suit;

        public override string ToString()
        {
            switch (Value)
            {
                case 11:
                    return "Jack of " + suit.ToString();

                case 12:
                    return "Queen of " + suit.ToString();

                case 13:
                    return "King of " + suit.ToString();

                case 1:
                    return "Ace of " + suit.ToString();

                default:
                    return Value.ToString() + " of " + suit.ToString();

            }
        }
    }
}
