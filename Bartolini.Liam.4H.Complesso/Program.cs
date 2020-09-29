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
            string strChoice;

            Console.WriteLine("\r\nSeleziona l'operazione");
            Console.WriteLine("1.Somma\r\n2.Sottrazione\r\n3.Moltiplicazione\r\n4.Divisione");
            while(true)
            {
                strChoice = Console.ReadLine();
                if (strChoice == "1" || strChoice == "2" || strChoice == "3" || strChoice == "4")
                    break;
            }

            if (strChoice == "1")
            {
                zr.Somma(z1, z2);
                Console.WriteLine($"La somma dei due numeri è {zr.reale} + {zr.immaginaria}i");
            }
            if (strChoice == "2")
            {
                zr.Sottrazione(z1, z2);
                Console.WriteLine($"La sottrazione dei due numeri è {zr.reale} + {zr.immaginaria}i");
            }
            if (strChoice == "3")
            {
                zr.Prodotto(z1, z2);
                Console.WriteLine($"Il prodotto dei due numeri è {zr.reale} + {zr.immaginaria}i");
            }
            if (strChoice == "4")
            {
                zr.Rapporto(z1, z2);
                Console.WriteLine($"Il rapporto dei due numeri è: {zr.reale} + {zr.immaginaria}i");
            }

            Console.WriteLine("Inserisci il numero del quale vuoi calcolare valore assoluto e argomento: ");
            string strComplex = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (strComplex == "1")
            {
                zr.Assoluto(z1);
                zr.Fi(z1);
                
                Console.WriteLine($"numero scelto: {z1.reale} + {z1.immaginaria}i");
            }
            else
            {
                zr.Assoluto(z2);
                zr.Fi(z2);
                Console.WriteLine($"numero scelto: {z2.reale} + {z2.immaginaria}i");
            }
            Console.ResetColor();

            Console.WriteLine($"Il valore assoluto è |{zr.assoluto:n2}|");
            Console.WriteLine($"Il valore dell'argomento é phi = {zr.fi:n2}°");
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
            assoluto = c;
            fi = d;
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
