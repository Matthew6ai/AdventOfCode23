using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmadDay4Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPoints = 0;
            Console.WriteLine("Please enter your code");
            while (true)
            {
                string scratchCards = Console.ReadLine();
                if (scratchCards == "konec")
                {
                    break;
                }
                sumPoints = PlayingNumbers(scratchCards);
                TotalScratchCards(sumPoints,scratchCards)
            }
            Console.WriteLine(sumPoints);
            Console.ReadKey();
        }
        static int PlayingNumbers(string scratchNumbers)
        {
            int cardSumPoints = 0;

            // win cards / numbers
            string[] halfCard = scratchNumbers.Split('|');
            string cardNumber = halfCard[0];
            string[] winningNumbers = cardNumber.Split(':');
            string cardNumbers = winningNumbers[1];
            string[] winNumbers = cardNumbers.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // your cards / numbers
            string yourNumbers = halfCard[1];
            string[] playingNumbers = yourNumbers.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // checking
            for (int i = 0; i < playingNumbers.Length; i++)
            {
                for (int j = 0; j < winNumbers.Length; j++)
                {
                    if (playingNumbers[i] == winNumbers[j])
                    {
                        cardSumPoints++;
                    }
                }
            }
            return cardSumPoints;
        }
        static void TotalScratchCards(int cardSumPoints, string scratchCards)
        {
            int totalOfScratchCards = 0;
        }
    }
}