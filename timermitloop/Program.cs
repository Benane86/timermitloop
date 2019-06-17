using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;


namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minuten eingeben!");
            int time1 = Convert.ToInt32(Console.ReadLine());
            int minuten = time1 * 60000;
            Console.WriteLine("Sekunden eingaben!");
            int time2 = Convert.ToInt32(Console.ReadLine());
            int sekunden = time2 * 1000;
            int timeoverall = (time1 * 60) + time2;
            int endtime = minuten + sekunden;
            string text = Unterteilung(minuten);
            int teiler = Unterteilungzeit(text);
            Console.WriteLine("Timer gestartet, {0} " + text + " verbleibend", (endtime / 1000) / teiler);
          //  Console.WriteLine("timeroverall = " + timeoverall);
          //  Console.WriteLine("endtime = " + endtime);

            // int endtime1 = endtime / timeoverall;
            //int endtime2 = endtime / timeoverall;
            //int endtime3 = endtime / timeoverall;


            int endtime1 = endtime / timeoverall;
            int endtimecheck = endtime1 - timeoverall;
          //  Console.WriteLine("endtimecheck = " + endtimecheck);
           // Console.WriteLine("endtime1 = " + endtime1);
            do
            {
               // Console.WriteLine(endtime1);
                //Console.WriteLine("-");
                //Console.WriteLine("+");
                Console.WriteLine("{0} " + text + " verbleiben", (endtime1 - endtimecheck) / teiler);
                Thread.Sleep(endtime1);
                endtime1 = endtime1 - 1;
            } while (endtime1 > endtimecheck);


         //   Console.WriteLine(timeoverall);
            // Console.WriteLine(text);
            // Console.WriteLine(minuten);
            //Console.WriteLine("{0} {1} {2} {3}", endtime, endtime1, endtime2, endtime3);
            
           // Thread.Sleep(endtime1);
          //  Console.WriteLine("{0} " + text + " verbleiben", ((endtime - (endtime1 * 1)) / 1000) / teiler);
           
            //Thread.Sleep(endtime);
            Console.WriteLine("es sind {0} Minuten {1} Sekunden vergangen", time1, time2);
            SystemSounds.Beep.Play();
            Console.ReadKey();
        }
        static string Unterteilung(int a)
        {
            if (a == 0)
            {
                return "Sekunden";
            }
            else if (a == 60000)
            {
                return "Sekunden";
            }
            else if (a == 120000)
            {
                return "Sekunden";
            }
            else if (a == 180000)
            {
                return "Sekunden";
            }
            else
            {
                return "Minuten";
            }

        }
        static int Unterteilungzeit(string a)
        {
            if (a == "Sekunden")
            {
                return 1;
            }
            else if (a == "Minuten")
            {
                return 60;
            }
            else
            {
                return 0;
            }

        }

    }
}
