﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class SacchettoDiFrutta : Prodotto
    {
        // PROPRIETA / ATTRIBUTI
        double maxPezzi;
        double nPezzi;

        // STATO


        // COSTRUTTORI
        SacchettoDiFrutta(string name, string description, double price, double nPezzi) : base( name, description, price) 
        {
            this.nPezzi = nPezzi;
            this.maxPezzi = 5;
        }
        
        // GETTERS
        
        
        // SETTERS
        
        
        // METODI PUBBLICI
        
        
        // METODI PRIVATI
    }
}
