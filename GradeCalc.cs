using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;


namespace Beräknare_V1._0
{
    class GradeCalc
    {
        public static void Grades()
        {

            int betyg;
            string namn, betyg1;


            while (true)
            {

                Console.WriteLine("Skriv in ditt Namn: ");

                namn = Console.ReadLine();
                Console.WriteLine("skriv in betyget Mellan 1-100: ");

                betyg1 = Console.ReadLine();
                if (int.TryParse(betyg1, out betyg) && betyg > 1 && betyg < 100)
                {
                    break;
                }

                Console.WriteLine("Ogiltig Tal eller information. Skriv in ditt betyg som ska vara mellan 1-100.");
                Thread.Sleep(2000);

                Console.Clear();
            }

            if (betyg >= 90)
            {

                Console.WriteLine("Du anlände på A, jätte bra jobbat " + namn);

                Console.ReadLine();
            }

            else if (betyg >= 80)

            {

                Console.WriteLine("Du anlände på B, jätte bra jobbat " + namn);
                Console.ReadLine();
            }

            else if (betyg >= 70)

            {

                Console.WriteLine("Du anlände på C, jätte bra jobbat " + namn);
                Console.ReadLine();
            }

            else if (betyg >= 60)

            {

                Console.WriteLine("Du anlände på D, du kan bättre " + namn);
                Console.ReadLine();
            }

            else if (betyg >= 40)

            {

                Console.WriteLine("Du anlände på E, vad händer? " + namn);
                Console.ReadLine();
            }

            else if (betyg <= 40)

            {

                Console.WriteLine("Du anlände F, ge upp " + namn);
                Console.ReadLine();
            }

            

        }

    }
}
