using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string väljare = ("[red]Välj  en beräkning du vill mellan 1-12[/]");
            string Betyg = ("[red]Betyg[/]");
            string Pythagora_Sats = ("[red]Pythagoras Sats[/]");
            string Cirkelns_rea_och_omkrets = ("[red]Cirklens Area och Omkrets[/]");
            string Rektangels_Area = ("[red]Rektangels Area[/]");
            string Två_Klave = ("[red]Två Klave[/]");
            string Tid = ("[red]Tid[/]");
            string Barnens_ålder_för_present = ("[red]Barnens ålder för present[/]");
            string Tal_som_är_jämna_eller_udda = ("[red]Tal som är jämna eller udda[/]");
            string trekast_tärning = ("[red]3kast tärning[/]");
            string trigonometrisk_Funktion = ("[red]trigonometrisk Funktion[/]");
            string andragradekvation = ("[red]andragradekvation[/]");
            string Celsius_Fahrenheit = ("[red]Celsius->Fahrenheit[/]");
            string N1 = ("[fuchsia]1[/]");
            string N2 = ("[fuchsia]2[/]");
            string N3 = ("[fuchsia]3[/]");
            string N4 = ("[fuchsia]4[/]");
            string N5 = ("[fuchsia]5[/]");
            string N6 = ("[fuchsia]6[/]");
            string N7 = ("[fuchsia]7[/]");
            string N8 = ("[fuchsia]8[/]");
            string N9 = ("[fuchsia]9[/]");
            string N10 = ("[fuchsia]10[/]");
            string N11 = ("[fuchsia]11[/]");
            string N12 = ("[fuchsia]12[/]");


            string välkomnare = ("[red]Valkommen till beräknaren V1.0[/]");

            Console.Clear();
            AnsiConsole.Markup(@"	                         ____________________________________________________
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
            int UserMainInput = Convert.ToInt32(Console.ReadLine());

            if (UserMainInput >= 1 && UserMainInput <= 12)
            {
                Console.Clear();

                if (UserMainInput == 1)
                {
                    int betyg;
                    string namn;


                    Console.WriteLine("Skriv in ditt Namn: ");

                    namn = Console.ReadLine();
                    Console.WriteLine("skriv in betyget Mellan 1-100: ");

                    betyg = Convert.ToInt32(Console.ReadLine());
                    if (betyg > 1 && betyg < 100)
                    {
                        if (betyg >= 90)
                        {
                            Console.WriteLine("Du anlände på A, jätte bra jobbat " + namn);
                        }

                        else if (betyg >= 80)

                        {
                            Console.WriteLine("Du anlände på B, jätte bra jobbat " + namn);
                        }

                        else if (betyg >= 70)

                        {
                            Console.WriteLine("Du anlände på C, jätte bra jobbat " + namn);
                        }

                        else if (betyg >= 60)

                        {
                            Console.WriteLine("Du anlände på D, du kan bättre " + namn);
                        }

                        else if (betyg >= 40)

                        {
                            Console.WriteLine("Du anlände på E, vad händer? " + namn);
                        }

                        else if (betyg <= 40)

                        {
                            Console.WriteLine("Du anlände F, ge upp " + namn);
                        }

                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig Tal! Skriv in ditt betyg som ska vara mellan 1-100.");
                        Thread.Sleep(2000);
                    }

                    Console.Clear();
                }
                else if (UserMainInput == 2)
                {
                    double KatA, KatB, hypotenusan;

                    Console.WriteLine("Ange längden på sida A annars skriv in värdet 0 : ");
                    KatA = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ange längden på sida B annars skriv in värdet 0 : ");
                    KatB = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ange längden på Hypotenusan C annars skriv in värdet 0 : ");
                    hypotenusan = Convert.ToInt32(Console.ReadLine());

                    if (KatA > 0 && KatB > 0 && hypotenusan == 0)
                    {
                        hypotenusan = Math.Sqrt((KatA * KatA) + (KatB * KatB));
                        Console.WriteLine($"Hypotenusan är: {hypotenusan}");
                        Console.ReadLine();
                    }
                    else if (KatA == 0)
                    {
                        KatB = Math.Sqrt((hypotenusan * hypotenusan) / (KatB * KatB));
                        Console.WriteLine($"Katetns längd för A  är: {KatA}");
                        Console.ReadLine();
                    }
                    else if (KatB == 0)
                    {
                        hypotenusan = Math.Sqrt((hypotenusan * hypotenusan) / (KatA * KatA));
                        Console.WriteLine($"Hypotenusan är: {KatB}");
                        Console.ReadLine();
                    }
                    else if (KatA > 0 && KatB > 0 && hypotenusan > 0)
                    {
                        Console.WriteLine("du har all information varför behöver du mig ?");
                        Thread.Sleep(2000);
                    }
                }
                else if (UserMainInput == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Vill du beräkna Arean av cirkeln(1) eller Omkretsen(2)");
                    int AreaOrDiameter = Convert.ToInt32(Console.ReadLine());


                    if (AreaOrDiameter == 1)
                    {
                        Console.WriteLine("har du radie för cirkel(1) eller radien 'r^2' (2)?");

                        int RadieellerRadien = Convert.ToInt32(Console.ReadLine());

                        if (RadieellerRadien == 1)
                        {
                            Console.WriteLine("Skriv in Radie cirkeln(?) ");
                            int Radie1 = Convert.ToInt32(Console.ReadLine());
                            double AreaRadie = (Radie1 * Radie1) * 3.14;
                            Console.WriteLine("Arean för Cirkeln är: " + AreaRadie);

                            Console.ReadLine();
                        }
                        else if (RadieellerRadien == 2)
                        {
                            Console.WriteLine("Skriv in cirkelns radien 'r^2'  (?) ");
                            int Radie2 = Convert.ToInt32(Console.ReadLine());
                            double AreaRadie2 = Radie2 * 3.14;
                            Console.WriteLine("Arean för Cirkeln är: " + AreaRadie2);

                            Console.ReadLine();
                        }
                    }
                    else if (AreaOrDiameter == 2)
                    {
                        Console.WriteLine("har du radie för cirkel(1) eller radien 'r^2' (2)?");

                        int RadieOrDiameter2 = Convert.ToInt32(Console.ReadLine());

                        if (RadieOrDiameter2 == 1)
                        {
                            Console.WriteLine("Vad är Cirkelns radie 'r' : ");
                            double Diameter1 = Convert.ToDouble(Console.ReadLine());
                            double Diameter_Results1 = Diameter1 + Diameter1;

                            Console.WriteLine("Cirkelns omkrets är: " + Diameter_Results1);
                            Console.ReadLine();
                        }
                        else if (RadieOrDiameter2 == 2)
                        {
                            Console.WriteLine("Vad är radien för cirkeln 'r^2' : ");
                            double Diameter2 = Convert.ToDouble(Console.ReadLine());
                            double Diameter_Results2 = Diameter2 / 2;

                            Console.WriteLine("Cirkelns omkrets är: " + Diameter_Results2);
                            Console.ReadLine();
                        }
                    }
                }
                else if (UserMainInput == 4)
                {
                    Console.WriteLine("Vad är Basen(b) för Rektangeln: ");
                    double Basen = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Vad är Höjden(h) för Rektangeln: ");
                    double Höjden = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                    if (Basen > 0 && Höjden > 0)
                    {
                        Console.WriteLine("Area för Rektangeln: " + Basen * Höjden);
                        Console.ReadLine();
                    }

                    Console.Clear();
                    Console.WriteLine("Ogiltig information, skriv in basen och höjden... ");
                }
                else if (UserMainInput == 5)
                {
                    Random random = new Random();

                    int num1 = random.Next(1, 3);
                    int num2 = random.Next(1, 3);
                    if (num1 == 1 && num2 == 1)
                    {
                        Console.WriteLine("Det blev klave på klave.Grattis du fick 1kr!");
                    }

                    else if (num1 == 2 && num2 == 2)
                    {
                        Console.WriteLine("Det blev krona på krona.Grattis du fick 2kr!");
                    }
                    else if (num1 == 1 && num2 == 2 || num1 == 2 && num2 == 1)
                    {
                        Console.WriteLine("Det blev två olika. Grattis du fick 4kr!");
                    }

                    Console.ReadLine();
                }
                else if (UserMainInput == 6)
                {
                    Console.WriteLine("Skriv in antal sekunder du har");

                    double Sekunder = Convert.ToDouble(Console.ReadLine());


                    double Minuter = Sekunder / 60;
                    double Timmar = Minuter / 60;
                    Console.WriteLine(Math.Round(Timmar, 2) + "h" + ", " + Minuter + "m" + ", " + Sekunder + "s");
                    Console.ReadLine();
                }
                else if (UserMainInput == 7)
                {
                    int Ålder;

                    Console.WriteLine("Vad för ålder har barnen? ");

                    Ålder = Convert.ToInt32(Console.ReadLine());

                    if (Ålder < 12 && Ålder > 5)
                    {
                        Console.WriteLine("Grattis här så får du en ballong!");
                        Console.WriteLine(@"        ,,,,,,,,,,,,,
    .;;;;;;;;;;;;;;;;;;;,.
  .;;;;;;;;;;;;;;;;;;;;;;;;,
.;;;;;;;;;;;;;;;;;;;;;;;;;;;;.
;;;;;@;;;;;;;;;;;;;;;;;;;;;;;;' .............
;;;;@@;;;;;;;;;;;;;;;;;;;;;;;;'.................
;;;;@@;;;;;;;;;;;;;;;;;;;;;;;;'...................
`;;;;@;;;;;;;;;;;;;;;@;;;;;;;'.....................
 `;;;;;;;;;;;;;;;;;;;@@;;;;;'..................;....
   `;;;;;;;;;;;;;;;;@@;;;;'....................;;...
     `;;;;;;;;;;;;;@;;;;'...;.................;;....
        `;;;;;;;;;;;;'   ...;;...............;.....
           `;;;;;;'        ...;;..................
              ;;              ..;...............
              `                  ............
             `                      ......
            `                         ..
           `                           '
          `                           '
         `                           '
        `                           `
        `                           `,
        `
         `
           `.
");
                    }
                    else if (Ålder < 17 && Ålder > 11)
                    {
                        Console.WriteLine("Här så får du en glass!");
                        Console.WriteLine(@"      (__)
     (____)
    (______)
   (________)
  (__________)
   \/\/\/\/\/
    \/\/\/\/
     \/\/\/
      \/\/
       \/");
                    }
                    else
                    {
                        Console.WriteLine("tyvärr du fick inget");
                    }
                }
                else if (UserMainInput == 8)
                {
                    Console.Clear();

                    Console.WriteLine("Vad för tal ska du dividera med .../2 ");
                    int Tal = Convert.ToInt32(Console.ReadLine());

                    if (Tal % 2 == 0 && Tal > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Talet är Jämt men Positiv.");
                        Console.ReadLine();
                    }
                    else if (Tal % 2 == -0 && Tal < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Talet är Jämt men Negativ.");
                        Console.ReadLine();
                    }
                    else if (Tal % 2 == 0 && Tal > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Talet är Udda men Positiv.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Talet är Udda men Negativ.");
                        Console.ReadLine();
                    }


                    Console.Clear();

                    Console.WriteLine("Ogiltig Information, Skriv in gärna vad för tal du vill använda");
                    Console.ReadLine();
                }
                else if (UserMainInput == 9)
                {
                    Console.WriteLine(
                        "Tryck på Enter för att kasta dina 3 tärningar vad största nummmern är");

                    Random random = new Random();

                    int dice1 = random.Next(1, 7);
                    int dice2 = random.Next(1, 7);
                    int dice3 = random.Next(1, 7);
                    if (dice1 > dice2 && dice1 > dice3)
                    {
                        Console.WriteLine(
                            "Högsta nummer från dess tre kast av tärningarna var första tärning med värdet: " +
                            dice1);
                    }
                    else if (dice2 > dice1 && dice2 > dice3)
                    {
                        Console.WriteLine(
                            "Högsta nummer från dess tre kast av tärningarna var andra tärning med värdet: " +
                            dice2);
                    }
                    else if (dice3 > dice1 && dice3 > dice2)
                    {
                        Console.WriteLine(
                            "Högsta nummer från dess tre kast av tärningarna var trejde tärning med värdet: " +
                            dice3);
                    }
                }
                else if (UserMainInput == 10)
                {
                    Console.WriteLine("vad är värdet för motsatta sidan, om inte vet skriv in 0?");
                    double Motsatta = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("vad är värdet för intilliggande sida, om inte vet skriv in 0??");
                    double intilligande = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("vad är värdet för hypotenusa, om inte vet skriv in 0??");
                    double Hypotenusan = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                    if (intilligande > 0 && Hypotenusan > 0)
                    {
                        Console.WriteLine(Math.Sin(intilligande / Hypotenusan));
                        Console.ReadLine();
                    }
                    else if (Motsatta > 0 && Hypotenusan > 0)
                    {
                        Console.WriteLine(Math.Cos(Motsatta / Hypotenusan));
                        Console.ReadLine();
                    }
                    else if (intilligande > 0 && Motsatta > 0)
                    {
                        Console.WriteLine(Math.Tan(intilligande / Motsatta));
                        Console.ReadLine();
                    }

                    Console.WriteLine("Skriv in minst två värden in");
                    Console.ReadLine();
                }
                else if (UserMainInput == 11)
                {
                    Console.WriteLine("vad för X^2 har du? ,om du har ingen värde skriv in 0");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Vad för x har du? ");
                    int x2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Vad för q har du , om du inte har något skriv in '0' ? ");
                    int q = Convert.ToInt32(Console.ReadLine());


                    if (x > 0 && x2 > 0 && q > 0)
                    {
                        x2 = x2 / x;
                        q = q / x;

                        var innerSqrtValue = Math.Pow((x2 / 2) - q, 2);
                        var positiveResult = -(x2 / 2) + Math.Sqrt(innerSqrtValue);
                        var negativeResult = -(x2 / 2) - Math.Sqrt(innerSqrtValue);
                        int numberSquared = (int)Math.Sqrt(innerSqrtValue);
                        if ((int)Math.Pow(numberSquared, 2) == innerSqrtValue)
                        {
                            Console.WriteLine("Punkten på X1 är " + positiveResult +
                                              " Och punkten på X2 är " +
                                              negativeResult);
                            Console.ReadLine();
                        }

                        Console.WriteLine("Du har ett ej rell tal");
                    }
                    else if (x > 0 && x2 > 0)
                    {
                        q = 0;
                        x2 = x2 / x;
                        var innerSqrtValue = Math.Pow((x2 / 2), 2) - q;
                        var positiveResult = -(x2 / 2) + Math.Sqrt(innerSqrtValue);
                        var negativeResult = -(x2 / 2) - Math.Sqrt(innerSqrtValue);
                        int numberSquared = (int)Math.Sqrt(innerSqrtValue);
                        if ((int)Math.Pow(numberSquared, 2) == innerSqrtValue)
                        {
                            Console.WriteLine("Punkten på X1 är " + positiveResult +
                                              " Och punkten på X2 är " +
                                              negativeResult);
                            Console.ReadLine();
                        }

                        Console.WriteLine("Du har ett ej rell tal");
                    }
                    else if (x2 > 0 && q > 0 && x == 0)

                    {
                        var innerSqrtValue = Math.Pow((x2 / 2), 2) - q;

                        var positiveResult = -(x2 / 2) + Math.Sqrt(innerSqrtValue);
                        var negativeResult = -(x2 / 2) - Math.Sqrt(innerSqrtValue);
                        var numberSquared = (int)Math.Sqrt(innerSqrtValue);
                        if ((int)Math.Pow(numberSquared, 2) == innerSqrtValue)
                        {
                            Console.WriteLine("Punkten på X1 är " + positiveResult +
                                              " Och punkten på X2 är " +
                                              negativeResult);
                            Console.ReadLine();
                        }

                        Console.WriteLine("Du har ett ej rell tal");
                    }
                    else if (x2 > 0 && x == 0 && q == 0)
                    {
                        var innerSqrtValue = (int)Math.Pow((x2 / 2), 2) - q;
                        var positiveResult = -(x2 / 2) + Math.Sqrt(innerSqrtValue);
                        var negativeResult = -(x2 / 2) - Math.Sqrt(innerSqrtValue);
                        int numberSquared = (int)Math.Sqrt(innerSqrtValue);
                        if ((int)Math.Pow(numberSquared, 2) == innerSqrtValue)
                        {
                            Console.WriteLine("Punkten på X1 är " + positiveResult +
                                              " Och punkten på X2 är " +
                                              negativeResult);
                            Console.ReadLine();
                        }

                        Console.WriteLine("Du har ett ej rell tal");
                    }

                    Console.ReadLine();
                }
                else if (UserMainInput == 12)
                {
                    Console.WriteLine("Vill har du Grader/C (1) eller Fahrenheit/F (2)?");
                    int FahrenheitorDegrees = Convert.ToInt32(Console.ReadLine());
                    double F = 0, C = 0;

                    if (FahrenheitorDegrees == 1)
                    {
                        Console.WriteLine("Vad för Grader har du? ");
                        C = Convert.ToDouble(Console.ReadLine());
                        C = (F - 32) * (5 / 9);
                        Console.WriteLine($"Värmen är {C} \u00b0C");
                    }
                    else if (FahrenheitorDegrees == 2)
                    {
                        Console.WriteLine("Vad för Grader har du? ");
                        F = Convert.ToDouble(Console.ReadLine());
                        F = (C * (9 / 5)) + 32;

                        Console.WriteLine($"Värmen är {F} F");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ogiltig information, välj en beräkning mellan 1-12. ");
                    Console.ReadLine();
                }

                Console.ReadLine();
            }
        }
    }
}
}