using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Aşama Başarıyla Gerçekleşti");
            Kisi kisi = new Kisi();
            kisi.KisiAdi = "MAhmut Yıldız ";
            kisi.KisiSoyadi = "Mehmet Yildiz";
            Console.ReadLine();
        }
    }
}
