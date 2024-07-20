using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sample
{
    internal class Kus:Hayvan, IBesleme
    {
        public bool UcabilirMi { get; set; }
        public Kus(string ad, int yas, bool _UcabilirMi):base(ad,yas) 
        {
            UcabilirMi = _UcabilirMi;       
        }

        public override void SesCikar()
        {
            Console.WriteLine($"{_ad} otuyor. ");
        }
        public void Besle()
        {
            Console.WriteLine($"{_ad} kusu besleniyor.");
        }

    }
}
