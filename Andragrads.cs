
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    class Andragrads
    {
        public static bool IsPerfectRoot(int number)
        {
            var numberSquared = (int)Math.Sqrt(number);
            if ((int)Math.Pow(numberSquared, 2) == number)
            {
                return true;
            }
            else return false;
        }

        private static void CalculateResult(double p, double processedQ)
        {
            var innerSqrtValue = Math.Pow(p / 2, 2) - processedQ;
            if (!IsPerfectRoot((int)innerSqrtValue))
            {
                Console.WriteLine("fel write a perfect number");
                Console.ReadLine();
                return;
            }

            var positiveResult = -(p / 2) + Math.Sqrt(innerSqrtValue);
            var negativeResult = -(p / 2) - Math.Sqrt(innerSqrtValue);


            Console.WriteLine("Första punkten är " + positiveResult + "X1");
            Console.WriteLine("Andra punkten är " + negativeResult + "X2");
            Console.ReadLine();
        }

        public static void AndraGradsEkvation()
        {
            while (true)
            {
                Console.WriteLine("vad för X^2 har du? ");
                string Inputx = Console.ReadLine();

                Console.WriteLine("Vad för x har du? ");
                string Inputx2 = Console.ReadLine();

                Console.WriteLine("Vad för q har du , om du inte har något skriv in '0' ? ");
                string Inputq = Console.ReadLine();

                double x, x2, q;
                if (double.TryParse(Inputx, out x)
                    && double.TryParse(Inputx2, out x2)
                    && double.TryParse(Inputq, out q))
                {
                    CalculateResult(x2 / x, q / x);
                    break;
                }else if (double.TryParse(Inputx, out x)
                    && double.TryParse(Inputx2, out x2))
                {
                    CalculateResult(x2 / x, 0);
                    break;
                }
                //När P och Q är känt och x^2 är 1.
                else if (double.TryParse(Inputx, out x) && double.TryParse(Inputx2, out x2))
                {
                    CalculateResult(x2 / x, 0);
                    break;
                }
                else if (double.TryParse(Inputx2, out x2))
                {
                    CalculateResult(x2, 0);
                    break;
                }

                Console.WriteLine("feel skriv rätt");
                Console.ReadLine();
            }
        }
    }
}