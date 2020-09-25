using System;

namespace Bartolini.Liam._4H.Complesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classe complesso");

            Complesso z1 = new Complesso(3, 5);
            Complesso z2 = new Complesso(2, 4);
            Complesso zr = new Complesso();
            string strChoice;

            Console.WriteLine("Seleziona l'operazione");
            Console.WriteLine("1.Somma\r\n2.Sottrazione\r\n3.Moltiplicazione\r\n4.Divisione");
            while(true)
            {
                strChoice = Console.ReadLine();
                if (strChoice == "1" || strChoice == "2" || strChoice == "3" || strChoice == "4")
                    break;
            }

            if(zr.immaginaria >= 0)
                Console.WriteLine($"Il risultato della {strChoice} è: {zr.reale}+{zr.immaginaria}i");
            else
                Console.WriteLine($"Il risultato della {strChoice} è: {zr.reale}{zr.immaginaria}i");
        }
    }

    class Complesso
    {
        public double reale;
        public double immaginaria;

        public Complesso()
        {

        }

        public Complesso(double a, double b)
        {
            reale = a;
            immaginaria = b;
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