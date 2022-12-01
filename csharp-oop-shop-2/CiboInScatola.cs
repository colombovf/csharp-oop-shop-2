using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        // GETTERS


        // SETTERS


        // METODI PUBBLICI


        // METODI PRIVATI
    }
}
