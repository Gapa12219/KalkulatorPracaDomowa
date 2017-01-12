using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Dzielenie : Działania
    {
        public override void Działanie()
        {
            throw new NotImplementedException();
        }
        public virtual void dzielenie()
        {
            do
            {
                try
            {
                    Console.WriteLine("Wprowadzenie liczby 0 spowoduje zakonczenie działania\n");
                    Console.WriteLine("Podaj x:");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj y:");
                    y = double.Parse(Console.ReadLine());
                    wynik = x / y;
                    Console.WriteLine("{0} / {1} = {2}", x, y, wynik);
                
            }
            catch
            {
                Console.WriteLine("Podana litera nie jest cyfrą\n");
                    if (y == 0)
                    {
                        Console.WriteLine("Nie mozna dzielic przez zero\n");
                    }
                }
            
            } while (x != 0);
        }
       
    }
}
