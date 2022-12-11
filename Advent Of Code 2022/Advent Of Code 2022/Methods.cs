using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2022.Days
{
    public class Methods
    {

        public string path = "../../../Input/";
        public void DayLine(int pDayNb)
        {
            int color = 0;
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----- Day " + pDayNb + " -----");
                Console.ResetColor();
                Console.WriteLine();
                color = 1;
            }
            else if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----- Day " + pDayNb + " -----");
                Console.ResetColor();
                Console.WriteLine();
                color = 0;
            }
        }

        public void Awnser(int pAwnser)
        {
            int spaces = (17 - pAwnser.ToString().Length) / 2;
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(pAwnser.ToString());
            Console.WriteLine();
        }

    }
}
