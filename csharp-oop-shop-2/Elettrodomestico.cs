using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_oop_shop_2
{
    public class Elettrodomestico : Prodotto
    {
        // PROPRIETA / ATTRIBUTI


        // STATO
        private bool acceso;

        // COSTRUTTORE
        Elettrodomestico(string name, string description, double price, bool acceso) : base(name, description, price)
        {
            this.acceso = false;
        }

        // GETTERS
        public void getAcceso()
        {
            if (acceso = false)
            {
                Console.WriteLine("L'elettrodomestico è spento");
            }
            else
            {
                Console.WriteLine("L'elettrodomestico è acceso");
            }
        }

        // SETTERS
        public bool setAccensione()
        {
            if (acceso = false)
            {
                Console.WriteLine("L'elettrodomestico è acceso");
                return acceso = true;
            }
            else
            {
                Console.WriteLine("L'elettrodomestico è spento");
                return acceso = false;
            }
        }

            // METODI PUBBLICI
            public void Stampa()
            {
                base.Stampa();
            }

            // METODI PRIVATI
        }
    } 
}
