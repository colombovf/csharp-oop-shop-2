using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Prodotto
    {
        protected int codice;
        protected string nome;
        protected string descrizione;
        protected double prezzo;
        protected double iva;


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

        protected int CalcolaCodice()
        {
            Random r = new Random();
            return r.Next(0, 9999999);
        }

        protected double CalcoloIva(double price)
        {
            return (price * 22) / 100;
        }
    }
}
