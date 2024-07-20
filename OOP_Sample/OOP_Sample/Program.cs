namespace OOP_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hayvanlar
            Memeli fil = new Memeli("Fil", 15, true);
            Kus karga = new Kus("Karga", 6, true);
            Kurbaga camKurbaga = new Kurbaga("Cam", 3, true);

            //Calisanlar
            Calisan calisan1 = new Calisan("Ali", "Veteriner");
            Calisan calisan2 = new Calisan("Ahmet", "Guvenlik");

            //Ziyaretciler
            Ziyaretci ziyaretci1 = new Ziyaretci("Yunus", 25);
            Ziyaretci ziyaretci2 = new Ziyaretci("Ecem", 22);

            //Hayvanat Bahcesi
            HayvanatBahcesi _HayvanatBahcesi = new HayvanatBahcesi();
            _HayvanatBahcesi.HayvanEkle(fil);
            _HayvanatBahcesi.HayvanEkle(karga);
            _HayvanatBahcesi.HayvanEkle(camKurbaga);

            _HayvanatBahcesi.CalisanEkle(calisan1);
            _HayvanatBahcesi.CalisanEkle(calisan2);

            _HayvanatBahcesi.ZiyaretciEkle(ziyaretci1);
            _HayvanatBahcesi.ZiyaretciEkle(ziyaretci2);

            foreach(var hayvan in _HayvanatBahcesi.Hayvanlar)
            {
                if (hayvan is IBesleme besleme)
                {
                    besleme.Besle();
                }
            }

            foreach(var calisan in _HayvanatBahcesi.Calisanlar)
            {
                calisan.GorevYap();
            }

            foreach (var ziyaretci in _HayvanatBahcesi.Ziyaretciler)
            {
                ziyaretci.HayvanlariGozlemle(_HayvanatBahcesi.Hayvanlar);
            }


        }
    }
}
