using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChristmasDay3
{
    internal class Program
    {
        static void Main(string[] args)          
        {
            int line = 0;
            string[] arrayOfRows = new string[10];
            Console.WriteLine("Please enter your Input'CODE'");
            string input = Console.ReadLine();
            while (input != "")
            {
                arrayOfRows[line] = input;
                line++;
                arrayOfRows = ArrayResize(arrayOfRows, line);
                input = Console.ReadLine();
            }
            Cogwheel(arrayOfRows, line);
            Console.ReadKey();
        }

         // Check if array is "FULL"

        static string[] ArrayResize(string[] arrayOfRows, int line)
        {
            if ( arrayOfRows.Length == line )
            {
                string[] newArray = new string[arrayOfRows.Length * 2];
                for (int index = 0; index < arrayOfRows.Length; index++) // saving parameters to new array
                {
                    newArray[index] = arrayOfRows[index];
                }
                return newArray;
            }
            else
            {
                return arrayOfRows;
            }
        }
        //
        //
        //
        static void Cogwheel(string[] arrayOfRows, int line)
        {
            bool answer = false;
            string oneRow;
            string number = "";
            int sum = 0;
            for (int lineNumber = 0; lineNumber < line; lineNumber++)
            {
                oneRow = arrayOfRows[lineNumber];
                int rowLength = oneRow.Length;
                for (int indexInRow = 0; indexInRow < rowLength; indexInRow++)
                {
                    if (Char.IsDigit(oneRow[indexInRow]))
                    {
                        number += oneRow[indexInRow];
                        if (!answer)
                        {
                            AroundCheck(arrayOfRows, indexInRow, lineNumber);
                            answer = SymbolAroundCheck(oneRow, arrayOfRows, indexInRow, lineNumber);
                        }
                    }
                    else
                    {
                        if (answer)
                        {
                            sum = sum + Convert.ToInt32(number);
                        }
                        number = "";
                        answer = false;
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static bool SymbolAroundCheck(string oneRow,string[] arrayOfRows,int indexInRow, int lineNumber)
        {
            int x = indexInRow;
            int y = lineNumber;

            int xMove = x - 1;
            int yMove = y - 1;
            char symbol = Get(arrayOfRows, yMove, xMove);
            while (yMove < y + 1)
            {
                while (xMove < x + 1)
                {
                    if (symbol == '.' || Char.IsDigit(symbol))
                    {
                    }
                    else
                    {
                        return true;
                    }
                    x++;
                }
                xMove = x - 1;
                y++;
            }
            return false;
        }
        static char Get(string[] arrayOfRows,int yMove, int xMove)
        {
            int y = yMove;
            int x = xMove;
            if (y < arrayOfRows.Length && y >= 0 && x < arrayOfRows[y].Length && x >= 0)
            {
                return arrayOfRows[yMove][xMove];
            }
            else
            {
                return '.';
            }
        }
        static void AroundCheck(string[]arrayOfRows,int indexInRow,int lineNumber)
        {
        }
    }
}