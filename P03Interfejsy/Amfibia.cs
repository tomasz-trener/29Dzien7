using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Amfibia : IUmiejacyJezdzic, IUmiejacyPlywac
    {
        public string Jedz(int ile)
        {
            Console.WriteLine("amfibia jezdie");
            return "ok";
        }

        public void Plyn()
        {
            Console.WriteLine("amfibia plynie");
        }

        public void ZatrzymajSie()
        {
            throw new NotImplementedException();
        }
    }
}
