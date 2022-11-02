using System;
using System.Security.Cryptography;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Citta c1 = new Citta(5);
            Cittadino cc = new Cittadino("mario", "rossi", c1);
            Cittadino cc1 = new Cittadino("ernesto", "rossi", c1);
            Cittadino cc3 = new Cittadino("alessia", "rossi", c1);
            Cittadino cc4 = new Cittadino("melia", "rossi", c1);


            for (int i = 0; i <Citta.cittadinos.Length; i++)
            {
                if (Citta.cittadinos[i] != null)
                {
                    Console.WriteLine(Citta.cittadinos[i].nome);
                }
            }
        }
    }
}
