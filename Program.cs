using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWHero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pirate pirate1 = new Pirate();

            Console.WriteLine("Введите Имя пирата");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения пирата");
            int birthDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество глаз пирата");
            int eyes = int.Parse(Console.ReadLine());


            pirate1.InfoAbout(name, birthDate, eyes);
            pirate1.Grabit();

            Console.Beep(1000, 500);

            Console.ReadKey();

        }
    }

    class Pirate
    {
        string name;
        int godRojdenia;
        int kolichestvoGlaz;

        string agressia = "Большая";
        string jestokost = "Огромная";


        // свойства
        string Jestokost
        {
            get { return jestokost; }
            set { jestokost = value; }
        }
        string Agressia {
             get { return agressia; }
             set { jestokost = value; }
            }
        


        public void InfoAbout(string namePirat, int godRojdeniaPirata, int kolichestvoGlazPirata)
        {
            name = namePirat;
            godRojdenia = godRojdeniaPirata;
            kolichestvoGlaz = kolichestvoGlazPirata;

        }


        void Pit()
        {
            string drink;
            if (godRojdenia<2100)
            {
                drink = "рома";
            }
            else
            {
                drink = "ягодного смузи";
            }
            Console.WriteLine("Выпил бутылку " + drink);
          
        }

        public void Grabit()
        {
            
            for (int i = 0; i < 6; i++)
            {
                if (i%2==0)
                {
                Console.WriteLine("Выстрелил во врага");
                Pit();
                }
                else
                {
                    Console.WriteLine("Похитил сокровище");
                    Pit();
                }

            }
            PodniatFlag();

        }

        void PodniatFlag()
        {

            byte [,] flag =
            {
{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 ,1, 0, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1 ,1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}

            };

            for (int i = 0; i < 21; i++)
            {

                for (int j = 0; j < 23; j++)
                {
                    if (flag[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[]"); 
                    }        
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }
        }

        public void IgratMyziky()
        {

        }

        public void Umirat()
        {
            Console.WriteLine("Умер");
        }



    }
}
