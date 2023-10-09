using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    class Cirkelns_Area_Omkrets
    {
        public static void Cirkelns_AreaOmkrets()
        {

            String InputAreaOrDiameter;
            int AreaOrDiameter;


            while (true)
            {
                Console.Clear();

                Console.WriteLine("Vill du beräkna Arean av cirkeln(1) eller Omkretsen(2)");
                InputAreaOrDiameter = Console.ReadLine();

                if (int.TryParse(InputAreaOrDiameter, out AreaOrDiameter) && AreaOrDiameter > 0 && AreaOrDiameter < 3)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Välj ett giltigt val mellan 1 och 2 för en beräkning du vill beräkna för.");
                Console.ReadLine();
            }
            String RADIE_OR_RADIEN_FOR_DIAMETER;
            double Diameter, Diameter_Results;
            while (AreaOrDiameter == 2)
            {
                Console.WriteLine("har du Radie för cirkeln(1) eller radien(2)?");

                RADIE_OR_RADIEN_FOR_DIAMETER = Console.ReadLine();

                if (double.TryParse(RADIE_OR_RADIEN_FOR_DIAMETER, out Diameter) && Diameter == 1)
                {
                    Diameter_Results = Diameter + Diameter;

                    Console.WriteLine("Cirkelns omkrets är: " + Diameter_Results);
                    Console.ReadLine();

                }
                else if (Diameter == 2)
                {
                    Diameter_Results = Diameter / 2;
                    Diameter_Results = Diameter + Diameter;

                    Console.WriteLine("Cirkelns omkrets är: " + Diameter_Results);
                    Console.ReadLine();
                }
            }
            string RadieInput, RadienInput, RADIE_OR_RADIEN;
            double Cirkel_User_Input_Save, Radie, Radien;
            double Pi = 3.14;

            while (AreaOrDiameter == 1)
            {
                Console.WriteLine("har du Radie för cirkeln(1) eller radien(2)?");
                RADIE_OR_RADIEN = Console.ReadLine();


                if (double.TryParse(RADIE_OR_RADIEN, out Cirkel_User_Input_Save) && Cirkel_User_Input_Save == 1 || Cirkel_User_Input_Save == 2)
                {
                    if (Cirkel_User_Input_Save == 1)
                    {

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("vad har Cirkeln för Radie? ");
                            RadieInput = Console.ReadLine();

                            if (double.TryParse(RadieInput, out Radie))
                            {
                                double AreaRadie;

                                AreaRadie = (Radie * Radie) * Pi;

                                Console.WriteLine("Arean för Cirkeln är: " + AreaRadie);

                                Console.ReadLine();

                                break;

                            }
                            Console.Clear();

                            Console.WriteLine("Ogiltigt tal, Skriv in Cirkelns Radie.");


                            Console.Clear();
                        }
                    }



                    Console.WriteLine("Ogiltigt tal, Skriv in Cirkelns Radie.");
                }
                if (Cirkel_User_Input_Save == 2)
                {
                    Console.Clear();

                    Console.WriteLine("vad har Cirkeln för Radien? ");
                    RadienInput = Console.ReadLine();

                    while (true)
                    {
                        if (double.TryParse(RadienInput, out Radien))
                        {
                            double AreaRadien;

                            AreaRadien = Radien * Pi;

                            Console.WriteLine("Arean för Cirkeln är: " + AreaRadien);

                            Console.ReadLine();
                            break;

                        }
                    }


                    return;
                }
            }
        }
    }
}
