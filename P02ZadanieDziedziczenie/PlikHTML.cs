using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class PlikHTML : Raport
    {
        public PlikHTML()
        {
            rozszerzenie = ".html";
        }

        const string szablon = @"<html>
                                <body>
                                <p>{0}</p>
                                </body>
                                </html>";

        public override void Zapisz()
        {
            Zawartosc = string.Format(szablon, Zawartosc);
            //File.WriteAllText(Sciezka + "\\" + Nazwa + rozszerzenie, Zawartosc);
            base.Zapisz();
        }
    }
}
