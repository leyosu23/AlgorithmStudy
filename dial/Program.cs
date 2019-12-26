using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.acmicpc.net/problem/5622
/*
 * If you want to dial, you must press one number and then turn it clockwise to the metal pin.
 * Pressing the number 1 takes 1 second, and takes an extra one second to dial the number next to one.
 * Print seconds to call.
 */
namespace dial
{
    class Program
    {
        static void Main(string[] args)
        {
            string dial = Console.ReadLine();
            char[] eachDial = dial.ToCharArray();
            int sec = 0;
            for (int i = 0; i < eachDial.Length; i++)
            {
                if (eachDial[i] == 'A' | eachDial[i] == 'B' || eachDial[i] == 'C')
                {
                    sec += 3;
                }
                if (eachDial[i] == 'D' | eachDial[i] == 'E' || eachDial[i] == 'F')
                {
                    sec += 4;
                }
                if (eachDial[i] == 'G' | eachDial[i] == 'H' || eachDial[i] == 'I')
                {
                    sec += 5;
                }
                if (eachDial[i] == 'J' | eachDial[i] == 'K' || eachDial[i] == 'L')
                {
                    sec += 6;
                }
                if (eachDial[i] == 'M' | eachDial[i] == 'N' || eachDial[i] == 'O')
                {
                    sec += 7;
                }
                if (eachDial[i] == 'P' | eachDial[i] == 'Q' || eachDial[i] == 'R' || eachDial[i] == 'S')
                {
                    sec += 8;
                }
                if (eachDial[i] == 'T' | eachDial[i] == 'U' || eachDial[i] == 'V')
                {
                    sec += 9;
                }
                if (eachDial[i] == 'W' | eachDial[i] == 'X' || eachDial[i] == 'Y' || eachDial[i] == 'Z')
                {
                    sec += 10;
                }
                if (eachDial[i] == '0')
                {
                    sec += 11;
                }
            }
            Console.WriteLine(sec);
        }
    }
}
