using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasD2Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "konec")
                {
                    break;
                }
                int sum = SetSpliter(input);
                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
        static string MinSetOfCubesToPlay(string input)
        {
            string[] splitGameFromSets = input.Split(':');
            string gameSets = splitGameFromSets[1];
            return gameSets;
        }
        static bool ExtractGameIDFromSets(string input)
        {
            string[] gameIdSplit = input.Split(':'); // Split game ID od cubes
            string gameAllSets = gameIdSplit[1];
            string[] gameSets = gameAllSets.Split(';');
            for (int i = 0; i < gameSets.Length; i++)
            {
                bool possibleOrNot = SetSpliter(gameSets, i);
            }
        }

        static int SetSpliter(string[] gameSets, int i) // index nám udava kolikaty je to set (! pocinaje 0 !)
        {
            int red = 0;
            int blue = 0;
            int green = 0;
            string gameSetIndex = gameSets[i];
            string[] numberColor = gameSetIndex.Split(','); //splitnuty set
            for (int setLength = 0; setLength < numberColor.Length; setLength++)
            {
                string numberColorExtract = numberColor[setLength]; // split na cislo a barvu = JEDEN SET
                string[] numberWColor = numberColorExtract.Split(' ');
                int number = Convert.ToInt32(numberWColor[1]); // cislo prevedeno na INT
                string color = numberWColor[2]; // barva
                if (color == "blue")
                {
                    if (blue < number)
                        blue = number;
                }
                else if (color == "red")
                {
                    if (red < number)
                        red = number;
                }
                else if (color == "green")
                {
                    if (green < number)
                        green = number;
                }
            }
            return blue * red * green;
        }
    }
}


/* Zajistit 
 * RED
 * BLUE
 * GREEN
 * sum = The power of a set of cubes is equal to the numbers of red, green, and blue cubes multiplied together.
 * sum = min ( nejvice ) red*blue*green
 */