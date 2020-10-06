using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenStatickeVarijable2
{
    class Program
    {
        static void Main(string[] args)
        {

            PrvaKlasa x = new PrvaKlasa("Eugen", "Koštro");
            Console.WriteLine(x.ToString());
            PrvaKlasa y = new PrvaKlasa("Pero", "Perić");
            Console.WriteLine(y.ToString());
            PrvaKlasa z = new PrvaKlasa();
            

            z.Ime = "Đuro";
            z.Prezime = "Đurić";
            Console.WriteLine(z.ToString());


            Console.ReadLine();


        }
    }
}
