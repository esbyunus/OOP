using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sample
{
    public class Calisan
    {
        public string _isim { get; set; }
        public string _gorev { get; set; }
        public Calisan(string isim, string gorev) 
        {
            _isim = isim;
            _gorev = gorev;
        }

        public void GorevYap()
        {
            Console.WriteLine($"{_isim} gorev yapiyor : {_gorev}");
        }   
    }
}
