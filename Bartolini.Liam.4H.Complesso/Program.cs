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

            Console.WriteLine("\r\nSeleziona l'operazione");
            Console.WriteLine("1.Somma\r\n2.Sottrazione\r\n3.Moltiplicazione\r\n4.Divisione");
            string strChoice = Console.ReadLine();

            if(strChoice == "1")
            {
                zr.Somma(z1, z2);
                Console.WriteLine($"La somma dei due numeri è {zr.reale} + {zr.immaginaria}i");
            }
            if(strChoice == "2")
            {
                zr.Sottrazione(z1, z2);
                Console.WriteLine($"La sottrazione dei due numeri è {zr.reale} + {zr.immaginaria}i");
            }
            if(strChoice == "3")
            {
                zr.Prodotto(z1, z2);
                Console.WriteLine($"Il prodotto dei due numeri è {zr.reale} + {zr.immaginaria}i");
            }
            if(strChoice == "4")
            {
                zr.Rapporto(z1, z2);
                Console.WriteLine($"Il rapporto dei due numeri è: {zr.reale} + {zr.immaginaria}i");
            }
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