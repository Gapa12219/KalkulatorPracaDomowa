using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dodawanie dodawanie = new Dodawanie();
             dodawanie.działanie();
             Odejmowanie odej = new Odejmowanie();
             odej.odejmowanie();
             Mnozenie mnozenie = new Mnozenie();
             mnozenie.mnozenie();
             Dzielenie dziel = new Dzielenie();
             dziel.dzielenie();*/
            poczatek:
            Console.WriteLine("[1] - Dodawanie");
            Console.WriteLine("[2] - Odejmowanie");
            Console.WriteLine("[3] - Mnozenie");
            Console.WriteLine("[4] - Dzielenie");
            
            int liczba = int.Parse(Console.ReadLine());

            switch (liczba)
            {
                case 1:
                    Dodawanie dodawanie = new Dodawanie();
                    dodawanie.działanie();
                    goto poczatek;
                case 2:
                    Odejmowanie odej = new Odejmowanie();
                    odej.odejmowanie();
                    goto poczatek;
                case 3:
                    Mnozenie mnozenie = new Mnozenie();
                    mnozenie.mnozenie();
                    goto poczatek;
                case 4:
                    Dzielenie dziel = new Dzielenie();
                    dziel.dzielenie();
                    goto poczatek;
               


                default:
                    Console.WriteLine("Wybrana przez Ciebie liczba nie jest prawidlowa");
                    goto poczatek;


            }





        }
    }
}


