using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sample
{
    public class Kurbaga:Hayvan,IBesleme
    {
        public bool YuzerMi { get; set; }
        public Kurbaga(string ad, int yas, bool yuzerMi):base(ad,yas)
        {
            yuzerMi = YuzerMi;
        }
        public override void SesCikar()
        {
            Console.WriteLine($"{_ad} vakliyor.");
        }
        public void Besle()
        {
            Console.WriteLine($"{_ad} kurbagasi besleniyor.");
        }
    }
}
