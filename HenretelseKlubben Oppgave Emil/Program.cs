using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenretelseKlubben_Oppgave_Emil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Oppgave2();
            Oppgave3("Sus");
            Oppgave4(110, 310);
            Console.WriteLine(Oppgave5());
            Console.ReadLine();
        }

        static void Oppgave2()
        {
            // Skriver ut Hello world via en metode
            Console.WriteLine("hello world");
        }

        static void Oppgave3(string value)
        {
            // tar imot en parameter, string og skriver det ut via metode
            Console.WriteLine(value);
        }

        static void Oppgave4(int tall1, int tall2)
        {
            // 
            Console.WriteLine(tall1 + tall2);
        }

        static int Oppgave5()
        {
            int tall1 = 20;
            int tall2 = 50;
            return tall1 + tall2;
        }
    }
}
