//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Laba_6
//{
//    class Level_2
//    {
//        static void Main(string[] args)
//        {
//            N1();
//        }
//        static void N1()
//        {
//            Student[] st = new Student[10];
//            st[0] = new Student("Ivan", 3, 5, 2, 4);
//            st[1] = new Student("Max", 4, 5, 4, 4);
//            st[2] = new Student("Andrey", 5, 5, 5, 5);
//            st[3] = new Student("Dima", 3, 5, 4, 5);
//            st[4] = new Student("Ivan_2", 4, 2, 4, 4);
//            st[5] = new Student("Kirill", 3, 3, 2, 4);
//            st[6] = new Student("Kirill_2", 2, 2, 2, 2);
//            st[7] = new Student("Mash", 4, 5, 3, 2);
//            st[8] = new Student("Vika", 5, 5, 4, 3);
//            st[9] = new Student("Vitia", 3, 3, 3, 4);

//            for (int i = 0; i < st.Length; i++)
//            {
//                double sred = (st[i].Math + st[i].Proga + st[i].Phisics + st[i].History) / 4;

//                if (sred >= 4)
//                {
//                    Console.WriteLine(st[i].Name + " средний балл " + sred);
//                }
//            }

//        }
//        struct Student
//        {
//            public string Name;
//            public double Math;
//            public double Proga;
//            public double Phisics;
//            public double History;

//            public Student(string Name, double Math, double Proga, double Phisics, double History)
//            {
//                this.Name = Name;
//                this.Math = Math;
//                this.Proga = Proga;
//                this.Phisics = Phisics;
//                this.History = History;
//            }

//        }
//    }
//}
