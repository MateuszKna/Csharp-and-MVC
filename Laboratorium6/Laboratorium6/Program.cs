using System;

namespace Laboratorium6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w zoo Maciejos");
            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");


            Dyrekcja d1 = new Dyrekcja();
            Gady g1 = new Gady("Żółw wężoszyi", "ryby", "Australia", "Nie");
            Ssaki s1 = new Ssaki("Jenot Azjatycki", "Azja", "mieso", "lesne");
            Ptaki p1 = new Ptaki("Kakadu Palmowa", "Oceania", "owady", 100, 25);
         
            d1.DodajZwierze(g1);
            d1.DodajZwierze(s1);
            d1.DodajZwierze(p1);
            Console.WriteLine("Zwierzeta posiadane w zoo: " + "\n");
            d1.InfoZwierzeta();


            Opiekun o1 = new Opiekun("1", "Janusz", "Niwrok");
            Opiekun o2 = new Opiekun("2", "Dorota", "NamleW");
            Opiekun o3 = new Opiekun("3", "Wojtek", "Kaszana");

            d1.NowyPracownik(o1);
            d1.NowyPracownik(o2);
            d1.NowyPracownik(o3);


            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");
            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");
            Console.WriteLine("Wszyscy pracownicy z zoo: " + "\n");
            d1.InfoOpiekunAll();
            Console.WriteLine("Pracownik z wybranym id 1: " + "\n");
            d1.InfoOpiekun("1");
            d1.ZwolnijPracownika("3");
            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");
            d1.InfoOpiekunAll();

            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");
            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");

            

            d1.BudujKlatke("1", 50, "Czysta");

            d1.BudujKlatke("2", 50, "Brudna");

            d1.BudujKlatke("3", 400, "Czysta");

            Klatka k1 = new Klatka("", "", "", "4", 200, "Czysto");

            d1.NowaKlatka(k1);

            Console.WriteLine("Klatki w zoo: " + "\n");
            d1.InfoKlatkaAll();

            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");

            
            d1.PowiekszKlatke("2", 100);
            d1.CzyszczenieKlatki("2");

            
            d1.OpiekunDoKlatki(o2, "2");

            Console.WriteLine("Klatka o numerze id 2: " + "\n");
            d1.InfoKlatka("2");

            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");
            Console.WriteLine("_/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\__/*\\_" + "\n");
            d1.NoweZwierzeDoKlatki(s1, k1);






        }
    }
}
