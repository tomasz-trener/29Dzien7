﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    //c# acess modifiers 
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

    // słowo abstract okresla, że nie możemy tworzyć nowej instancji  danej klasy 
    // robimy to dla klas , które są szablonem dla innych klas 
    internal abstract class Raport
    {
        public string Zawartosc { get; set; }
        public int Rozmiar {  get; set; }
        public string Autor {  get; set; }

        public string Sciezka { get; set; }

        public string Nazwa {  get; set; }

        private protected string rozszerzenie { get; set; }

        public virtual void Zapisz()
        {
            Console.WriteLine("Zapisuję..");
            File.WriteAllText(Sciezka + "\\" + Nazwa + rozszerzenie, Zawartosc);
        }
    }
}
