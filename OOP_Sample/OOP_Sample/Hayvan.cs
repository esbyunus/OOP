using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sample
{
    public abstract class Hayvan
    {
        public string _ad { get; set; }
        public int _yas { get; set; }

        public Hayvan(string ad, int yas) //ctor
        {
            _ad = ad;
            _yas = yas;
        }
        public abstract void SesCikar();
    }
}
