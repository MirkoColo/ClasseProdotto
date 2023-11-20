using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProdotto
{
    class Prodotto
    {
        protected string _nome;
        protected double _prezzo;
        public Prodotto(string nome, double prezzo) 
        { 
            _nome = nome;
            _prezzo = prezzo;
        }
        public Prodotto()
        {

            _nome = "Carne";
            _prezzo = 15;
        }

        public void Stampa()
        {
            Console.WriteLine($"Il nome del prodotto è: {_nome} e il suo prezzo è: {_prezzo}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Prodotto prod = new Prodotto("Farro", 10);
            prod.Stampa();
            Prodotto prod1 = new Prodotto();
            prod1.Stampa();
        }
    }
}
