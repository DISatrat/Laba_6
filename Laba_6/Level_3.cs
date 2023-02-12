using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
            string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha", "Nika", "Masha", "Vika", "Vitia", "Danil", "Dima", "NN", "Bill" };
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


            //сорвтировка групп по баллу 


            Console.WriteLine();

            double sum1 = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                sum1 += s1[i].Marks[0] + s1[i].Marks[1] + s1[i].Marks[2] + s1[i].Marks[3] + s1[i].Marks[4];
            }
            Console.WriteLine(sum1 / s1.Length);

            double sum2 = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i].Marks[0] + s2[i].Marks[1] + s2[i].Marks[2] + s2[i].Marks[3] + s2[i].Marks[4];
            }
            Console.WriteLine(sum2 / s2.Length);

            double sum3 = 0;
            for (int i = 0; i < s3.Length; i++)
            {
                sum3 += s3[i].Marks[0] + s3[i].Marks[1] + s3[i].Marks[2] + s3[i].Marks[3] + s3[i].Marks[4];
            }
            Console.WriteLine(sum3 / s3.Length);
            Console.WriteLine();

            double[] list = new double[] { sum1 / s1.Length, sum2 / s2.Length, sum3 / s3.Length };
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] < list[j])
                    {
                        double res = list[i];
                        list[i] = list[j];
                        list[j] = res;
                    }

                }
            }
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            //сортировка по среднему балу студентов


            ////для 1 группы
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    for (int j = i + 1; j < s1.Length; j++)
            //    {
            //        if (s1[i].Marks[0] + s1[i].Marks[1] + s1[i].Marks[2] + s1[i].Marks[3] + s1[i].Marks[4] < s1[j].Marks[0] + s1[j].Marks[1] + s1[j].Marks[2] + s1[j].Marks[3] + s1[j].Marks[4])
            //        {

            //            Group r = s1[i];
            //            s1[i] = s1[j];
            //            s1[j] = r;
            //        }
            //    }
            //}

            ////для 2 группы
            //for (int i = 0; i < s2.Length; i++)
            //{
            //    for (int j = i + 1; j < s2.Length; j++)
            //    {
            //        if (s2[i].Marks[0] + s2[i].Marks[1] + s2[i].Marks[2] + s2[i].Marks[3] + s2[i].Marks[4] < s2[j].Marks[0] + s2[j].Marks[1] + s2[j].Marks[2] + s2[j].Marks[3] + s2[j].Marks[4])
            //        {

            //            Group r = s2[i];
            //            s2[i] = s2[j];
            //            s2[j] = r;
            //        }
            //    }
            //}


            ////для 3 группы
            //for (int i = 0; i < s3.Length; i++)
            //{
            //    for (int j = i + 1; j < s3.Length; j++)
            //    {
            //        if (s3[i].Marks[0] + s3[i].Marks[1] + s3[i].Marks[2] + s3[i].Marks[3] + s3[i].Marks[4] < s3[j].Marks[0] + s3[j].Marks[1] + s3[j].Marks[2] + s3[j].Marks[3] + s3[j].Marks[4])
            //        {

            //            Group r = s3[i];
            //            s3[i] = s3[j];
            //            s3[j] = r;
            //        }
            //    }
            //}



            //Console.WriteLine();
            //Console.WriteLine("1 группа sorted");

            //for (int i = 0; i < s1.Length; i++)
            //{
            //    double sum = 0;
            //    int d = 0;
            //    while (d <= 4)
            //    {
            //        sum += s1[i].Marks[d];
            //        d++;
            //    }
            //    double sred = sum / 5;
            //    Console.WriteLine(s1[i].Name + " " + sred);
            //}
            //Console.WriteLine();
            //Console.WriteLine("2 группа sorted");

            //for (int i = 0; i < s2.Length; i++)
            //{
            //    double sum = 0;
            //    int d = 0;
            //    while (d <= 4)
            //    {
            //        sum += s2[i].Marks[d];
            //        d++;
            //    }
            //    double sred = sum / 5;
            //    Console.WriteLine(s2[i].Name + " " + sred);
            //}
            //Console.WriteLine();

            //Console.WriteLine("3 группа sorted");

            //for (int i = 0; i < s3.Length; i++)
            //{
            //    double sum = 0;
            //    int d = 0;
            //    while (d <= 4)
            //    {
            //        sum += s3[i].Marks[d];
            //        d++;
            //    }
            //    double sred = sum / 5;
            //    Console.WriteLine(s3[i].Name + " " + sred);
            //}
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
            Japanes[] jp = new Japanes[20];

            string[] animals = new string[] { "Cat", "Dog", "Parret", "Bird", "Eagle","fffff","aaaa", "None" };
            string[] trait = new string[] { "Polite", "Independent", "Funny", "modesty", "prudence","harakter","1111", "None" };
            string[] stuff = new string[] { "Suhi", "Red Sun", "Asian", "Anime", "Sakura","chto", "to", "None" };

            Random r = new Random();
            Console.WriteLine("Animals  Trait  Stuff");
            Console.WriteLine();
            for (int i = 0; i < jp.Length; i++)
            {
                int animalId = r.Next(0, animals.Length);
                int traitId = r.Next(0, trait.Length);
                int stufId = r.Next(0, stuff.Length);

                jp[i] = new Japanes(animals[animalId], trait[traitId], stuff[stufId]);

                Console.WriteLine(jp[i].animal + " " + jp[i].trait + " " + jp[i].stuff);
            }
            Console.WriteLine();


            //частые животное 

            int max = -1000;

            int[] pa = new int[animals.Length];
            int[] ta = new int[trait.Length];
            int[] sa = new int[stuff.Length];

            for (int i = 0; i < pa.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < jp.Length; j++)
                {
                    if (animals[i] == jp[j].animal && animals[i]!="None")
                    {
                        c++;
                    }
                }
                //if (c == 0)
                //{
                //    c += 1;
                //}
                pa[i] = c;
                Console.WriteLine(pa[i]);
            }

            //чатсая характеристика 

            for (int i = 0; i < ta.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < jp.Length; j++)
                {
                    if (trait[i] == jp[j].trait && trait[i] != "None")
                    {
                        c++;
                    }
                }
                //if (c == 0)
                //{
                //    c += 1;
                //}
                ta[i] = c;
                Console.WriteLine(ta[i]);
            }


            //чатсый предмет

            for (int i = 0; i < sa.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < jp.Length; j++)
                {
                    if (stuff[i] == jp[j].stuff && stuff[i] != "None")
                    {
                        c++;
                    }
                }
                //if (c == 0)
                //{
                //    c += 1;
                //}
                sa[i] = c;
                Console.WriteLine(sa[i]);
            }

            for (int i = 0; i < pa.Length - 1; i++)
            {
                for (int j = i + 1; j < pa.Length; j++)
                {
                    if (pa[i] < pa[j])
                    {
                        int t = pa[i];
                        pa[i] = pa[j];
                        pa[j] = t;
                        string f = animals[i];
                        animals[i] = animals[j];
                        animals[j] = f;
                    }
                }
            }

            for (int i = 0; i < ta.Length - 1; i++)
            {
                for (int j = i + 1; j < ta.Length; j++)
                {
                    if (ta[i] < ta[j])
                    {
                        int t = ta[i];
                        ta[i] = ta[j];
                        ta[j] = t;
                        string f = trait[i];
                        trait[i] = trait[j];
                        trait[j] = f;
                    }
                }
            }

            for (int i = 0; i < sa.Length - 1; i++)
            {
                for (int j = i + 1; j < sa.Length; j++)
                {
                    if (sa[i] < sa[j])
                    {
                        int t = sa[i];
                        sa[i] = sa[j];
                        sa[j] = t;
                        string f = stuff[i];
                        stuff[i] = stuff[j];
                        stuff[j] = f;
                    }
                }
            }

            Console.WriteLine("животные");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine( i + 1 + " место " +"голосов "+ pa[i]+" " + animals[i]);
            }
            Console.WriteLine();

            Console.WriteLine("характер");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + ta[i] + " " + trait[i]);
            }

            Console.WriteLine();
            Console.WriteLine("вещь");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + sa[i] + " " + stuff[i]);
            }

        }
    
    }

    struct Japanes
    {
        public string animal;
        public string trait;
        public string stuff;

        public Japanes(string animal, string trait, string stuff)
        {
            this.animal = animal;
            this.trait = trait;
            this.stuff = stuff;
        }

    }
}

