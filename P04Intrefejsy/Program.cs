using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Intrefejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();
            double w1 = k.WykonajOperacje(2,3,new MechanizmDodawania()); // wynik 5 
            double w2 = k.WykonajOperacje(2,3, new MechanizmOdejmowania()); // wynik -1 

            // zalety: 
            // 1) łatwy podział systemu na niezależne cześci (każdy programista pracuje na niezależnej klasie)
            // 2) jednoznaczność - każdy programista wie co ma robić 
            // 3) nie wszsytkie cześci systemu muszą być gotowe żeby całośc działała 
            // 4) DI (Dependency Injection) poznamy pózniej 
        }
    }
}
