using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{


    class Tid
    {
        public static void tid()
        {
            int Timmar, Minuter, Sekunder;

            Console.WriteLine("Skriv in antal sekunder du har");

            Sekunder = Convert.ToInt32(Console.ReadLine());


            Minuter = Sekunder / 60;
            Timmar = Minuter / 60;
            Console.WriteLine(Timmar + "h" + ", " + Minuter + "m" + ", " + Sekunder + "s");
            Console.ReadLine();
        }
    }
}
