using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    partial class Trigonometrisk
    {
        public static void TrigonometriskBeräkning()
        {

            Console.WriteLine("vad är värdet för motsatta sidan?");
            string MotsattaInput = Console.ReadLine();

            Console.WriteLine("vad är värdet för intilliggande sida?");
            string intilliggandeInput = Console.ReadLine();

            Console.WriteLine("vad är värdet för hypotenusa?");
            string HypotenusaInput = Console.ReadLine();
            Console.Clear();

            if (double.TryParse(intilliggandeInput, out double intilligande) && double.TryParse(HypotenusaInput, out double Hypotenusan))
            {
                Console.WriteLine(Math.Sin(intilligande / Hypotenusan));
            }
            else if (double.TryParse(MotsattaInput, out double Motsatta) && double.TryParse(HypotenusaInput, out double Hypotenusan2))
            {
                Console.WriteLine(Math.Cos(Motsatta / Hypotenusan2));
            }
            else if (double.TryParse(intilliggandeInput, out double intilliggande2) && double.TryParse(MotsattaInput, out double Motsatta2))
            {

                Console.WriteLine(Math.Tan(intilliggande2 / Motsatta2));
            }
            Console.ReadLine();
        }
    }
}
