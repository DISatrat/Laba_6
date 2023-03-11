using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;

namespace Laba_6
{
    class Level_3
    {
        static void Main(string[] args)
        {
            N6_2();

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

            Console.WriteLine(g1[0].sred);

            g2.Add(new Group("Max", new int[] { 5, 5, 5, 5, 5 }));
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
            SortGroup(g1);
            SortGroup(g2);
            SortGroup(g3);

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
            Console.WriteLine("сортированные группы");
            Console.WriteLine();


            for (int i = 0; i < alls.Length; i++)
            {
                Console.WriteLine(alls[i].GroupName + " " + alls[i].sred);
            }
        }

        static double Sred(List<Group> g1)
        {
            double sum1 = 0;
            double sred = 0;
            foreach (Group g in g1)
            {
                sum1 += g.sred;
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
                for (int j = i + 1; j < g.Count; j++)
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
            for (int i = 0; i < g.Count; i++)
            {
                for (int j = 0; j < g[i].Marks.Length; j++)
                {
                    if (g[i].Marks[j] == 2)
                    {
                        g.Remove(g[i]);
                        i--;
                        break;
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

            public All(double sred, string GroupName)
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
                    if (Marks[i] == 2)
                    {
                        sred = 0;
                        break;
                    }
                }
                sred /= 5;
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
            List<SkiGroup> sg1 = new List<SkiGroup>();
            List<SkiGroup> sg2 = new List<SkiGroup>();

            sg1.Add(new SkiGroup("Ivan", 10));
            sg1.Add(new SkiGroup("Sasha", 5));
            sg1.Add(new SkiGroup("Nekita", 12));
            sg1.Add(new SkiGroup("Tanya", 2));

            sg2.Add(new SkiGroup("Vika", 18));
            sg2.Add(new SkiGroup("Nikolai", 9));
            sg2.Add(new SkiGroup("Anton", 19));
            sg2.Add(new SkiGroup("Misha", 2));

            Console.WriteLine("1 group");

            PrintSki(sg1);

            Console.WriteLine();
            Console.WriteLine("2 group");

            PrintSki(sg2);

            SortSki(sg1);
            SortSki(sg2);

            Console.WriteLine();
            Console.WriteLine("1 sorted group");

            PrintSki(sg1);

            Console.WriteLine();
            Console.WriteLine("2 sorted group");

            PrintSki(sg2);


            Console.WriteLine();
            Console.WriteLine("Final table");
            List<SkiGroup> sg3 = Final(sg1, sg2);
            PrintSki(sg3);

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
        static List<SkiGroup> Final(List<SkiGroup> list1, List<SkiGroup> list2)
        {
            List<SkiGroup> sg3 = new List<SkiGroup>();

            while (list1.Count > 0 & list2.Count > 0)
            {
                if (list1[0].result < list2[0].result)
                {
                    sg3.Add(list2[0]);
                    list2.RemoveAt(0);
                }
                else if (list1[0].result > list2[0].result)
                {
                    sg3.Add(list1[0]);
                    list1.RemoveAt(0);
                }
                else
                {
                    sg3.Add(list1[0]);
                    list1.RemoveAt(0);
                    sg3.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }
            return sg3;
        }
        static void PrintSki(List<SkiGroup> sg2)
        {
            for (int i = 0; i < sg2.Count; i++)
            {
                Console.WriteLine(sg2[i].name + " " + sg2[i].result);
            }
        }
        static void SortSki(List<SkiGroup> sg)
        {
            for (int i = 0; i < sg.Count; i++)
            {
                for (int j = i + 1; j < sg.Count; j++)
                {
                    if (sg[i].result < sg[j].result)
                    {
                        SkiGroup r = sg[i];
                        sg[i] = sg[j];
                        sg[j] = r;
                    }
                }
            }
        }



        static void N6_2()
        {

            List<Answer> animal = new List<Answer>();

            animal.Add(new Answer("Cat", 1));
            animal.Add(new Answer("Dog", 1));
            animal.Add(new Answer("Dog", 1));
            animal.Add(new Answer("Snake", 1));
            animal.Add(new Answer("Bird", 1));
            animal.Add(new Answer("Fish", 1));

            List<Answer> trait = new List<Answer>();

            trait.Add(new Answer("ppp", 1));
            trait.Add(new Answer("funny", 1));
            trait.Add(new Answer("funny", 1));
            trait.Add(new Answer("cool", 1));
            trait.Add(new Answer("angry", 1));
            trait.Add(new Answer("Not Good", 1));

            List<Answer> stuff = new List<Answer>();

            stuff.Add(new Answer("Sakura", 1));
            stuff.Add(new Answer("Sakura", 1));
            stuff.Add(new Answer("add1", 1));
            stuff.Add(new Answer("None", 1));
            stuff.Add(new Answer("Sun", 1));
            stuff.Add(new Answer("Sushi", 1));

            for (int i = 0; i < animal.Count; i++)
            {
                Console.Write(animal[i].answer + " " + trait[i].answer + " " + stuff[i].answer);
                Console.WriteLine();
            }
            Console.WriteLine();

            HashSet<Answer> Animalset = new HashSet<Answer>(animal);
            HashSet<Answer> Traitset = new HashSet<Answer>(trait);
            HashSet<Answer> Stuffset = new HashSet<Answer>(stuff);

            List<Answer> CountAnimals = Counter(animal, Animalset);
            List<Answer> CountTrait = Counter(trait, Traitset);
            List<Answer> CountStuff = Counter(stuff, Stuffset);

            FilterItems(CountAnimals);

            FilterItems(CountTrait);

            FilterItems(CountStuff);

            Console.WriteLine("animals");
            PrintFivePopularItems(CountAnimals, animal);

            Console.WriteLine("Trait");
            PrintFivePopularItems(CountTrait, trait);

            Console.WriteLine("Stuff");
            PrintFivePopularItems(CountStuff, stuff);

        }


        static void PrintFivePopularItems(List<Answer> Animalset, List<Answer> a)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Animalset[i].answer == "None")
                {
                    continue;
                }
                else
                {
                    Console.Write(i + 1 + " место " + Animalset[i].answer + " голосов = " + Animalset[i].count + " " + Animalset[i].count / a.Count * 100 + "%");
                    Console.WriteLine();
                }
            }
        }
        static void FilterItems(List<Answer> count)
        {
            for (int i = 0; i < count.Count; i++)
            {
                for (int j = 0; j < count.Count - 1; j++)
                {
                    if (count[j].count < count[j + 1].count)
                    {
                        Answer answer = count[j];
                        count[j] = count[j + 1];
                        count[j + 1] = answer;
                    }
                }
            }
        }

        static List<Answer> Counter(List<Answer> list, HashSet<Answer> set)
        {
            List<Answer> result = new List<Answer>();

            for (int i = 0; i < set.Count; i++)
            {
                int c = 0;

                for (int j = 0; j < list.Count; j++)
                {
                    if (set.ElementAt(i).answer == list[j].answer && set.ElementAt(i).answer != "None")
                    {
                        c++;
                    }
                }
                result.Add(new Answer(set.ElementAt(i).answer, c));
            }
            return result;
        }

        struct Answer
        {
            public string answer;
            public double count;
            public Answer(string answer, double count)
            {
                this.answer = answer;
                this.count = count;
            }
        }

        /// <summary>
        /// 
        /// 
        /// 
        /// 
        /// 
        /// </summary>
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

            //int max = -1000;

            double[] pa = new double[animals.Length];
            double[] ta = new double[trait.Length];
            double[] sa = new double[stuff.Length];

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
                pa[i] = c;
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
                ta[i] = c;
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
                sa[i] = c;
            }

            FilterPopularItem(pa, animals);
            FilterPopularItem(ta, trait);
            FilterPopularItem(sa, stuff);

            Console.WriteLine("животные");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + pa[i] + " " + animals[i] + " " + pa[i] / 20 * 100 + "%");
            }
            Console.WriteLine();

            Console.WriteLine("характер");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + ta[i] + " " + trait[i] + " " + ta[i] / 20 * 100 + "%");
            }

            Console.WriteLine();
            Console.WriteLine("вещь");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + sa[i] + " " + stuff[i] + " " + sa[i] / 20 * 100 + "%");
            }

        }

        static void FilterPopularItem(double[] indexItem, string[] Item)
        {
            for (int i = 0; i < indexItem.Length - 1; i++)
            {
                for (int j = i + 1; j < indexItem.Length; j++)
                {
                    if (indexItem[i] < indexItem[j])
                    {
                        double t = indexItem[i];
                        indexItem[i] = indexItem[j];
                        indexItem[j] = t;
                        string f = Item[i];
                        Item[i] = Item[j];
                        Item[j] = f;
                    }
                }
            }
        }


        static void FilterPopularItem_2(double[] indexItem, List<String> Item)
        {
            for (int i = 0; i < indexItem.Length - 1; i++)
            {
                for (int j = i + 1; j < indexItem.Length; j++)
                {
                    if (indexItem[i] < indexItem[j])
                    {
                        double t = indexItem[i];
                        indexItem[i] = indexItem[j];
                        indexItem[j] = t;
                        string f = Item[i];
                        Item[i] = Item[j];
                        Item[j] = f;
                    }
                }
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

