
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Beräknare_V1._0
{
    class BarnsÅlderBallong
    {
        public static void BarnsÅlder()
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
           `.");
                Console.ReadLine();
            }
            else if (Ålder < 17 && Ålder > 11)
            {
                Console.WriteLine("Här så får du en glass!");
                Console.WriteLine(@"       ()
      (__)
     (____)
    (______)
   (________)
  (__________)
   \/\/\/\/\/
    \/\/\/\/
     \/\/\/
      \/\/
       \/
");
                Console.ReadLine();
            }
        }
    }
}
