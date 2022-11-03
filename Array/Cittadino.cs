using System.Globalization;
using System;

namespace Array
{
    public class Cittadino
    {
        public string nome;
        public string cognome;
        public Citta citta;
        public Citta datanascita;

        public Cittadino(string nome, string cognome, Citta citta,Citta datanascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            citta.AggiungiCittadino(this);
            citta.DDA(this);
            
        }

        



    }
}
