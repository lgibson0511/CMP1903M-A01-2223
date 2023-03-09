using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Please select your shuffle 1=No shuffle 2=Fisher-Yates 3=Riffle");
            int selectShuffle = Convert.ToInt32(Console.ReadLine());
            if (selectShuffle == 1)
            {
                Pack.shuffleCardPack(1);

            }

            else if (selectShuffle == 2)
            {
                Pack.shuffleCardPack(2);

            }
            else if (selectShuffle == 3)
            {
                Pack.shuffleCardPack(3);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("How many cards do you want to deal 1-52");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Pack.deal();
            }
            else
            {
                Pack.dealCard(num);
            }

        }
    }
}