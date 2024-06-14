using c_sharp_apps_IsaacKaz.bank_app;
using c_sharp_apps_IsaacKaz.Common_system_shared;
using c_sharp_apps_IsaacKaz.draft_app;
using c_sharp_apps_IsaacKaz.sport_app;
using c_sharp_apps_IsaacKaz.transportation_app;
namespace c_sharp_apps_IsaacKaz.object_basic;

//ProcessManager.MethodeCall();

public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1 – Bank App | 2 – Sport App | 3 – Transportation App | 4 – Draft App | 0- Exit");
        int num = int.Parse(Console.ReadLine());
        while (num != 0)
        {

            switch (num)
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
                    Console.WriteLine("Exit");
                    break;


            }
            num = int.Parse(Console.ReadLine());
        }


    }
    
    
}



