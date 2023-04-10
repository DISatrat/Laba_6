using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Laba_6.Laba_8
{
    internal class Lvl_1
    {
        public static void N1_8()
        {
            string line = "ацацана";
            char[] a = line.ToCharArray();
            HashSet<char> set = new HashSet<char>(a);
            double d = 0;
            for (int i = 0; i < set.Count; i++)
            {
                double c = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (set.ElementAt(i) == line[j])
                    {
                        c++;
                    }
                }
                Console.WriteLine("буква " + set.ElementAt(i) + " встречаеться с частотой " + c / line.Length);
            }
        }
        //['!drow','olleH']
        public static void N2_8()
        {
            string line = "!drow olleH";
            string line2 = "Hello world!";

            De(line);
            De(line2);
        }

        public static void De(string line)
        {
            string line2 = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (!line[i].Equals(" "))
                {
                    line2 += line[i];
                }
                else
                {
                    line2 += " ";
                }
            }
            Console.WriteLine(line2);
        }
       
    }
}
