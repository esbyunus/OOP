using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sample
{
    public class HayvanatBahcesi
    {
        public List<Hayvan> Hayvanlar { get; set; } = new List<Hayvan>();
        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        public List<Ziyaretci> Ziyaretciler { get; set; } = new List<Ziyaretci>();

        public void HayvanEkle(Hayvan hayvan)
        {
            Hayvanlar.Add(hayvan);
        }

        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
        }
        public void ZiyaretciEkle(Ziyaretci ziyaretci)
        {
            Ziyaretciler.Add(ziyaretci);
        }

    }
}
