namespace Array
{
    public class Cittadino
    {
        public string nome;
        public string cognome;
        public Citta citta;

        public Cittadino(string nome, string cognome, Citta citta)
        {
            this.nome = nome;
            this.cognome = cognome;
            citta.AggiungiCittadino(this);

            
        }

        

    }
}
