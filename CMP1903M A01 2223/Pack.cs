using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> pack = new List<Card>(52); //list of length 52 so we will never get a pack that is too big

        static Pack()
        {
            int count = 0;
            //Initialise the card pack here
            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= 13; j++)
                {
                    pack.Add(new Card());
                    pack[count].suit = (Card.Suit)(int)(Card.Suit)i;
                    pack[count].Value = j;
                    count++;
                }
            }

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            Random rnd = new Random();
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            { //no shuffle
                Console.WriteLine("No shuffle");
                Console.WriteLine(String.Join(", ", pack));
                Console.ReadLine();
                return true;
            }
            else if (typeOfShuffle == 2)
            {  // fisher-yates
                int count = 0;
                Card temp = new Card();
                for (int i = 0; i <= 51; i++)
                {
                    int randInt = rnd.Next(0, 52 - i);
                    temp = pack[randInt];
                    pack[randInt] = pack[count];
                    pack[count] = temp;
                    count++;
                    //Console.WriteLine(temp);
                }
                Console.WriteLine("TEST");
                Console.WriteLine(String.Join(", ", pack));
                return true;

            }
            else if (typeOfShuffle == 3)
            {// rifle shuffle
                int count = 0;
                List<Card> firstHalf = new List<Card>();
                List<Card> secondHalf = new List<Card>();
                for (int i = 0; i <= 25; i++)
                {
                    firstHalf.Add(pack[i]);
                    secondHalf.Add(pack[i]);
                    firstHalf[i] = pack[i];
                    secondHalf[i] = pack[i + 26];
                }


                for (int i = 0; i <= 51; i = i + 2)
                {
                    pack[i] = firstHalf[count];
                    pack[i+1] = secondHalf[count];
                    count++;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                return false;
            }
                
            }

             static public Card deal()
            {
                //Deals one card
                Console.WriteLine(pack[0]);
                pack.RemoveAt(0);
                Console.ReadLine();
                return pack[0];

            }
             static public Card dealCard(int amount)
            {
                //Deals the number of cards specified by 'amount'
                for (int i = 0; i <= amount - 1; i++)
                {
                    Console.WriteLine(pack[0]);
                    pack.RemoveAt(0);
                }
                Console.WriteLine("tset");
                Console.ReadLine();
                return pack[0];
            }
        }
}

