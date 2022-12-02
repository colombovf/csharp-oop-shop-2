using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class DistributoreAcqua : Prodotto
    {
        // PROPRIETA / ATTRIBUTI
        private double litri;
        private double maxLitri;

        // STATO


        // COSTRUTTORI
        DistributoreAcqua(string name, string description, double price, double litri) : base(name, description, price)
        {
            this.litri = litri;
            this.maxLitri = 1.5;
        }

        // GETTERS
        public double getLitri()
        {
            return litri;
        }


        public double getMaxLitri()
        {
            return maxLitri;
        }

        // SETTERS

        // METODI PUBBLICI
        public void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Numero di litri " + litri + "su " + maxLitri);

        }

        public double RiempiRandom()
        {
            Random r = new Random();
            if (litri >= 1.5)
            {
                Console.WriteLine("Ci dispiace ma la bottiglia è piena");
                return litri = maxLitri;
            }
            else if (litri == 0 && litri < 1.5)
            {
                Console.WriteLine("La bottiglia è stato riempita al massimo");
                return litri += r.NextDouble();
            }
            else
            {
                return litri = litri;
            }
        }

        public double RiempiMax(double litriDaVersare)
        {
            if (litri >= 1.5)
            {
                Console.WriteLine("Ci dispiace ma la bottiglia è piena");
                return litri = maxLitri;
            }
            else if (litri == 0 && litri < 1.5)
            {
                Console.WriteLine("La bottiglia è stato riempita al massimo");
                return litri = maxLitri;
            }
            else
            {
                return litri = litri;
            }
        }

        public double Riempi05()
        {
            if (litri >= 1.5)
            {
                Console.WriteLine("Ci dispiace ma la bottiglia è pieno");
                return litri = maxLitri;
            }
            else if (litri == 0 && litri < 1.5)
            {
                Console.WriteLine("Il distributore è stato riempito di 0,5 litri");
                return litri += 0.5;
            }
            else
            {
                return litri = litri;
            }
        }

        public double Bevi(double litriDaBere)
        {
            if (litri >= 0 && litri <= 1.5)
            {
                if (litriDaBere > 0 && litriDaBere <= 1.5)
                {
                    Console.WriteLine("Hai bevuto " + litriDaBere + " litri");
                    return litri -= litriDaBere;
                }
                else if (litriDaBere > 1.5)
                {
                    Console.WriteLine("Hai bevuto la massima quantità di acqua disponibile");
                    return litri - maxLitri;
                }
                else
                {
                    Console.WriteLine("Non hai bevuto niente");
                    return litri = litri;
                }
            }
            else
            {
                return litri = litri;
            }
        }
    }
}

        // METODI PRIVATI

