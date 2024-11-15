using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programista p = new Programista();
            p.Imie = "Jan";
            p.Nazwisko = "Kowaslki";
            p.TypKomputera = "Laptop";
            p.Programuj();

            var z = new Zawodnik();
            z.Imie = "Adam";
            z.Nazwisko = "Nowak";
            z.NrNarty = 43;
            z.Skocz();

            Czlowiek c1 = new Czlowiek();

            Czlowiek c2 = new Zawodnik(); // rzutowanie niejawne bo zawsze typ bardziej szczegółowy możemy rzutować na bardziej ogólny 
            Czlowiek c2b = (Czlowiek)new Zawodnik(); // tak nie muszę robić 

            c2.Imie = "Jan"; 
            ((Zawodnik)c2).Skocz(); // na czas wywolania metody "skocz" traktuję c2 jako zawodnika 
            ((Zawodnik)c2).NrNarty = 50;


            Zawodnik c3 = (Zawodnik)c2; // musze rzutować jawnie poniewa  typ bardziej ogolny rzutuje na bardziej szczegolowy 
            Console.WriteLine(c3.NrNarty); // 50


            List<Zawodnik> tylkoZawodnicy = new List<Zawodnik>();
            List<Programista> tylkoProgramisci = new List<Programista>();

            List<Czlowiek> osoby = new List<Czlowiek>();
            osoby.Add(c2);
            osoby.Add(z);
            osoby.Add(p);

            foreach (var o in osoby)
            {
                //Console.WriteLine(o.Imie + " " + o.Nazwisko + " " + ((Zawodnik)o).NrNarty);
                if (o is Zawodnik)
                    Console.WriteLine(o.Imie + " " + o.Nazwisko + " " + ((Zawodnik)o).NrNarty);
                else if (o is Programista)
                    Console.WriteLine(o.Imie + " " + o.Nazwisko + " " + ((Programista)o).TypKomputera);
            }



        }
    }
}
