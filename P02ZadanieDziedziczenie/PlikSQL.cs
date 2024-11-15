using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class PlikSQL : Raport
    {
        public PlikSQL()
        {
            rozszerzenie = ".sql";
        }

        public override void Zapisz()
        {
            Zawartosc = $"SELECT {Zawartosc} from Dane";
            //File.WriteAllText(Sciezka + "\\" + Nazwa + rozszerzenie, Zawartosc);
            base.Zapisz();
        }
    }
}
