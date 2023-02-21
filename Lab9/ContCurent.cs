using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class ContCurent : ContBancar
    {
        private double soldCurent = 0;
        public ContCurent(string nume) : base(nume)
        {

        }
        public double GetSoldCurent()
        {
            return soldCurent;
        }
        public void AdaugareNumerar(double numerar)
        {
            soldCurent += numerar;
            Console.WriteLine($"Soldul actual este de {soldCurent} lei.");
        }
        public void RetragereNumerar(double numerar)
        {
            if(numerar<=soldCurent)
            {
                soldCurent -= numerar;
                Console.WriteLine($"Ati retras {numerar} lei iar soldul actual este de {soldCurent} lei.");
            }
            else if(numerar<= (soldCurent+5000))
            {
                soldCurent -= numerar;
                Console.WriteLine($"Ati retras {numerar} lei iar contul dvs. este descoperit cu {-1*soldCurent} lei.");
            }
            else
            {
                Console.WriteLine("Fonduri insuficiente!");
            }
        }
    }
}
