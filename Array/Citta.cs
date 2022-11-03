using System.Globalization;
using System;
using System.IO.Pipes;

namespace Array
{
    public class Citta
    {

        public string nome;
        public int numerocittadinimax;
        public int i = 0;
        public static Cittadino[] cittadinos = new Cittadino[3];
        public Citta(string nome,int numerocittadinimax)
        {
            this.nome = nome;
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

        public void DDA(Cittadino cittadino)
        {
            string[] dataformats = new string[] { "dd/MM/yyyy" };
            CultureInfo culterinfo = new CultureInfo("it");
            Console.WriteLine("Inserire una data: ");
            string input = Console.ReadLine();
            DateTime result;
            DateTime.TryParseExact(input, dataformats, culterinfo, DateTimeStyles.AdjustToUniversal, out result);

            DateTime oggi = DateTime.Now;
            int x = oggi.Year - result.Year;

            if (x >= 18)
            {
                Console.WriteLine("E' maggiorenne,SI puo iscrivere al comune");
            }
            else
            {
                Console.WriteLine("Non si puo iscrivere al comune, NON e' maggiorenne ");
            }

        }
    }
}
