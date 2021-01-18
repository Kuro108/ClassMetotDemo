using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Id + "  " + musteri.Adi + "  " + musteri.Soyadi + "  " + musteri.Yasi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Id + "  " + musteri.Adi + "  " + musteri.Soyadi + "  " + musteri.Yasi);
        }
        public void Listele(Musteri musteri)
        {
            Musteri[] musteriler = new Musteri[] { musteri };

            foreach (var listele in musteriler)
            {
                Console.WriteLine(musteri.Id + "\n" + musteri.Adi + "\n" + musteri.Soyadi + "\n" + musteri.Yasi);

            }

        }
    }
}
