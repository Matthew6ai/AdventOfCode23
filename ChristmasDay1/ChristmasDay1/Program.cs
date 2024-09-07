using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                char firstNumber = 'a';
                char lastNumber = 'a';
                string input = Console.ReadLine();
                if (input == "konec")
                {
                    break;
                }
                char[] arr = input.ToCharArray();
                int delka = arr.Length;
                for (int index = 0; index < delka; index++)
                {
                    char znak = SpelledNumberCheck(index, arr);
                    if (Char.IsNumber(znak))
                    {
                        if (firstNumber == 'a')
                        {
                            firstNumber = znak;
                        }
                        lastNumber = znak;
                    }
                }
                string twoDigiteNumber = "";
                twoDigiteNumber += firstNumber;
                twoDigiteNumber += lastNumber;
                //Console.WriteLine(twoDigiteNumber);
                int number = Convert.ToInt32(twoDigiteNumber);
                sum += number;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static char SpelledNumberCheck(int index, char[] arr)
        {
            string[] spelledNumbers = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            for (int iWord = 0; iWord < spelledNumbers.Length; iWord++)
            {
                string word = spelledNumbers[iWord];
                for (int iChar = 0; iChar < word.Length && index+iChar < arr.Length; iChar++)
                {
                    if (word[iChar] == arr[index + iChar])
                    {
                        if (iChar == word.Length - 1)
                        {
                            int cislo = iWord + 1;
                            char znak = Convert.ToChar(cislo + 48);
                            return znak;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr[index];
        }
        /*static char SpelledNumberCheck(int index, char[] arr, char znak)
        {
            if (znak == 'o' || znak == 't' || znak == 'f' || znak == 's' || znak == 'e' || znak == 'n')
            {
                while (index < arr.Length)
                {
                    if (znak == 'o' && index < arr.Length - 2)
                    {
                        index++;
                        znak = arr[index];
                        if (znak == 'n')
                        {
                            index++;
                            znak = arr[index];
                            if (znak == 'e')
                            {
                                return '1';
                            }
                            break;
                        }
                        break;
                    }
                    else if (znak == 't' && index < arr.Length - 4)
                    {
                        index++;
                        znak = arr[index];
                        if (znak == 'w' || znak == 'h')
                        {
                            index++;
                            znak = arr[index];
                            if (znak == 'o')
                            {
                                return '2';
                            }
                            else if (znak == 'r')
                            {
                                index++;
                                znak = arr[index];
                                if (znak == 'e')
                                {
                                    index++;
                                    znak = arr[index];
                                    if (znak == 'e')
                                    {
                                        return '3';
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    }
                    else if (znak == 'f' && index < arr.Length - 3)
                    {
                        index++;
                        znak = arr[index];
                        if (znak == 'o' || znak == 'i')
                        {
                            index++;
                            znak = arr[index];
                            if (znak == 'u')
                            {
                                index++;
                                znak = arr[index];
                                if (znak == 'r')
                                {
                                    return '4';
                                }
                                break;
                            }
                            else if (znak == 'v')
                            {
                                index++;
                                znak = arr[index];
                                if (znak == 'e')
                                {
                                    return '5';
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    }
                    else if (znak == 's' && index < arr.Length - 4)
                    {
                        index++;
                        znak = arr[index];
                        if (znak == 'i' || znak == 'e')
                        {
                            index++;
                            znak = arr[index];
                            if (znak == 'x')
                            {
                                return '6';
                            }
                            else if (znak == 'v')
                            {
                                index++;
                                znak = arr[index];
                                if (znak == 'e')
                                {
                                    index++;
                                    znak = arr[index];
                                    if (znak == 'n')
                                    {
                                        return '7';
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    }
                    else if (znak == 'e' && index < arr.Length - 4)
                    {
                        index++;
                        znak = arr[index];
                        if (znak == 'i')
                        {
                            index++;
                            znak = arr[index];
                            if (znak == 'g')
                            {
                                index++;
                                znak = arr[index];
                                if (znak == 'h')
                                {
                                    index++;
                                    znak = arr[index];
                                    if (znak == 't')
                                    {
                                        return '8';
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    }
                    else if (znak == 'n' && index < arr.Length - 3)
                    {
                        index++;
                        znak = arr[index];
                        if (znak == 'i')
                        {
                            index++;
                            znak = arr[index];
                            if (znak == 'n')
                            {
                                index++;
                                znak = arr[index];
                                if (znak == 'e')
                                {
                                    return '9';
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    }
                    break;
                }
            }
            else
            {
                return arr[index];
            }
            return arr[index];
        }*/
    }
}
              