using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium6
{
    public class Dyrekcja
    {

        public Dyrekcja() { }

        private List<Opiekun> opiekun = new List<Opiekun>();
        private List<Klatka> klatka = new List<Klatka>();
        private List<Zwierzeta> zwierzeta = new List<Zwierzeta>();

        //Przetestowane
        public void InfoZwierzeta()
        {
            for (int i = 0; i < zwierzeta.Count; i++)
            {
                Zwierzeta z = zwierzeta[i];
                z.WypiszInfo();
               
            }
        }



        //Przetestowane
        public void DodajZwierze(Zwierzeta z)
        {

            zwierzeta.Add(z);

        }

        //Przetestowane
        public void InfoKlatka(string idk)
        {
            for (int i = 0; i < klatka.Count; i++)
            {
                Klatka k = klatka[i];
                if(k.Id == idk)
                {
                    k.WypiszInfo();
                }
            }
        }


        //Przetestowane
        public void InfoKlatkaAll()
        {
            for (int i = 0; i < klatka.Count; i++)
            {
                Klatka k = klatka[i];
                k.WypiszInfo();
            }
        }


        //Przetestowane
        public void InfoOpiekun(string ido)
        {
            for (int i = 0; i < opiekun.Count; i++)
            {
                Opiekun o = opiekun[i];
                if (o.Idd == ido)
                {
                    o.WypiszInfo();
                }
            }
        }


        //Przetestowane
        public void InfoOpiekunAll()
        {
            for (int i = 0; i < opiekun.Count; i++)
            {
                Opiekun o = opiekun[i];
                
                    o.WypiszInfo();
                
            }
        }

        //Przetestowane
        public void BudujKlatke(string idk, float pojemnosc, string czystosc)
        {
            Klatka k = new Klatka("", "", "", idk, pojemnosc, czystosc);
            klatka.Add(k);

        }

        public void NowaKlatka(Klatka k)
        {
            klatka.Add(k);
        }

        //Przetestowane
        public void PowiekszKlatke(string idk, float pojemnosc)
        {
            for (int i = 0; i < klatka.Count; i++)
            {
                Klatka k = klatka[i];
                if (k.Id == idk)
                {
                    k.Pojemnosc = pojemnosc;
                }
            }
        }

        //Przetestowane
        public void NowyPracownik(Opiekun o)
        {
            opiekun.Add(o);
        }



        //Przetestowane
        public void ZwolnijPracownika(string ido)
        {
            for (int i = 0; i < opiekun.Count; i++)
            {
                Opiekun o = opiekun[i];
                if (o.Idd == ido)
                {
                    opiekun.Remove(o);
                }
            }
        }

        //Przetestowane
        public void OpiekunDoKlatki(Opiekun o, string idk)
        {
            for (int i = 0; i < klatka.Count; i++)
            {
                Klatka k = klatka[i];
                if (k.Id == idk)
                {
                    k.Idd = o.Idd;
                    k.Imie = o.Imie;
                    k.Nazwisko = o.Nazwisko;
                }
            }
        }

        public void NoweZwierzeDoKlatki(Zwierzeta z, Klatka k)
        {

            DodajZwierze(z);
            k.WypiszInfo();
            z.WypiszInfo();
     
        }


        //Przetestowane
        public void CzyszczenieKlatki(string idk)
        {
            for (int i = 0; i < klatka.Count; i++)
            {
                Klatka k = klatka[i];
                if (k.Id == idk && k.Czystosc == "Brudna")
                {
                    k.Czystosc = "Czysta";
                }

            }
        }

    }
}