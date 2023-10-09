using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    class Trigonometrisk
    {
        public static void TrigonometriskBeräkning()
        {

            Console.WriteLine("vad är värdet för motsatta sidan?");
            string MotsattaInput = Console.ReadLine();

            Console.WriteLine("vad är värdet för intilliggande sida?");
            string intilliggandeInput = Console.ReadLine();

            Console.WriteLine("vad är värdet för hypotenusa?");
            string HypotenusaInput = Console.ReadLine();

            if (double.TryParse(MotsattaInput, out double Motsatta) && double.TryParse(intilliggandeInput, out double intilliggande))
            {
                Console.WriteLine(Math.Tan(Motsatta/intilliggande));
                Console.ReadLine();
            }
        }
    }
}
