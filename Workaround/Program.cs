using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
     class Program
    {
        static void Main(string[] args)
        {

            Vatandas vatandas    = new Vatandas();
            List<string> Sehir = new List<string> { "ankara", "bursa", "bolu" };
            Sehir.Add(item: "diyarbakır");
            foreach (string sehir in Sehir)
            {
                 Console.WriteLine(sehir);
            }
            SelamVer();
            Console.WriteLine(" ım a perfect girl");
            Console.ReadLine();

            
        }
        static void SelamVer(string isim="None")
        {
            Console.WriteLine("merhaba" + isim);
        }

        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Dogumyili { get; set; } 
            public long Tcno { get; set; }
        }
    }
}
