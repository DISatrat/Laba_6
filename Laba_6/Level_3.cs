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
            //string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha", "Nika", "Masha", "Vika", "Vitia", "Danil", "Dima", "NN", "Bill" };

            List<Group> g1 = new List<Group>();
            List<Group> g2 = new List<Group>();
            List<Group> g3 = new List<Group>();

            g1.Add(new Group("Ivan", new int[] { 5, 2, 3, 3, 3 }));
            g1.Add(new Group("Andrey", new int[] { 3, 2, 3, 4, 3 }));
            g1.Add(new Group("Sasha", new int[] { 3, 3, 3, 3, 3 }));
            g1.Add(new Group("Sasha", new int[] { 5, 5, 5, 3, 5 }));



            g2.Add(new Group("Max", new int[] { 3, 5, 5, 2, 3 }));
            g2.Add(new Group("Nikita", new int[] { 3, 3, 5, 3, 4 }));
            g2.Add(new Group("Misha", new int[] { 3, 4, 3, 3, 3 }));
            g2.Add(new Group("Dima", new int[] { 5, 5, 5, 5, 3 }));

            g3.Add(new Group("Nika", new int[] { 2, 3, 4, 2, 5 }));
            g3.Add(new Group("Dasha", new int[] { 2, 3, 4, 2, 2 }));
            g3.Add(new Group("Bill", new int[] { 3, 4, 4, 4, 5 }));

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

            Remove(g1);
            Remove(g2);
            Remove(g3);

            double sred = Sred(g1);
            Console.WriteLine(sred);

            double sred2 = Sred(g2);
            Console.WriteLine(sred2);

            double sred3 = Sred(g3);
            Console.WriteLine(sred3);

            // сортировка учеников 

            SortGroup(g1);
            SortGroup(g2);
            SortGroup(g3);


            Console.WriteLine("sorted, deleted students");
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

            alls[0] = new All(sred, "БИВТ-22-19");
            alls[1] = new All(sred2, "БИВТ-22-20");
            alls[2] = new All(sred3, "БИВТ-22-21");

            for (int i = 0; i < alls.Length; i++)
            {
                for (int j = i + 1; j < alls.Length; j++)
                {
                    if (alls[i].sred < alls[j].sred)
                    {
                        All n = alls[i];
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
                Console.WriteLine(alls[i].GroupName + " " + alls[i].sred);
            }
        }

        static double Sred(List<Group> g1)
        {
            double sum1 = 0;
            double c = 0;
            double sred = 0;
            foreach (Group g in g1)
            {
                sum1+=g.sred;
            }
            sred = sum1 / (g1.Count);
            if (sum1 == 0)
            {
                sred = 0;
                return sred;
            }
            else
            {
                return sred;
            }
           


        }

        static void SortGroup(List<Group> g)
        {
            for (int i = 0; i < g.Count; i++)
            {
                for (int j = i+1; j < g.Count; j++)
                {
                    if (g[i].sred < g[j].sred)
                    {
                        Group r = g[i];
                        g[i] = g[j];
                        g[j] = r;
                    }
                }
            }
        }

        static void Remove(List<Group> g)
        {
            for (int k = 0; k < g.Count + 1; k++)
            {
                for (int i = 0; i < g.Count; i++)
                {
                    for (int j = 0; j < g[i].Marks.Length; j++)
                    {
                        if (g[i].Marks[j] == 2)
                        {
                            g.Remove(g[i]);
                            break;
                        }
                    }
                }
            }
        }

        //public class s
        //{
        //    public double sred;
        //}
        struct All
        {
            public double sred;
            public string GroupName; 

            public All(double sred,string GroupName)
            {
                this.sred = sred;
                this.GroupName = GroupName;
            }
        }
        struct Group
        {
            public string Name;
            public int[] Marks;
            public double sred;

            public Group(string Name, int[] Marks)
            {
                sred = 0;
                this.Name = Name;
                this.Marks = Marks;
                for (int i = 0; i < Marks.Length; i++)
                {
                    sred += Marks[i];
                }
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

            for (int i = 0; i < sg2.Length; i++)
            {
                Console.WriteLine(sg2[i].name + " " + sg2[i].result);
            }

            Console.WriteLine();

            SkiGroup[] sg3 = new SkiGroup[sg1.Length + sg2.Length];

            for (int i = 0; i < sg1.Length; i++)
            {
                sg3[i] = sg1[i];
            }

            for (int i = sg1.Length; i < sg3.Length; i++)
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
        //public class Name
        //{

        //    public string name;
        //}
        struct SkiGroup
        { 
            public int result;
            public string name;
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
                //Console.WriteLine(pa[i]);
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
                //Console.WriteLine(ta[i]);
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
                //Console.WriteLine(sa[i]);
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

