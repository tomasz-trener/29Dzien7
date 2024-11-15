using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUmiejacyJezdzic[] tablicaPojazdowUmiejacychJezdzic = new IUmiejacyJezdzic[]
            {
                new Samochod(),
                new Amfibia()
            };

            foreach (var p in tablicaPojazdowUmiejacychJezdzic)
            {
                p.Jedz(3);

                if (p is Samochod)
                    ((Samochod)p).Zatankuj();
            }

            IUmiejacyJezdzic s = new Samochod();


            Console.ReadKey();
        }
    }
}
