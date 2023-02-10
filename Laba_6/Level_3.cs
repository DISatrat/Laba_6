using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Laba_6
{
    class Level_3
    {
        static void Main(string[] args)
        {
            N1();
        }
        static void N1()
        {
            Group[] s1 = new Group[1];
            Group[] s2 = new Group[5];
            Group[] s3 = new Group[5];

            string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha" };
            int[] Mark = new int[] { 2, 3, 4, 5 };
           
            for (int i = 0; i < s2.Length; i++)
            {
                int[]r= RandomMarks(5, 2, 6);
                s2[i] = new Group(Name1[1], r);
                Console.WriteLine(s2[i].Name +" ");
            }
            for (int i = 0; i < s2.Length; i++)
            {
                Console.Write(s2[i].Marks[i]+" ");

            }
        }
            
        struct Group
        {
           public string Name;
          public  int[] Marks;
 
            public Group(string Name, int[] Marks)
            {
                this.Name = Name;
                this.Marks = Marks;
            }
        }
        static int[] RandomMarks(int h, int k, int l)
        {
            Random random = new Random();
            int[] Marks = new int[h];
            for (int i = 0; i < Marks.Length; i++)
            {
                Marks[i] = random.Next(k, l);
            }
            return Marks;
        }
    }
}
