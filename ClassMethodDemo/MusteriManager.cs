using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " isimli müşteri eklendi.");
        }

        public void MusteriList(Musteri musteri1, Musteri musteri2)
        {
            Console.WriteLine("Kayıtlı müşterilerin listesi: {" + musteri1.Name + ", " + musteri2.Name + "}");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " isimli müşteri kayıttan silindi.");
        }
    }
}
