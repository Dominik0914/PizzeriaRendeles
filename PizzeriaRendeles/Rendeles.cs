using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaRendeles
{
    public class Rendeles
    {
        public string VevoNev { get; set; }
        public int PizzaSzama { get; set; }
        public int TavolsagKm { get; set; }

    public Rendeles(string sor)
        {
            string[] var = sor.Split(";");
            VevoNev = var[0];
            PizzaSzama = int.Parse(var[1]);
            TavolsagKm = int.Parse(var[2]);
        }
        public int FizetendoDij()
        {
            return PizzaSzama * 2500 + TavolsagKm * 300;
        }
        public override string ToString()
        {
            return $"{VevoNev}: {PizzaSzama} db pizza, {TavolsagKm} km - Fizetendő: {FizetendoDij()} Ft";
        }
    }
}
