using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Laboratorium6
{
    public class Ptaki: Zwierzeta
    {
        private float rozpietosc;
        private float wytrzymalosc;

        public Ptaki(string _gatunek, string _pozywienie, string _pochodzenie, float _rozpietosc, float _wytrzymalosc)
       : base(_gatunek, _pochodzenie, _pozywienie)
        {
            rozpietosc = _rozpietosc;
            wytrzymalosc = _wytrzymalosc;
        }



        public float Dlugosc_lotu()
        {
            return rozpietosc * wytrzymalosc;
            
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rozpietosc skrzydel tego ptaka wynosi: " + rozpietosc + "\n" + "Zasieg lotu ptaka wynosi: " + Dlugosc_lotu() + " km" + "\n" );
        }
    }
}