using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium6
{
    public class Klatka : Opiekun
    {


        private string id;
        private float pojemnosc;
        private string czystosc;

        public string Id
        {
            get => id;
            set => id = value;
        }

        public float Pojemnosc
        {
            get => pojemnosc;
            set => pojemnosc = value;
        }

        public string Czystosc
        {
            get => czystosc;
            set => czystosc = value;
        }

        private List<Zwierzeta> zwierzeta = new List<Zwierzeta>();
        private List<Opiekun> opiekun = new List<Opiekun>();
 

        public Klatka(string _i, string _im, string _naz, string _id, float _pojemnosc, string _czystosc)
            :base(_i, _im, _naz)
        {
            id = _id;
            pojemnosc = _pojemnosc;
            czystosc = _czystosc;
        }



        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Id klatki to: " + id + "\n" + "Pojemnosc klatki to: " + pojemnosc + "\n" + "Czy do posprzątania? " + czystosc + "\n" );
           
        }

    }
}