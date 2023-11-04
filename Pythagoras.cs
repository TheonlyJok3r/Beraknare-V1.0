
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    class Pythagoras
    {
        public static void Pythagoras_sats()
        {

            double KatA, KatB, hypotenusan;

            Console.WriteLine("Ange längden på sida A: ");
            string KatetAInput = Console.ReadLine();

            Console.WriteLine("Ange längden på sida B: ");
            string KatetBInput = Console.ReadLine();

            if (double.TryParse(KatetAInput, out KatA) && double.TryParse(KatetBInput, out KatB))
            {

                hypotenusan = Math.Sqrt((KatA * KatA) + (KatB * KatB));
                Console.WriteLine($"Hypotenusan är: {hypotenusan}");
                Console.ReadLine();

            }
            else if (double.TryParse(KatetAInput, out KatA))
            {

                Console.WriteLine("Ange längden på sida B: ");
                KatetBInput = Console.ReadLine();
                if (double.TryParse(KatetBInput, out KatB))
                {
                    hypotenusan = Math.Sqrt((KatA * KatA) + (KatB * KatB));
                    Console.WriteLine($"Hypotenusan är: {hypotenusan}");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Ogiltigt värde för sida B.");
                }
            }
            else if (double.TryParse(KatetBInput, out KatB))
            {

                Console.WriteLine("Ange längden på sida c: ");
                KatetAInput = Console.ReadLine();
                if (double.TryParse(KatetAInput, out KatA))
                {
                    hypotenusan = Math.Sqrt((KatA * KatA) + (KatB * KatB));
                    Console.WriteLine($"Hypotenusan är: {hypotenusan}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ogiltigt värde för sida A.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltiga värden för både sida A och sida B.");
            }
        }
    }
}
