using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium6
{
    public class Ssaki:Zwierzeta
    {
        private string srodowisko;


        public Ssaki(string _gatunek, string _pozywienie, string _pochodzenie,  string _srodowisko)
        : base(_gatunek, _pochodzenie, _pozywienie)
        {
            srodowisko = _srodowisko;
        }

        private List<Zwierzeta> zwierzeta = new List<Zwierzeta>();



        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Srodowisko tego zwierzecia to: " + srodowisko + "\n");

        }
    }
}