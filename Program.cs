using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ulanov3Study
{


    public class Obrab
    {
        public static List<int> numbers = new List<int>();
        public static int ticketOrdinary = 0;
        public static int ticketPreferential = 0;
        public static int saturday = 0;
        public static int sunday = 0;
        public static int result = 0;
       public static int vivod = 0;
        public static int kolichestvo = 0;
        public static bool weatherSaturday = false;
        public static bool weatherSunday = false;

    }



    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


       
       
        public static void prog()
        {
            Random rnd = new Random();
            int valueSaturday = rnd.Next(0, 100); 
            int valueSunday = rnd.Next(0, 100);
            Obrab.weatherSaturday = false;
            Obrab.weatherSunday = false;

            
               


            // Если заданное число больше рандомного, то погода хорошая
            if (Obrab.saturday >= valueSaturday) 
            {
                Obrab.weatherSaturday = true;
            }
            if (Obrab.sunday >= valueSunday)
            {
                Obrab.weatherSunday = true;
            }

        

            if (Obrab.weatherSaturday && Obrab.weatherSunday) // хорошая хорошая
            {
                Obrab.result = Obrab.ticketPreferential;
                Obrab.vivod = 1;
                
                
            }
            else
            {
                Obrab.result = Obrab.ticketPreferential;
                Obrab.vivod = 0;
            }
           
            





        }




    }
}
