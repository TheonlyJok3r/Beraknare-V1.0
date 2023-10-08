using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    class Program
    {

        static void Main(string[] args)
        {

            int UserMainInput;
            string välkomnare = "Valkommen till beräknaren V1.0".Pastel(ConsoleColor.Red);


            string väljare = "Välj  en beräkning du vill mellan 1-12".Pastel(ConsoleColor.Red);


            string Betyg = "Betyg".Pastel(ConsoleColor.Red);
            string Pythagora_Sats = "Pythagoras Sats".Pastel(ConsoleColor.Red);
            string Cirkelns_rea_och_omkrets = "Cirklens Area och Omkrets".Pastel(ConsoleColor.Red);
            string Rektangels_Area = "Rektangels Area".Pastel(ConsoleColor.Red);
            string Två_Klave = "Två Klave".Pastel(ConsoleColor.Red);
            string Tid = "Tid".Pastel(ConsoleColor.Red);
            string Barnens_ålder_för_present = "Barnens ålder för present".Pastel(ConsoleColor.Red);
            string Tal_som_är_jämna_eller_udda = "Tal som är jämna eller udda".Pastel(ConsoleColor.Red);
            string trekast_tärning = "3kast tärning".Pastel(ConsoleColor.Red);
            string trigonometrisk_Funktion = "trigonometrisk Funktion".Pastel(ConsoleColor.Red);
            string andragradekvation = "andragradekvation".Pastel(ConsoleColor.Red);
            string Celsius_Fahrenheit = "Celsius->Fahrenheit".Pastel(ConsoleColor.Red);
            String N1 = "1".Pastel(ConsoleColor.Magenta);
            String N2 = "2".Pastel(ConsoleColor.Magenta);
            String N3 = "3".Pastel(ConsoleColor.Magenta);
            String N4 = "4".Pastel(ConsoleColor.Magenta);
            String N5 = "5".Pastel(ConsoleColor.Magenta);
            String N6 = "6".Pastel(ConsoleColor.Magenta);
            String N7 = "7".Pastel(ConsoleColor.Magenta);
            String N8 = "8".Pastel(ConsoleColor.Magenta);
            String N9 = "9".Pastel(ConsoleColor.Magenta);
            String N10 = "10".Pastel(ConsoleColor.Magenta);
            String N11 = "11".Pastel(ConsoleColor.Magenta);
            String N12 = "12".Pastel(ConsoleColor.Magenta);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"	                     ____________________________________________________
	                    ||████████ " + välkomnare + @" ██████████||
	                     \<><><><><><><><><><><><><><><><><><><><><><><><><>/
	                      \<><><><><><><><><><><><><><><><><><><><><><><><>/
	                       \<><><><><><><><><><><><><><><><><><><><><><><>/
	                        \<><><><><><><><><><><><><><><><><><><><><><>/
				|<> " + väljare + @" <>|
	                        |<><><><><><><><><><><><><><><><><><><><><><>|
	                        |" + N1 + @" |<><><><><><>" + Betyg + @"<><><><><><><><><><><><>|
	                        |" + N2 + @" |<><><><><><>" + Pythagora_Sats + @"<><><><><><><>|
	                        |" + N3 + @" |<><><><><><>" + Cirkelns_rea_och_omkrets + @"<><>|
	                        |" + N4 + @" |<><><><><><>" + Rektangels_Area + @"<><><><><><><>|
	                        |" + N5 + @" |<><><><><><>" + Två_Klave + @"<><><><><><><><><><>|
	                        |" + N6 + @" |<><><><><><>" + Tid + @"<><><><><><><><><><><><><>|
	                        |" + N7 + @" |<><><><><><>" + Barnens_ålder_för_present + @"<><>|
	                        |" + N8 + @" |<><><><><><>" + Tal_som_är_jämna_eller_udda + @"<>|
	                        |" + N9 + @" |<><><><><><>" + trekast_tärning + @"<><><><><><><><>|
	                        |" + N10 + @"|<><><><><><>" + trigonometrisk_Funktion + @"<><><>|
	                        |" + N11 + @"|<><><><><><>" + andragradekvation + @"<><><><><><>|
	                        |" + N12 + @"|<><><><><><>" + Celsius_Fahrenheit + @"<><><><><>|
	                        |<><><><><><><><><><><><><><><><><><><><><><>|
	                        |____________________________________________|
	                       /<><><><><><><><><><><><><><><><><><><><><><><>\
	                      /<><><><><><><><><><><><><><><><><><><><><><><><>\
	                     /<><><><><><><><><><><><><><><><><><><><><><><><><>\
	                    /<><><><><><><><><><><><><><><><><><><><><><><><><><>\
	                   ||                                                    ||");



                String MainInput = Console.ReadLine();

                if (int.TryParse(MainInput, out UserMainInput) && UserMainInput >= 1 && UserMainInput <= 12)
                {
                    Console.Clear();
                    break;
                }

                Console.Clear();
                Console.WriteLine("Ogiltig information, välj en beräkning mellan 1-12. ");
                Console.ReadLine();
            }

            switch (UserMainInput)
            {
                case 1:
                    GradeCalc.Grades();
                    break;

            }
        }
    }
}
