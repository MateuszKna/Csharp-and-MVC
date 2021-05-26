using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium6
{
    public class Gady: Zwierzeta
    {

        private string toksyczny;

        public Gady(string _gatunek, string _pozywienie, string _pochodzenie, string _toksyczny)
        : base(_gatunek, _pochodzenie, _pozywienie)
        {
            toksyczny = _toksyczny;
        }



        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Czy zwierze jest toksyczne: " + toksyczny + "\n");
        }

    }
}