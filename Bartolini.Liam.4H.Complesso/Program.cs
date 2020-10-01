using System;

namespace Bartolini.Liam._4H.Complesso
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bartolini Liam, Complesso2");
            Complesso z1 = new Complesso(4, 5, 0, 0);
            Complesso z2 = new Complesso(2, 1, 0, 0);
            Complesso zr = new Complesso();
            string strChoice;

            Console.WriteLine("\r\nSeleziona l'operazione");
            Console.WriteLine("1.Somma\r\n2.Sottrazione\r\n3.Moltiplicazione\r\n4.Divisione");
            while (true)
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
                zr.Phi(z1);

                Console.WriteLine($"numero scelto: {z1.reale} + {z1.immaginaria}i");
            }
            else
            {
                zr.Assoluto(z2);
                zr.Phi(z2);
                Console.WriteLine($"numero scelto: {z2.reale} + {z2.immaginaria}i");
            }
            Console.ResetColor();

            Console.WriteLine($"Il valore assoluto è |{zr.modulo:n2}|");
            Console.WriteLine($"Il valore dell'argomento é phi = {zr.fase:n2}°");

            //_____________________________________________________
            //richiedo e splitto il modulo e la fase, faccio i calcoli per convertirli e li passo all'oggetto
            Console.WriteLine("Inserisci modulo e fase di un numero (usare la virgola tra modulo e fase): ");
            string strModFase = Console.ReadLine();
            string[] mod = strModFase.Split(",");
            double modulo1 = Math.Cos(Convert.ToDouble(mod[0]) * (Math.PI / 180));
            double fase1 = Math.Sin(Convert.ToDouble(mod[1]) * (Math.PI / 180));

            Complesso modFas = new Complesso(modulo1, fase1);

            //richiamo il metodo e converto in polare
            string polar = modFas.ToPolar(modulo1, fase1);
            Console.WriteLine($"forma polare: {polar}");

            Console.WriteLine($"COSENO PRIMA {modulo1:n3} SENO PRIMA {fase1:n3}");

            //richiamo il metodo e converto in binomiale
            string binomial = modFas.ToBinomial(Math.Cosh(modFas.modulo), Math.Sinh(modFas.fase));
            Console.WriteLine($"forma binomiale: {binomial}");
        }
    }

    class Complesso
    {
        public double reale;
        public double immaginaria;
        public double modulo;
        public double fase;

        public Complesso()
        {

        }

        public Complesso(double a, double b, double c, double d)
        {
            reale = a;
            immaginaria = b;
            modulo = c;
            fase = d;
        }

        public Complesso(double modulo1, double fase1)
        {
            modulo = modulo1;
            fase = fase1;
        }

        public string ToPolar(double modulo, double fase)
        {
            return $"|{modulo:n3}| e {fase:n3}°";
        }

        public string ToBinomial(double reale, double immaginaria)
        {
            return $"{reale:n3} + {immaginaria:n3}i";
        }

        //calcolo fase
        public void Phi(Complesso w1)
        {
            //calcolo l'arcotangente di un numero in radianti
            fase = Math.Atan(w1.immaginaria / w1.reale);
        }

        //calcolo modulo
        public void Assoluto(Complesso w1)
        {
            modulo = Math.Sqrt(Math.Pow(w1.reale, 2) + Math.Pow(w1.immaginaria, 2));
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
