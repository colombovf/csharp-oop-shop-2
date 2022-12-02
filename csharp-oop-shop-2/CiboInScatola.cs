using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class CiboInScatola : Prodotto
    {
        // PROPRIETA / ATTRIBUTI
        private double nGrammi;
        private double maxGrammi;

        // STATO


        // COSTRUTTORI
        CiboInScatola(string name, string description, double price, double nGrammi) : base(name, description, price)
        {
            this.nGrammi= nGrammi;
            this.maxGrammi = 300; 
            if(nGrammi > maxGrammi)
            {
                nGrammi= maxGrammi;
            } else if(nGrammi<= 0) 
            {
                nGrammi = 1; //Creiamo una bottiglia con almeno 1 grammo di cibo
            }
        }

        // GETTERS
        public double getNGrammi()
        {
            return nGrammi;
        }

        public double getMaxGrammi()
        {
            return maxGrammi;
        }

        // SETTERS
        public bool setScatola(double grammi)
        {
            if(grammi > maxGrammi)
            {
                return false;
            } else if (grammi <= 0) 
            {
                return false;
            }
            return true;
        } 

        // METODI PUBBLICI
        public void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Numero di grammi " + nGrammi + "su " + maxGrammi);

        }

        // METODI PRIVATI
    }
}
