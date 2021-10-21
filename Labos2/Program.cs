using System;


namespace Labos2
{
    class Program
    {
        static void Main(string[] args)
        {

            var kbk = new KompleksniBrojKlasa(1, 2);
            var kbs = new KompleksniBrojStruktura(3, 4);
            Console.WriteLine("KompleksniBrojKlasa 1     " + kbk);
            Console.WriteLine("KompleksniBrojStruktura 1     " + kbs);
            Console.WriteLine();

            var kbk2 = kbk;
            var kbs2 = kbs;

            //copy by reference
            kbk2.RealniDio = 5;
            //copy by value
            kbs2.RealniDio = 6;

            Console.WriteLine("KompleksniBrojKlasa 1     " + kbk);
            Console.WriteLine("KompleksniBrojStruktura 1     " + kbs);
            Console.WriteLine("KompleksniBrojKlasa 2     " + kbk2);
            Console.WriteLine("KompleksniBrojStruktura 2     " + kbs2);
            Console.WriteLine();

        }
    }
}
