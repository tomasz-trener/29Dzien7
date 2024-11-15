using P04Zawodnicy.Shared.Domains;
using P04Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08ZadanieFiltorwanieDanych
{
    public partial class FrmWyszuiwarka : Form
    {
        IManagerZawodnikow mz;
        public FrmWyszuiwarka(IManagerZawodnikow mz)
        {
            InitializeComponent();
            this.mz = mz;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            List<Osoba> wynik = mz.WyszukajOsoby(txtSzukaj.Text);

            genernujKontrolkiDlaOsob(wynik);
        }

        private void genernujKontrolkiDlaOsob(List<Osoba> wynik)
        {
            pnlOsoby.Controls.Clear();

            int yOffest = 0;
            foreach (Osoba osoba in wynik)
            {
                Label lblImie = new Label()
                {
                    Text = $"Imie: {osoba.Imie}",
                    Location = new Point(10, yOffest)
                };
                pnlOsoby.Controls.Add(lblImie);

                Label lblNazwisko = new Label()
                {
                    Text = $"Nazwisko: {osoba.Nazwisko}",
                    Location = new Point(10, yOffest + 30),
                    Width = 200
                };
                pnlOsoby.Controls.Add(lblNazwisko);

                yOffest += 70;
            }
        }
    }
}
