using Pastel;
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
            int UserMainInput;

            while (true)
            {

                Color_And_Decleration.Color_Decleration();

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
                case 2:
                    Pythagoras.Pythagoras_sats();
                    break;
                case 3:
                    Cirkelns_Area_Omkrets.Cirkelns_AreaOmkrets();
                    break;
                case 4:
                    RektangelnsArea.Rektangelns_Area();
                    break;
                case 6:
                    Tid.tid();
                    break;
                case 7:
                    BarnsÅlderBallong.BarnsÅlder();
                    break;
                case 8:
                    JämtEllerUdda.JämtUdda();
                    break;
                case 10:
                    Trigonometrisk.TrigonometriskBeräkning();
                    break;
            }
        }
    }
}
