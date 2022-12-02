using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class SacchettoDiFrutta : Prodotto
    {
        // PROPRIETA / ATTRIBUTI
        private int maxPezzi;
        private int nPezzi;

        // STATO


        // COSTRUTTORI
        SacchettoDiFrutta(string name, string description, double price, int nPezzi) : base( name, description, price) 
        {
            this.nPezzi = nPezzi;
            this.maxPezzi = 5;
            if (nPezzi > maxPezzi) {
                nPezzi = maxPezzi;
            }
            if (nPezzi <= 0)
            {
                nPezzi = 1; //Creiamo un sacchetto con almeno un pezzo di frutta
            }
        }
        
        // GETTERS
        public int getNPezzi()
        {
            return nPezzi;
        }

        public double getMaxPezzi() 
        {
            return maxPezzi;
        }
        
        // SETTERS
        public bool setNPezzi(int pezzi)
        {
            if (pezzi > maxPezzi) {
                return false;
            } else if (pezzi <= 0)
            {
                return false;  
            }
            nPezzi = pezzi;
            return true;
        }
        
        // METODI PUBBLICI
        public void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Numero di pezzi di frutta " + nPezzi + "su " + maxPezzi);

        }
        
        // METODI PRIVATI
    }
}
