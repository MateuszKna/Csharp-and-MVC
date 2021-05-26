using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium6
{
    public class Zwierzeta 
    {
        protected string idz;
        protected string gatunek;
        protected string pozywienie;
        protected string pochodzenie;

        public string Idz
        {
            get => idz;
        }

        public string Gatunek
        {
            get => gatunek;
        }

        public string Pozywienie
        {
            get => pozywienie;
        }

        public string Pochodzenie
        {
            get => pochodzenie;
        }


        public Zwierzeta(string _gatunek, string _pozywienie, string _pochodzenie)
        {
            gatunek = _gatunek;
            pozywienie = _pozywienie;
            pochodzenie = _pochodzenie;
        }

       


        public virtual void WypiszInfo()
        {
            Console.WriteLine("Gatunek zwierzecia to: " + gatunek + "\n" + "Pozywienie zwierzecia to: " + pozywienie + "\n" + "Pochodzenie zwierzecia to: " + pochodzenie);
        }
    }
}