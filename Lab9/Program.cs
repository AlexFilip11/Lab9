using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele contului dvs.");
            string nume = Console.ReadLine();
            ContBancar contulBancar = new ContBancar(nume);
            ContCurent contCurent = new ContCurent(nume);
            ContDeEconomii contEconomii = new ContDeEconomii(nume);
            ContDeInvestitii contInvestitii = new ContDeInvestitii(nume);
            AccesareConturi(nume, contCurent, contEconomii, contInvestitii);
        }

        static void AccesareConturi(string nume, ContCurent contCurent, ContDeEconomii contEconomii, ContDeInvestitii contInvestitii)
        {
            bool rulare = true;
            while (rulare == true)
            {
                Console.WriteLine("Ce cont doriti sa accesati?");
                Console.WriteLine("Apasati 1 pentru cont curent, 2 pentru cont de economii, 3 pentru cont de investitii");
                int alegere = int.Parse(Console.ReadLine());
                if (alegere == 1)
                {
                    Console.WriteLine("Doriti sa afisati soldul curent(1), sa adaugati numerar(2) sau sa retrageti numerar(3)");
                    alegere = int.Parse(Console.ReadLine());
                    if (alegere == 1)
                    {
                        Console.WriteLine($"Soldul dvs, curent este de {contCurent.GetSoldCurent()} lei");
                    }
                    else if (alegere == 2)
                    {
                        Console.WriteLine("Adaugati numerar: ");
                        contCurent.AdaugareNumerar(double.Parse(Console.ReadLine()));
                    }
                    else if (alegere == 3)
                    {
                        Console.WriteLine("Introduceti suma pe care doriti sa o retrageti: ");
                        contCurent.RetragereNumerar(double.Parse(Console.ReadLine()));
                    }
                    else { Console.WriteLine("Optiune inexistenta!"); }
                }
                else if (alegere == 2)
                {
                    Console.WriteLine("Doriti sa afisati soldul contului de economii(1), sa adaugati numerar(2) sau sa retrageti numerar(3)");
                    alegere = int.Parse(Console.ReadLine());
                    if (alegere == 1)
                    {
                        Console.WriteLine($"Soldul dvs, curent este de {contEconomii.GetSoldCurent()} lei");
                    }
                    else if (alegere == 2)
                    {
                        Console.WriteLine("Adaugati numerar: ");
                        contEconomii.AdaugareNumerar(double.Parse(Console.ReadLine()));
                    }
                    else if (alegere == 3)
                    {
                        Console.WriteLine("Introduceti suma pe care doriti sa o retrageti: ");
                        contEconomii.RetragereNumerar(double.Parse(Console.ReadLine()));
                    }
                    else { Console.WriteLine("Optiune inexistenta!"); }
                }
                else if (alegere == 3)
                {
                    Console.WriteLine("Doriti sa afisati soldul contului de investitii(1), sa adaugati numerar(2) sau sa retrageti numerar(3)");
                    alegere = int.Parse(Console.ReadLine());
                    if (alegere == 1)
                    {
                        Console.WriteLine($"Soldul dvs, curent este de {contInvestitii.GetSoldCurent()} lei");
                    }
                    else if (alegere == 2)
                    {
                        Console.WriteLine("Adaugati numerar: ");
                        contInvestitii.AdaugareNumerar(double.Parse(Console.ReadLine()));
                    }
                    else if (alegere == 3)
                    {
                        Console.WriteLine("Introduceti suma pe care doriti sa o retrageti: ");
                        contInvestitii.RetragereNumerar(double.Parse(Console.ReadLine()));
                    }
                    else { Console.WriteLine("Optiune inexistenta!"); }
                }
                else { Console.WriteLine("Optiune inexistenta!"); }
                Console.WriteLine("Doriti sa efectuati alta operatiuni? Da(1)/Nu(2)");
                alegere = int.Parse(Console.ReadLine());
                if(alegere==1)
                { rulare = true; }
                else { rulare = false; }
            }
        }
    }
}

