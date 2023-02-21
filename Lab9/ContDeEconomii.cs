using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class ContDeEconomii : ContBancar
    {
        public ContDeEconomii(string nume) : base(nume)
        {

        }
        private double soldCurent = 0;
        private const double rataDobanzii = 2.5;
        public double GetSoldCurent()
        {
            return soldCurent;
        }
        public double GetRataDobanzii()
        {
            return rataDobanzii;
        }
        public void AdaugareNumerar(double numerar)
        {
            soldCurent += numerar;
            soldCurent = soldCurent * (1 + rataDobanzii);
            Console.WriteLine($"Soldul actual este de {soldCurent} lei.");
        }
        public void RetragereNumerar(double numerar)
        {
            if (numerar <= soldCurent)
            {
                soldCurent -= numerar;
                Console.WriteLine($"Ati retras {numerar} lei iar soldul actual este de {soldCurent} lei.");
            }
            else
            {
                Console.WriteLine("Fonduri insuficiente!");
            }
        }
    }
}
