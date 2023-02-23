using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
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
            string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha", "Nika", "Masha", "Vika", "Vitia", "Danil", "Dima", "NN", "Bill" };

            List<Group> g1 = new List<Group>();
            List<Group> g2 = new List<Group>();
            List<Group> g3 = new List<Group>();

            g1.Add(new Group("Ivan", new int[] { 5, 2, 3, 3, 3 }));
            g1.Add(new Group("Andrey", new int[] { 3, 2, 3, 4, 3 }));
            g1.Add(new Group("Sasha", new int[] { 3, 3, 3, 3, 3 }));
            g1.Add(new Group("Sasha", new int[] { 5, 5, 5, 3, 5 }));



            g2.Add(new Group("Max", new int[] { 5, 5, 5, 5, 5 }));
            g2.Add(new Group("Nikita", new int[] { 3, 3, 5, 3, 4 }));
            g2.Add(new Group("Misha", new int[] { 3, 4, 3, 3, 3 }));
            g2.Add(new Group("Dima", new int[] { 5, 5, 5, 4, 3 }));

            g3.Add(new Group("Nika", new int[] { 2, 3, 4, 2, 5 }));
            g3.Add(new Group("Dasha", new int[] { 2, 3, 4, 2, 2 }));
            g3.Add(new Group("Bill", new int[] { 3, 4, 4, 4, 5 }));


            //for (int i = 0; i < 5; i++)
            //{
            //    Random random = new Random();
            //    int name = random.Next(0, Name1.Length);
            //    int[] r = RandomMarks(5, 2, 6);
            //    g1.Add(new Group(Name1[name], r));

            //}

            foreach (Group g in g1)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" " + g.Marks[i] + " ");
                }
                Console.WriteLine(g.Name);
            }

            Console.WriteLine();

            foreach (Group g in g2)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" " + g.Marks[i] + " ");
                }
                Console.WriteLine(g.Name);
            }

            Console.WriteLine();


            foreach (Group g in g3)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" " + g.Marks[i] + " ");
                }
                Console.WriteLine(g.Name);
            }

            Console.WriteLine();

            //удаление двоек

            for (int k = 0; k < g1.Count + 1; k++)
            {
                for (int i = 0; i < g1.Count; i++)
                {
                    for (int j = 0; j < g1[i].Marks.Length; j++)
                    {
                        if (g1[i].Marks[j] == 2)
                        {
                            g1.Remove(g1[i]);
                            break;
                        }
                    }
                }
            }


            for (int k = 0; k < g2.Count + 1; k++)
            {
                for (int i = 0; i < g2.Count; i++)
                {
                    for (int j = 0; j < g2[i].Marks.Length; j++)
                    {
                        if (g2[i].Marks[j] == 2)
                        {
                            g2.Remove(g2[i]);
                            break;
                        }
                    }
                }
            }


            for (int k = 0; k < g3.Count + 1; k++)
            {
                for (int i = 0; i < g3.Count; i++)
                {
                    for (int j = 0; j < g3[i].Marks.Length; j++)
                    {
                        if (g3[i].Marks[j] == 2)
                        {
                            g3.Remove(g3[i]);
                            break;
                        }
                    }
                }
            }

            double sum1 = 0;
            double c = 0;
            double sred = 0;
            foreach (Group g in g1)
            {
                for (int i = 0; i < g.Marks.Length; i++)
                {
                    sum1 += g.Marks[i];
                }
            }
            sred = sum1 / (g1.Count);

            if (sum1 == 0)
            {
                sred = 0;
                Console.WriteLine(sred);
            }
            else
            {
                Console.WriteLine(sred);
            }

            Console.WriteLine();

            double sum2 = 0;
            c = 0;
            double sred2 = 0;

            foreach (Group g in g2)
            {

                for (int i = 0; i < g.Marks.Length; i++)
                {

                    sum2 += g.Marks[i];
                }
            }

            sred2 = sum2 / (g2.Count - c);

            if (sum2 == 0)
            {
                sred2 = 0;
                Console.WriteLine(sred2);
            }
            else
            {
                Console.WriteLine(sred2);
            }

            Console.WriteLine();

            double sum3 = 0;
            c = 0;
            double sred3 = 0;
            foreach (Group g in g3)
            {
                for (int i = 0; i < g.Marks.Length; i++)
                {

                    sum3 += g.Marks[i];
                }
            }

            sred3 = sum3 / (g3.Count - c);

            if (sum3 == 0)
            {
                sred3 = 0;
                Console.WriteLine(sred3);
            }
            else
            {
                Console.WriteLine(sred3);
            }
            Console.WriteLine();
            //foreach (Group g in g1)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.Write(" " + g.Marks[i] + " ");
            //    }
            //    Console.WriteLine(g.Name);
            //}
            //Console.WriteLine();

            //foreach (Group g in g2)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.Write(" " + g.Marks[i] + " ");
            //    }
            //    Console.WriteLine(g.Name);
            //}
            //Console.WriteLine();
            //foreach (Group g in g3)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.Write(" " + g.Marks[i] + " ");
            //    }
            //    Console.WriteLine(g.Name);
            //}


            // сортировка учеников 

            for (int i = 0; i < g1.Count; i++)
            {
                int sumi = 0;
                int sumj = 0;
                for (int j = i + 1; j < g1.Count; j++)
                {
                    for (int k = 0; k < g1[i].Marks.Length; k++)
                    {
                        sumi += g1[i].Marks[k];
                        sumj += g1[j].Marks[k];
                    }
                    if (sumi < sumj)
                    {
                        Group r = g1[i];

                        g1[i] = g1[j];
                        g1[j] = r;
                    }
                }
            }

            for (int i = 0; i < g2.Count; i++)
            {
                int sumi = 0;
                int sumj = 0;
                for (int j = i + 1; j < g2.Count; j++)
                {
                    for (int k = 0; k < g2[i].Marks.Length; k++)
                    {
                        sumi += g2[i].Marks[k];
                        sumj += g2[j].Marks[k];
                    }
                    if (sumi < sumj)
                    {
                        Group r = g2[i];

                        g2[i] = g2[j];
                        g2[j] = r;
                    }
                }
            }

            for (int i = 0; i < g3.Count; i++)
            {
                int sumi = 0;
                int sumj = 0;
                for (int j = i + 1; j < g3.Count; j++)
                {
                    for (int k = 0; k < g3[i].Marks.Length; k++)
                    {
                        sumi += g3[i].Marks[k];
                        sumj += g3[j].Marks[k];
                    }
                    if (sumi < sumj)
                    {
                        Group r = g3[i];

                        g3[i] = g3[j];
                        g3[j] = r;
                    }
                }
            }
            Console.WriteLine("sorted stdents");
            Console.WriteLine();

            foreach (Group g in g1)
            {
                Console.Write(g.Name + " ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" " + g.Marks[i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (Group g in g2)
            {
                Console.Write(g.Name + " ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" " + g.Marks[i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (Group g in g3)
            {
                Console.Write(g.Name + " ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" " + g.Marks[i] + " ");
                }
                Console.WriteLine();
            }
            All[] alls = new All[3];

            alls[0] = new All(sred, g1, 1);
            alls[1] = new All(sred2, g2, 2);
            alls[2] = new All(sred3, g3, 3);

            for (int i = 0; i < alls.Length; i++)
            {
                for (int j = i + 1; j < alls.Length; j++)
                {
                    if (alls[i].sred < alls[j].sred)
                    {
                        All n = new All();
                        n = alls[i];
                        alls[i] = alls[j];
                        alls[j] = n;

                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("сортиврока групп");
            Console.WriteLine();


            for (int i = 0; i < alls.Length; i++)
            {
                Console.WriteLine(alls[i].cg + " группа");
                for (int k = 0; k < alls[i].g.Count; k++)
                {
                    Console.Write(alls[i].g[k].Name + " ");

                    for (int j = 0; j < alls[i].g[k].Marks.Length; j++)
                    {
                        Console.Write(alls[i].g[k].Marks[j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        public class s
        {
            public double sred;
        }
        public class All:s
        {
            //public double sred;
            public List<Group> g;
            public int cg;

            public All()
            {
            }

            public All(double sred, List<Group> g, int cg)
            {
                this.sred = sred;
                this.g = g;
                this.cg = cg;
            }
        }
        public class Group
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

            string[] animals = new string[] { "Cat", "Dog", "Parret", "Bird", "Eagle", "fffff", "aaaa", "None" };
            string[] trait = new string[] { "Polite", "Independent", "Funny", "modesty", "prudence", "harakter", "1111", "None" };
            string[] stuff = new string[] { "Suhi", "Red Sun", "Asian", "Anime", "Sakura", "chto", "to", "None" };

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
                    if (animals[i] == jp[j].animal && animals[i] != "None")
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
                Console.WriteLine(i + 1 + " место " + "голосов " + pa[i] + " " + animals[i]);
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

