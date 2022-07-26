using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            pirate1.Story();


            Console.ReadKey();

        }
    }

    class Pirate
    {
        string name;
        int godRojdenia;
        int kolichestvoGlaz;
        string piratType;
        string eyeType;

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


        public void Story (){
            Console.WriteLine();
            Console.WriteLine($"Вас приветствует пират {name}. Так как я родился в {godRojdenia} году, то я {piratType} пират и {eyeType}. У меня {agressia} агрессия " +
                $"и {jestokost} жестокость. ");
            Console.WriteLine("Хочу вам рассказать, как прошел мой последний поход:");

            Console.WriteLine();
            Grabit();
            Umirat();
        }



        public void InfoAbout(string namePirat, int godRojdeniaPirata, int kolichestvoGlazPirata)
        {
            name = namePirat;
            godRojdenia = godRojdeniaPirata;
            kolichestvoGlaz = kolichestvoGlazPirata;


            if (godRojdenia<2100)
            {
                piratType = "морской";
            }
            else
            {
                piratType = "космический";
            }

            if (kolichestvoGlaz<2)
            {
                eyeType = "предыдущие битвы оставили на моем лице следы";
            }
            else if (kolichestvoGlaz == 2)
            {
                eyeType = "я неплохо сохранился как для пирата";
            }
            else if (kolichestvoGlaz > 2)
            {
                eyeType = "я рептилоид";
            }
            else { }

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
            
            for (int i = 0; i < 4; i++)
            {
                if (i%2==0)
                {
                Console.WriteLine("Выстрелил во врага");
                    Thread.Sleep(1000);
                    Pit();
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Похитил сокровище");
                    Thread.Sleep(1000);
                    Pit();
                    Thread.Sleep(1000);
                }

            }
            PodniatFlag();
            IgratMyziky();

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

            Console.WriteLine("Торжественно развернул над полем битвы свой флаг.");

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
            Console.ResetColor();
        }

        public void IgratMyziky()
        {
            Console.Beep(220, 500);
            Thread.Sleep(50);
            Console.Beep(262, 500);
            Thread.Sleep(50);
            Console.Beep(294, 500);
            Thread.Sleep(25);
            Console.Beep(294, 500);
            Thread.Sleep(50);

            Console.Beep(294, 500);
            Thread.Sleep(50);
            Console.Beep(330, 500);
            Thread.Sleep(50);
            Console.Beep(349, 500);
            Thread.Sleep(25);
            Console.Beep(349, 500);
            Thread.Sleep(50);

            Console.Beep(349, 500);
            Thread.Sleep(50);
            Console.Beep(392, 500);
            Thread.Sleep(50);
            Console.Beep(330, 500);
            Thread.Sleep(25);
            Console.Beep(349, 500);
            Thread.Sleep(50);


            Console.Beep(294, 500);
            Thread.Sleep(50);
            Console.Beep(262, 500);
            Thread.Sleep(50);
            Console.Beep(262, 500);
            Thread.Sleep(25);
            Console.Beep(294, 500);
            Thread.Sleep(50);

        }

        public void Umirat()
        {
            Console.WriteLine("И умер от полученных в бою ран.");
        }



    }
}
