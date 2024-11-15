using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Hydroplan : IUmiejacyLatac, IUmiejacyPlywac
    {
        public void Lec()
        {
            Console.WriteLine("Amfibia leci");
        }

        public void Plyn()
        {
            Console.WriteLine("Amfibia plynie");
        }
    }
}
