﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Laba_6
{
    class Level_3
    {
        static void Main(string[] args)
        {
            N6();
        }
        static void N1()
        {
            string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha", "Nika", "Masha", "Vika", "Vitia", " Danil", "Dima", "NN", "Bill" };
            Group[] s1 = new Group[5];
            Group[] s2 = new Group[3];
            Group[] s3 = new Group[4];


            Console.WriteLine("1 группа ");
            for (int i = 0; i < s1.Length; i++)
            {
                Random random = new Random();
                int name = random.Next(0, Name1.Length);
                int[] r = RandomMarks(5, 2, 6);
                s1[i] = new Group(Name1[name], r);
                Console.WriteLine(s1[i].Name + " " + r[0] + " " + r[1] + " " + r[2] + " " + r[3] + " " + r[4]);

            }
            Console.WriteLine();

            Console.WriteLine("2 группа ");
            for (int i = 0; i < s2.Length; i++)
            {
                Random random = new Random();
                int name = random.Next(0, Name1.Length);
                int[] r = RandomMarks(5, 2, 6);
                s2[i] = new Group(Name1[name], r);
                Console.WriteLine(s2[i].Name + " " + r[0] + " " + r[1] + " " + r[2] + " " + r[3] + " " + r[4]);

            }
            Console.WriteLine();

            Console.WriteLine("3 группа ");
            for (int i = 0; i < s3.Length; i++)
            {
                Random random = new Random();
                int name = random.Next(0, Name1.Length);
                int[] r = RandomMarks(5, 2, 6);
                s3[i] = new Group(Name1[name], r);
                Console.WriteLine(s3[i].Name + " " + r[0] + " " + r[1] + " " + r[2] + " " + r[3] + " " + r[4]);

            }

            //для 1 группы
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = i + 1; j < s1.Length; j++)
                {
                    if (s1[i].Marks[0] + s1[i].Marks[1] + s1[i].Marks[2] + s1[i].Marks[3] + s1[i].Marks[4] < s1[j].Marks[0] + s1[j].Marks[1] + s1[j].Marks[2] + s1[j].Marks[3] + s1[j].Marks[4])
                    {

                        Group r = s1[i];
                        s1[i] = s1[j];
                        s1[j] = r;
                    }
                }
            }

            //для 2 группы
            for (int i = 0; i < s2.Length; i++)
            {
                for (int j = i + 1; j < s2.Length; j++)
                {
                    if (s2[i].Marks[0] + s2[i].Marks[1] + s2[i].Marks[2] + s2[i].Marks[3] + s2[i].Marks[4] < s2[j].Marks[0] + s2[j].Marks[1] + s2[j].Marks[2] + s2[j].Marks[3] + s2[j].Marks[4])
                    {

                        Group r = s2[i];
                        s2[i] = s2[j];
                        s2[j] = r;
                    }
                }
            }


            //для 3 группы
            for (int i = 0; i < s3.Length; i++)
            {
                for (int j = i + 1; j < s3.Length; j++)
                {
                    if (s3[i].Marks[0] + s3[i].Marks[1] + s3[i].Marks[2] + s3[i].Marks[3] + s3[i].Marks[4] < s3[j].Marks[0] + s3[j].Marks[1] + s3[j].Marks[2] + s3[j].Marks[3] + s3[j].Marks[4])
                    {

                        Group r = s3[i];
                        s3[i] = s3[j];
                        s3[j] = r;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("1 группа sorted");

            for (int i = 0; i < s1.Length; i++)
            {
                double sum = 0;
                int d = 0;
                while (d <= 4)
                {
                    sum += s1[i].Marks[d];
                    d++;
                }
                double sred = sum / 5;
                Console.WriteLine(s1[i].Name + " " + sred);
            }
            Console.WriteLine();
            Console.WriteLine("2 группа sorted");

            for (int i = 0; i < s2.Length; i++)
            {
                double sum = 0;
                int d = 0;
                while (d <= 4)
                {
                    sum += s2[i].Marks[d];
                    d++;
                }
                double sred = sum / 5;
                Console.WriteLine(s2[i].Name + " " + sred);
            }
            Console.WriteLine();

            Console.WriteLine("3 группа sorted");

            for (int i = 0; i < s3.Length; i++)
            {
                double sum = 0;
                int d = 0;
                while (d <= 4)
                {
                    sum += s3[i].Marks[d];
                    d++;
                }
                double sred = sum / 5;
                Console.WriteLine(s3[i].Name + " " + sred);
            }
        }

        struct Group
        {
            public string Name;
            public int[] Marks;

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


        static void N4()
        {
            SkiGroup[] sg1 = new SkiGroup[5];
            SkiGroup[] sg2 = new SkiGroup[6];

            string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha", "Nika", "Masha", "Vika", "Vitia", "Danil", "Dima", "NN", "Bill" };

            Console.WriteLine("1 group");
            for (int i = 0; i < sg1.Length; i++)
            {
                Random random = new Random();
                int name = random.Next(0, Name1.Length);
                int r = random.Next(1, 101);
                sg1[i] = new SkiGroup(Name1[name], r);
                Console.WriteLine(sg1[i].name + " " + sg1[i].result);
            }

            Console.WriteLine();
            Console.WriteLine("2 group");

            for (int i = 0; i < sg2.Length; i++)
            {
                Random random = new Random();
                int name = random.Next(0, Name1.Length);
                int r = random.Next(1, 101);
                sg2[i] = new SkiGroup(Name1[name], r);
                Console.WriteLine(sg2[i].name + " " + sg2[i].result);
            }

            //sorted 1 group
            for (int i = 0; i < sg1.Length; i++)
            {
                for (int j = i + 1; j < sg1.Length; j++)
                {
                    if (sg1[i].result < sg1[j].result)
                    {
                        SkiGroup r = sg1[i];
                        sg1[i] = sg1[j];
                        sg1[j] = r;
                    }
                }
            }

            //sorted 2 group
            for (int i = 0; i < sg2.Length; i++)
            {
                for (int j = i + 1; j < sg2.Length; j++)
                {
                    if (sg2[i].result < sg2[j].result)
                    {
                        SkiGroup r = sg2[i];
                        sg2[i] = sg2[j];
                        sg2[j] = r;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("1 sorted group");

            for (int i = 0; i < sg1.Length; i++)
            {
                Console.WriteLine(sg1[i].name + " " + sg1[i].result);
            }

            Console.WriteLine();
            Console.WriteLine("2 sorted group");

            for (int i = 0; i < sg1.Length; i++)
            {
                Console.WriteLine(sg2[i].name + " " + sg2[i].result);
            }

            Console.WriteLine();
            SkiGroup[] sg3 = new SkiGroup[sg1.Length + sg2.Length];

            for (int i = 0; i < sg1.Length; i++)
            {
                sg3[i] = sg1[i];
            }

            for (int i = sg1.Length; i < sg1.Length + sg2.Length; i++)
            {
                sg3[i] = sg2[i - sg2.Length + 1];
            }
            Console.WriteLine();
            Console.WriteLine("Final table");
            for (int i = 0; i < sg3.Length; i++)
            {
                for (int j = i + 1; j < sg3.Length; j++)
                {
                    if (sg3[i].result < sg3[j].result)
                    {
                        SkiGroup r = sg3[i];
                        sg3[i] = sg3[j];
                        sg3[j] = r;
                    }
                }
            }

            for (int i = 0; i < sg3.Length; i++)
            {
                Console.WriteLine(sg3[i].name + " " + sg3[i].result);
            }
        }
        struct SkiGroup
        {
            public string name;
            public int result;

            public SkiGroup(string name, int result)
            {
                this.name = name;
                this.result = result;
            }
        }


        static void N6()
        {

        }

    }
}