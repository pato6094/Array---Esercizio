using System.IO.Pipes;

namespace Array
{
    public class Citta
    {
        public int numerocittadinimax;
        public int i = 0;
        public static Cittadino[] cittadinos = new Cittadino[3];
        public Citta (int numerocittadinimax)
        {
            this.numerocittadinimax = numerocittadinimax;
            
           
        }

        public void AggiungiCittadino(Cittadino cittadini)
        {
            if (i < numerocittadinimax && i < cittadinos.Length)
            {
                cittadinos[i] = cittadini;
                i++;
            }

            else
            {
                System.Console.WriteLine("Numero max raggiunto");
            }           


        }
         



    }
}
