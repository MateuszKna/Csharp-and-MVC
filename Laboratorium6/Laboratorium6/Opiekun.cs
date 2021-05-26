using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium6
{
    public class Opiekun
    {
        private string imie;
        private string nazwisko;
        private string idd;

        public string Imie
        {
            get => imie;
            set => imie = value;
        }

        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = value;
        }

        public string Idd
        {
            get => idd;
            set => idd = value;
        }


        public Opiekun(string _idd, string _imie, string _nazwisko)
        {
            idd = _idd;
            imie = _imie;
            nazwisko = _nazwisko;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("Id opiekuna: " + idd + "\n" + "Imie opiekuna to: " + Imie + "\n" + "Nazwisko opiekuna to: "+ Nazwisko + "\n");
        }

    }
}