using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<MiddleEarthCitizen> Cavalry1 = new List<MiddleEarthCitizen>();   //Армия конниц 1
            List<MiddleEarthCitizen> Walk1 = new List<MiddleEarthCitizen>();      //Армия пеших 1
            List<MiddleEarthCitizen> Cavalry2 = new List<MiddleEarthCitizen>();   //Армия конниц 2
            List<MiddleEarthCitizen> Walk2 = new List<MiddleEarthCitizen>();      //Армия пеших 2

           Random a = new Random();
           int army1size = a.Next(1,20);  //размер армии
           int army2size = a.Next(1,20);
        

            Console.WriteLine("*******Армия 1**********");
            //создание волшебника
            int first=a.Next(0,2);
            if (first == 1)
            {
                Horse h = new Horse(a.Next(4, 6), "Horse");
                Wizard w = new Wizard(20, "Wizard", h);
                Walk1.Add(w);
                Console.WriteLine(w);
            }
            //создание армии 1
            for (int i = 0; i < army1size; i++)
            {
                switch (a.Next(4))
                {
                    case 0:
                        {
                            try
                            {
                                WoodenElf we = new WoodenElf(6, "WoodenElf" + i);
                                Walk1.Add(we);
                                Console.WriteLine(we);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("WoodenElf" + e.ToString());
                            }
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                Human human = new Human(a.Next(7, 9), "Human" + i);
                                Walk1.Add(human);
                                Console.WriteLine(human);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("Human" + e.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Elf el = new Elf(6, "Elf" + i);
                                Walk1.Add(el);
                                Console.WriteLine(el);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("Elf" + e.ToString());
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                Horse g = new Horse(a.Next(4,6), "Horse Rohhirim" + i);
                                Rohhirim r = new Rohhirim(a.Next(11,14), "Rohhirim" + i, g);
                                Cavalry1.Add(r);
                                Console.WriteLine(r);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("Rohhirim" + e.ToString());
                            }
                            break;
                        }


                }
            }
            Console.WriteLine("*******Армия 2***********");
            for (int i = 0; i < army2size; i++)
            {
                switch (a.Next(4))
                {
                    case 0:
                        {
                            try
                            {
                                Goblin g = new Goblin(a.Next(2,6), "Goblin" + i);
                                Walk2.Add(g);
                                Console.WriteLine(g);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("Goblin" + e.ToString());
                            }
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                UrukHai u = new UrukHai(a.Next(10,13), "UrukHai" + i);
                                Walk2.Add(u);
                                Console.WriteLine(u);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("UrukHai" + e.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Troll t = new Troll(a.Next(11,15), "Troll" + i);
                                Walk2.Add(t);
                                Console.WriteLine(t);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("Troll" + e.ToString());
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                Orc.Wolf w = new Orc.Wolf(a.Next(4,7), "Wolf" + i);
                                Orc o = new Orc(a.Next(8, 10), "Orc" + i, w);
                                Cavalry2.Add(o);
                                Console.WriteLine(o);
                            }
                            catch (PowerException e)
                            {
                                Console.WriteLine("Orc" + e.ToString());
                            }
                            break;
                        }

                }


            }


            //создаём бой
            Console.WriteLine("******************************************* 1 РАУНД");
            while ((Cavalry1.Count * Cavalry2.Count) > 0)
            {
                Random b1 = new Random();
                int w1 = b1.Next(Cavalry1.Count);
                int w2 = b1.Next(Cavalry2.Count);
                Random d = new Random();
                first = d.Next(0, 2);
                int p = 1;
            while (p>0)
                {
                    if (first == 1)
                    {
                        Console.WriteLine("Сила 1 всадника: " + Cavalry1[w1].Power + ", Cила 2 всадника: " + Cavalry2[w2].Power);
                        p = Cavalry2[w2].Power - Cavalry1[w1].Power;
                        Cavalry2[w2].Power = p;
                        if (p > 0)
                        {
                            first = 0;
                        }
                        else
                        {
                            Console.WriteLine("2 всадник убит");
                            Cavalry2.RemoveAt(w2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Сила 2 всадника: " + Cavalry2[w2].Power + ", Сила 1 всадника: " + Cavalry1[w1].Power);
                        p = Cavalry1[w1].Power - Cavalry2[w2].Power;
                        Cavalry1[w1].Power = p;
                        if (p > 0)
                        {
                            first = 1;
                        }
                        else
                        {
                            Console.WriteLine("1 всадник убит");
                            Cavalry1.RemoveAt(w1);
                        }
                    }
                }


            }
            if (Cavalry1.Count == 0) { Console.WriteLine(" Победа 2 армии в 1 раунде"); }
            else { Console.WriteLine("Победа 1 армии в раунде"); }



            //2 Бой
            Console.WriteLine("******************************************* 2 РАУНД ");
            while ((Walk1.Count * Walk2.Count) > 0)
            {
                Random b1 = new Random();
                int w11 = b1.Next(Walk1.Count);
                int w21 = b1.Next(Walk2.Count);
                Random d = new Random();
                first = d.Next(0, 2);
                int p = 1;
                while(p>0)
                {
                    if (first == 1)
                    {
                        Console.WriteLine("Сила 1 пешего: " + Walk1[w11].Power + ", Сила 2 пешего: " + Walk2[w21].Power);
                        p = Walk2[w21].Power - Walk1[w11].Power;
                        Walk2[w21].Power = p;
                        if (p > 0)
                        {
                            first = 0;
                        }
                        else
                        {
                            Console.WriteLine("2 пеший убит");
                            Walk2.RemoveAt(w21);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Сила 2 пешего: " + Walk2[w21].Power + ", Сила 1 пешего: " + Walk1[w11].Power);
                        p = Walk1[w11].Power - Walk2[w21].Power;
                        Walk1[w11].Power = p;
                        if (p > 0)
                        {
                            first = 1;
                        }
                        else
                        {
                            Console.WriteLine("1 пеший убит");
                            Walk1.RemoveAt(w11);
                        }
                    }
                }


            }
            if (Walk1.Count == 0) { Console.WriteLine(" Победа 2 армии во 2 раунде"); }
            else { Console.WriteLine("Победа 1 армии во 2 раунде"); }


            //3 РАУНД
            if (Cavalry1.Count * Walk1.Count != 0)
            {
                Console.WriteLine("********** В БИТВЕ ПОБЕДИЛА 1 АРМИЯ");
            }
            else if (Cavalry2.Count * Walk2.Count != 0)
            {
                Console.WriteLine("********** В БИТВЕ ПОБЕДИЛА 2 АРМИЯ");
            }
            else
            {
                Console.WriteLine("******************************************* Раунд 3: ");
                int v = 0;
                if (Cavalry1.Count == 0)
                {
                    Cavalry1 = Walk1;
                    v = 1;
                }


                if (Cavalry2.Count == 0)
                {
                    Cavalry2 = Walk2;
                    v = 0;
                }



                int y=0;
                int y2=0;
               
                int p;
                while (Cavalry1.Count * Cavalry2.Count != 0)
                {
                    if (v == 1)
                    {
                        p = Cavalry2[y2].Power - Cavalry1[y].Power;
                        if (p < 0)
                        {
                            Cavalry2[y2].Power = 0;
                            Console.WriteLine("Убит второй");
                        }
                        else
                        {
                            Cavalry2[y2].Power = p;
                            Console.WriteLine("Убит первый");

                        }
                    }
                    else
                    {
                        p = Cavalry1[y].Power  - Cavalry2[y2].Power; ;

                        if (p < 0)
                        {
                            Cavalry1[y].Power = 0;
                            Console.WriteLine("Убит первый");
                        }
                        else
                        {
                            Cavalry1[y].Power = p;
                            Console.WriteLine("Убит второй");
                        }
                    }

                    if (Cavalry2[y2].Power == 0)
                    {
                        Cavalry2.RemoveAt(y2);
                    }
                    else
                    {
                        y2++;
                    }
                    if (Cavalry1[y].Power == 0)
                    {
                        Cavalry1.RemoveAt(y);
                    }
                    else
                    {
                        y++;
                    }
                    if (y2 >= Cavalry2.Count)
                    {
                        y2 = 0;
                    }
                    if (y >= Cavalry1.Count)
                    {
                        y = 0;
                    }
                }

          

            }

            Console.WriteLine(Cavalry2.Count + " - итоговый размер 2 армии");
            Console.WriteLine(Cavalry1.Count + " - итоговый размер 1 армии");
            if (Cavalry2.Count == 0)
            {
                Console.WriteLine("В БИТВЕ ПОБЕДИЛА 1 АРМИЯ");
            }
            else
            {
                Console.WriteLine("В БИТВЕ ПОБЕДИЛА 2 АРМИЯ");
            }
            Console.ReadLine(); 
        }
    }
}
