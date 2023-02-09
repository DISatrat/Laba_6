using System;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            N1();
        }
        static void N1()
        {
            Sport[] sp = new Sport[4];
            sp[0] = new Sport("Ivan", "dddd", 10, 16);
            sp[1] = new Sport("Victor", "dddd", 5, 20);
            sp[2] = new Sport("Nikolay", "dddd", 17, 15);
            sp[3] = new Sport("Kirill", "dddd", 2, 5);

            for (int i = 0; i < sp.Length; i++)
            {
                for (int j = i + 1; j < sp.Length; j++)
                {

                    if (sp[i].res1 + sp[i].res2 < sp[j].res1 + sp[j].res2)
                    {

                        Sport resport = sp[i];

                        sp[i] = sp[j];
                        sp[j] = resport;

                    }

                }

            }
            for (int i = 0; i < sp.Length; i++)
            {
                int res = sp[i].res1 + sp[i].res2;
                Console.WriteLine(i + 1 + " место " + sp[i].name + " c результатом " + res);
            }
        }
        struct Sport
        {
            public string name;
            public string www;
            public int res1, res2;

            public Sport(string name, string www, int res1, int res2)
            {
                this.name = name;
                this.www = www;
                this.res1 = res1;
                this.res2 = res2;

            }

        }

    }
}
