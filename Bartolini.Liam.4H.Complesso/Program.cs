using System;

namespace Bartolini.Liam._4H.Complesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classe complesso");

            Complesso z1 = new Complesso(4, 5, 0, 0);
            Complesso z2 = new Complesso(2, 1, 0, 0);
            Complesso zr = new Complesso();

            Console.WriteLine("\r\nSeleziona l'operazione");
            Console.WriteLine("1.Somma\r\n2.Sottrazione\r\n3.Moltiplicazione\r\n4.Divisione");
            string strChoice = Console.ReadLine();

            if (zr.immaginaria >= 0)
                Console.WriteLine($"Il risultato del calcolo è: {zr.reale} + {zr.immaginaria}i");
            else
                Console.WriteLine($"Il risultato del calcolo è: {zr.reale} {zr.immaginaria}i");

            zr.Assoluto(z1);
            Console.WriteLine($"Il valore assoluto di {z1.reale} + {z1.immaginaria}i è |{zr.assoluto:n2}|");
            zr.Fi(z1);
            Console.WriteLine($"Il valore dell'angolo φ di {z1.reale} + {z1.immaginaria}i = {zr.fi:n2}°");
        }
    }

    class Complesso
    {
        public double reale;
        public double immaginaria;
        public double assoluto;
        public double fi;

        public Complesso()
        {

        }

        public Complesso(double a, double b, double c, double d)
        {
            reale = a;
            immaginaria = b;
        }

        public void Fi(Complesso w1)
        {
            //calcolo l'arcotangente di un numero in radianti e lo converto in gradi
            fi = Math.Atan(w1.immaginaria / w1.reale) * (180 /Math.PI);
        }

        public void Assoluto(Complesso w1)
        {
            assoluto = Math.Sqrt(Math.Pow(w1.reale, 2)+ Math.Pow(w1.immaginaria, 2));
        }

        public void Somma(Complesso w1, Complesso w2)
        {
            reale = w1.reale + w2.reale;
            immaginaria = w1.immaginaria + w2.immaginaria;
        }

        public void Sottrazione(Complesso w1, Complesso w2)
        {
            reale = w1.reale - w2.reale;
            immaginaria = w1.immaginaria - w2.immaginaria;
        }

        public void Prodotto(Complesso w1, Complesso w2)
        {
            reale = (w1.reale * w2.immaginaria) - (w1.immaginaria * w2.immaginaria);
            immaginaria = (w1.immaginaria * w2.reale) + (w1.reale * w2.immaginaria);
        }

        public void Rapporto(Complesso w1, Complesso w2)
        {
            reale = (w1.reale * w2.reale + w1.immaginaria * w2.immaginaria) / (Math.Pow(w2.reale, 2) + Math.Pow(w2.immaginaria, 2));
            immaginaria = (w1.immaginaria * w2.reale - w1.reale * w2.immaginaria) / (Math.Pow(w2.reale, 2) + Math.Pow(w2.immaginaria, 2));
        }
    }
}