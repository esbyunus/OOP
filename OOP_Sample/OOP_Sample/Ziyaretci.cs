using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sample
{
    public class Ziyaretci
    {
        public string _ad { get; set; }
        public int _yas { get; set; }

        public Ziyaretci(string ad, int yas)
        {
            _ad = ad;
            _yas = yas;
        }

        public void HayvanlariGozlemle(List<Hayvan> hayvanlar)
        {
            Console.WriteLine($"{_ad} hayvanlari gozlemliyor. ");
            foreach (var hayvan in hayvanlar) 
            {
                hayvan.SesCikar();
            }
        }
    }
}
