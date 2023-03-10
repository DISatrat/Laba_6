using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //N1();

            N6_v2();
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
            SkiGroup[] sg1 = new SkiGroup[3];
            SkiGroup[] sg2 = new SkiGroup[4];

            sg1[0] = new SkiGroup("Ivan", 10);
            sg1[1] = new SkiGroup("Sasha", 5);
            sg1[2] = new SkiGroup("Nekita", 12);

            sg2[0] = new SkiGroup("Vika", 18);
            sg2[1] = new SkiGroup("Nikolai", 9);
            sg2[2] = new SkiGroup("Anton", 19);
            sg2[3] = new SkiGroup("Misha", 2);

            //string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha", "Nika", "Masha", "Vika", "Vitia", "Danil", "Dima", "NN", "Bill" 

            Console.WriteLine("1 group");

             PrintSki(sg1);

            //for (int i = 0; i < sg1.Length; i++)
            //{
            //    Random random = new Random();
            //    int name = random.Next(0, Name1.Length);
            //    int r = random.Next(1, 101);
            //    sg1[i] = new SkiGroup(Name1[name], r);
            //    Console.WriteLine(sg1[i].name + " " + sg1[i].result);
            //}

            Console.WriteLine();
            Console.WriteLine("2 group");

            PrintSki(sg2);

            //for (int i = 0; i < sg2.Length; i++)
            //{
            //    Random random = new Random();
            //    int name = random.Next(0, Name1.Length);
            //    int r = random.Next(1, 101);
            //    sg2[i] = new SkiGroup(Name1[name], r);
            //    Console.WriteLine(sg2[i].name + " " + sg2[i].result);
            //}

            SortSki(sg1);
            SortSki(sg2);

            Console.WriteLine();
            Console.WriteLine("1 sorted group");

            PrintSki(sg1);

            Console.WriteLine();
            Console.WriteLine("2 sorted group");

            PrintSki(sg2);

            Console.WriteLine();

            SkiGroup[] sg3 = new SkiGroup[sg1.Length + sg2.Length];

            for (int i = 0; i < sg1.Length; i++)
            {
                sg3[i] = sg1[i];
            }

            for (int i = sg1.Length; i < sg3.Length; i++)
            {
                sg3[i] = sg2[i+1 - sg2.Length];
            }

            Console.WriteLine();
            Console.WriteLine("Final table");
            
            SortSki(sg3);

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

        static void PrintSki(SkiGroup[] sg2)
        {
            for (int i = 0; i < sg2.Length; i++)
            {
                Console.WriteLine(sg2[i].name + " " + sg2[i].result);
            }
        }
         static void SortSki(SkiGroup[] sg)
        {
            for (int i = 0; i < sg.Length; i++)
            {
                for (int j = i + 1; j < sg.Length; j++)
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

        static void N6_v2()
        {
            Japanes[] jp= new Japanes[13];

            jp[0]=new Japanes("Cat","Polite","Red Sun");
            jp[1]=new Japanes("Dog","Funny","Sushi");
            jp[2]=new Japanes("Dog","Indepented","None");
            jp[3]=new Japanes("None","Funny","None");
            jp[4]=new Japanes("Bird","Modesty","Asian");
            jp[5]=new Japanes("Bird","Modesty","Anime");
            jp[6]=new Japanes("Fish","Polite","Anime");
            jp[7]=new Japanes("Fish","Indepented","Anime");
            jp[8]=new Japanes("Cat","Polite","Asian");
            jp[9]=new Japanes("Snake","Prudence","Suhi");
            jp[10]=new Japanes("Parret","Prudence","Sakura");
            jp[11]=new Japanes("Snake", "Indepented", "Red Sun");
            jp[12]=new Japanes("Cat","None","Sakura");

            Console.WriteLine("Animals  Trait  Stuff");
            Console.WriteLine();
            foreach (Japanes item in jp)
            {
                Console.WriteLine(item.animal+" "+item.trait+" "+item.stuff);
            }

            Console.WriteLine();

            List<String> AnimalList= new List<String>();
            List<String> TraitList= new List<String>();
            List<String> StuffList= new List<String>();

            foreach (Japanes item in jp)
            {
                AnimalList.Add(item.animal);
            }


            foreach (Japanes j in jp)
            {
                TraitList.Add(j.trait);
            }


            foreach (Japanes j in jp)
            {
                StuffList.Add(j.stuff);
            }

            HashSet<String> Animalset = new HashSet<String>(AnimalList);
            HashSet<String> Traitset= new HashSet<String>(TraitList);
            HashSet<String> Stuffset= new HashSet<String>(StuffList);

            AnimalList.Clear();
            AnimalList.AddRange(Animalset);

            TraitList.Clear();
            TraitList.AddRange(Traitset);

            StuffList.Clear();
            StuffList.AddRange(Stuffset);

            double[] pa = new double[AnimalList.Count];
            double[] ta = new double[TraitList.Count];
            double[] sa = new double[StuffList.Count];

            //частые животное 

            for (int i = 0; i < pa.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < jp.Length; j++)
                {
                    if (AnimalList[i] == jp[j].animal && AnimalList[i] != "None")
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
                    if (TraitList[i] == jp[j].trait && TraitList[i] != "None")
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
                    if (StuffList[i] == jp[j].stuff && StuffList[i] != "None")
                    {
                        c++;
                    }
                }
                sa[i] = c;
            }

            FilterPopularItem_2(pa, AnimalList);
            FilterPopularItem_2(ta, TraitList);
            FilterPopularItem_2(sa, StuffList);

            Console.WriteLine("животные");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + pa[i] + " " + AnimalList[i] + " " + pa[i] / jp.Length * 100 + "%");
            }
            Console.WriteLine();

            Console.WriteLine("характер");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + ta[i] + " " + TraitList[i] + " " + ta[i] / jp.Length * 100 + "%");
            }

            Console.WriteLine();
            Console.WriteLine("вещь");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " место " + "голосов " + sa[i] + " " + StuffList[i] + " " + sa[i] / jp.Length * 100 + "%");
            }

        }
        static HashSet<String> ItemList(Japanes[] j )
        {
            HashSet<String> list = new HashSet<String>();

            foreach (Japanes jp in j)
            {
                list.Add(jp.trait);
            }

                return list;

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
                Console.WriteLine(i + 1 + " место " + "голосов " + pa[i] + " " + animals[i]+" " + pa[i]/20*100+"%");
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

        //static void PopularItems(int[] pa, string[] animals, Japanes[] jp)
        //{
        //    for (int i = 0; i < pa.Length; i++)
        //    {
        //        int c = 0;
        //        for (int j = 0; j < jp.Length; j++)
        //        {
        //            if (animals[i] == jp[j].animal && animals[i] != "None")
        //            {
        //                c++;
        //            }
        //        }
        //        pa[i] = c;
        //    }

        //}
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

