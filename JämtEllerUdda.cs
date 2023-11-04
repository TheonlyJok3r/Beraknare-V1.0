
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{


    class JämtEllerUdda
    {
        public static void JämtUdda()
        {
            string TalUserInput;
            int Tal;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Vad för tal ska du dividera med .../2 ");
                TalUserInput = Console.ReadLine();

                if (int.TryParse(TalUserInput, out Tal) && Tal % 2 == 0 && Tal > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Talet är Jämt men Positiv.");
                    Console.ReadLine();
                    break;
                }
                else if (Tal % 2 == -0 && Tal < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Talet är Jämt men Negativ.");
                    Console.ReadLine();
                    break;
                }
                else if (Tal % 2 == 0 && Tal > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Talet är Udda men Positiv.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Talet är Udda men Negativ.");
                    Console.ReadLine();
                    break;
                }


                Console.Clear();

                Console.WriteLine("Ogiltig Information, Skriv in gärna vad för tal du vill använda");
                Console.ReadLine();

            }
        }
    }
}
