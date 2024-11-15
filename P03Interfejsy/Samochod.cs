using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Samochod : IUmiejacyJezdzic
    {
        public string Jedz(int ile)
        {
            Console.WriteLine("Samochod jedzie");
            return "ok";
        }

        public void ZatrzymajSie()
        {
            throw new NotImplementedException();
        }

        public void Zatankuj()
        {

        }
    }
}
