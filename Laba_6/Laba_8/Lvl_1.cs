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
                int c = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (set.ElementAt(i) == line[j])
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    c -= c;
                }
                else
                {
                    d += c;
                }
            }
            Console.WriteLine("буквы встречаются c частотой" + d / line.Length * 100 + "%");
        }
        //['olleh','drow']
        public static void N2_8()
        {
            string line = "olleH !dlrow";

            string[] f = line.Split(" ");
            for (int i = 0; i < f.Length; i++)
            {
                string w = f[i];
                for (int j = w.Length-1; j >= 0; j--)
                {

                    Console.Write(w[j]);
                }
                Console.Write(" ");
            }
        }
    }
}
