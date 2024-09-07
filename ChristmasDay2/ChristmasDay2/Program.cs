using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

// Upraveno na PART 2 !!! [ mel jsem zaple dva visual a part two jsem zacal delat sem na part 1, nicmene part one byl uspesny ]
namespace ChristmasDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input =="konec")
                {
                    break;
                }
                sum = sum + MinCubesToPlay(input);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static int MinCubesToPlay(string input)
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            string[] gameSplit = input.Split(':'); // Split game ID od cubes
            string gameAllSets = gameSplit[1];
            string[] gameSetIndex = gameAllSets.Split(';'); // Splitnute Sety -> ; 0 až length
            for (int i = 0; i < gameSetIndex.Length; i++)
            {
                string gameOneSetIndex = gameSetIndex[i];
                string[] numberColor = gameOneSetIndex.Split(','); //splitnuty určitý set -> ,

                for (int setLength = 0; setLength < numberColor.Length; setLength++)
                {
                    string numberColorExtract = numberColor[setLength]; // split na cislo a barvu = JEDEN SET
                    string[] numberWColor = numberColorExtract.Split(' ');
                    int number = Convert.ToInt32(numberWColor[1]); // cislo prevedeno na INT
                    string color = numberWColor[2]; // barva
                    if (color == "blue")
                    {
                        if ( blue < number)
                        blue = number;
                    }
                    else if (color == "red")
                    {
                        if ( red < number)
                        red = number;
                    }
                    else if (color == "green")
                    {
                        if ( green < number)
                        green = number;
                    }
                }
            }
            return blue*red*green;
        }
    }
}