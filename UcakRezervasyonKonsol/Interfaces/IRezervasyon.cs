using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakRezervasyonKonsol.Models;

namespace UcakRezervasyonKonsol.Interfaces
{
    public interface IRezervasyon
    {
        public Ucak Ucak { get; set; }
        public Lokasyon Lokasyon { get; set; }
        public Musteri Musteri { get; set;}
        public int TarihSaat { get; set; }
        public bool AcikMi { get; set; }
        public int KoltukNo { get; set; }
    }
}
