using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;


        //Costruttori di default
        public Prodotto() { }

        //Costruttori con parametri
        public Prodotto(string name, string description, double price)
        {
            this.codice = CalcolaCodice();
            this.nome = name;
            this.descrizione = description;
            this.prezzo = price;
            this.iva = CalcoloIva(prezzo);
        }


        //Getter
        public int getCodice()
        {
            return codice;
        }

        public string getNome()
        {
            return nome;
        }

        public string getDescrizione()
        {
            return descrizione;
        }

        public double getPrezzoSenzaIva()
        {
            return prezzo - iva;
        }

        public double getPrezzoConIva()
        {
            return prezzo;
        }

        public double getIva()
        {
            return iva;
        }



        //Setter
        public void setNome(string name)
        {
            nome = name;
        }

        public void setDescrizione(string description)
        {
            descrizione = description;
        }

        public void setPrezzo(double price)
        {
            this.prezzo = price;
            iva = CalcoloIva(price);
        }

        //Metodi

        private int CalcolaCodice()
        {
            Random r = new Random();
            return r.Next(0, 9999999);
        }

        private double CalcoloIva(double price)
        {
            return (price * 22) / 100;
        }

        public void Stampa()
        {
            Console.WriteLine(codice + " " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine("Prezzo: " + prezzo);
            Console.WriteLine("Prezzo senza IVA: " + (prezzo - iva));
        }


    }
}