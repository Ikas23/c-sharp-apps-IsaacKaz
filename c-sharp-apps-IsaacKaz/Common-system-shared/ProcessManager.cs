using c_sharp_apps_IsaacKaz.bank_app;
using c_sharp_apps_IsaacKaz.draft_app;
using c_sharp_apps_IsaacKaz.sport_app;
using c_sharp_apps_IsaacKaz.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.Common_system_shared
{
    internal class ProcessManager
    {
        public static void MethodeCall()
        {
            Console.WriteLine("Choose one options 1 – Bank App 2 – Sport App 3 – Transportation App 4 – Draft App 0- Exit");
            int choose = int.Parse(Console.ReadLine());
            while (choose != 0)
            {
              
                switch (choose)
                {
                    case 1:
                        BankAppMain.MainEntry();
                        break;
                    case 2:
                        SportAppMain.MainEntry();

                        break;
                    case 3:
                        TransportationAppMain.MainEntry();

                        break;
                    case 4:
                        DraftAppMain.MainEntry();

                        break;
                    case 0:
                        break;

                }
                Console.WriteLine("Choose one options 1 – Bank App 2 – Sport App 3 – Transportation App 4 – Draft App 0- Exit");
                choose = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("End");
        }
    }
}
