using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{


    class RektangelnsArea
    {
        public static void Rektangelns_Area()
        {
            string BasenInput, HöjdenInput;
            double Basen, Höjden;

            while (true)
            {
                Console.WriteLine("Vad är Basen(b) för Rektangeln: ");
                BasenInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Vad är Höjden(h) för Rektangeln: ");
                HöjdenInput = Console.ReadLine();
                Console.Clear();

                if (double.TryParse(BasenInput, out Basen) && double.TryParse(HöjdenInput, out Höjden))
                {
                    Console.WriteLine("Area för Rektangeln: " + Basen * Höjden);
                    Console.ReadLine();
                    break;
                }

                Console.Clear();
                Console.WriteLine("Ogiltig information, skriv in basen och höjden... ");
            }
        }
    }
}
