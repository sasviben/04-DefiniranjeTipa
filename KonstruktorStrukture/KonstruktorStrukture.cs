using System;

namespace Vsite.CSharp
{
    class KonstruktorStrukture
    {
        struct MojaStruktura
        {
            public int a;
            public string s;
           public MojaStruktura(int a, string s)
            {
                this.a = 10;
                this.s = s;
            }
        }

        static void Main(string[] args)
        {
            //  Stvoriti objekt strukture MojaStruktura i ispisati vrijednosti članova

            MojaStruktura ms = new MojaStruktura();
            Console.WriteLine(ms.a);
            Console.WriteLine(ms.s);
            //  U strukturi MojaStruktura promijeniti prazan konstruktor tako da prima dva argumenta kojima se inicijaliziraju članovi te ponoviti gornji postupak
            MojaStruktura ms2 = new MojaStruktura(10,"Zagreb");
            Console.WriteLine(ms2.a);
            Console.WriteLine(ms2.s);

            Console.ReadKey();

        }
    }
}
