using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Zawodnicy.Shared.Domains
{
    public class Osoba : IComparable<Osoba>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public DateTime DataUrodzenia { get; set; }

        public int CompareTo(Osoba inna)
        {
            int pora1 = PoraRoku(this.DataUrodzenia);
            int pora2 = PoraRoku(inna.DataUrodzenia);
            return pora1.CompareTo(pora2);
        }

        private int PoraRoku(DateTime data)
        {
            if (data.Month >= 3 && data.Month <= 5) return 1; // wiosna
            if (data.Month >= 6 && data.Month <= 8) return 2; // Lato
            if (data.Month >= 9 && data.Month <= 11) return 3; // jesien
            return 4;// zima
        }
    }
}
