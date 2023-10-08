using System;

namespace Beräknare_V1._0
{
    class GradeCalc
    {
        public static void Grades()
        {

            int betyg;

            Console.WriteLine("Skriv in ditt Namn: ");

            string namn = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("skriv in betyget Mellan 1-100: ");
            
            String betyg1 = Console.ReadLine();
            Console.Clear();
            while (true)
            {

                if (int.TryParse(betyg1, out betyg) && betyg > 1 && betyg < 100)
                {
                    break;
                }

                Console.WriteLine("Ogiltig Tal eller information. Skriv in ditt betyg som ska vara mellan 1-100.");
                Console.ReadLine();
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

                Console.WriteLine("Du anlände på c, jätte bra jobbat " + namn);
                Console.ReadLine();
            }

            else if (betyg >= 60)

            {

                Console.WriteLine("Du anlände på C, du kan bättre " + namn);
                Console.ReadLine();
            }

            else if (betyg >= 50)

            {

                Console.WriteLine("Du anlände på D, vad händer? " + namn);
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
