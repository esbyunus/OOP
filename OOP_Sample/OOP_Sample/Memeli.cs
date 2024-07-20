using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sample
{
    public class Memeli: Hayvan, IBesleme
    {
        public bool SutIcerMi { get; set; }

        public Memeli(string ad, int yas, bool sutIcerMi) : base(ad,yas)
        {
            SutIcerMi = sutIcerMi;
        }

        public override void SesCikar()
        {
            Console.WriteLine($"{_ad} ses cikariyor. ");
        }

        public void Besle()
        {
            Console.WriteLine($"{_ad} memelisi besleniyor. ");
        }
    }
}
