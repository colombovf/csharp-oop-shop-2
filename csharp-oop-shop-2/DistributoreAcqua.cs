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
        private double maxlitri;

        // STATO


        // COSTRUTTORI
        DistributoreAcqua (string name, string description, double price, double litri) : base(name, description, price)
        {
            this.litri = litri;
            this.maxlitri = 1.5;
        }

        // GETTERS


        // SETTERS


        // METODI PUBBLICI


        // METODI PRIVATI
    }
}
