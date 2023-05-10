using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonKonsol.Interfaces
{
    public interface IUcus
    {
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public double UcusSuresi { get; set; }
    }
}
