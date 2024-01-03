// See https://aka.ms/new-console-template for more information
using ClassMethodDemo;

Musteri Berkay = new Musteri();

Berkay.Id = 1;
Berkay.Name = "Berkay";
Berkay.Age = 26;

Musteri Clever = new Musteri();

Clever.Id = 2;
Clever.Name = "Clever";
Clever.Age = 2;

MusteriManager musteriManager = new MusteriManager();

musteriManager.MusteriList(Berkay, Clever);
musteriManager.MusteriEkle(Berkay);
musteriManager.MusteriSil(Clever);