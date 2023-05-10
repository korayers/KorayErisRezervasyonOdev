using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakRezervasyonKonsol.Interfaces;

namespace UcakRezervasyonKonsol.Models
{
    public class Rezervasyon : IRezervasyon
    {
        public Ucak Ucak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Lokasyon Lokasyon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Musteri Musteri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TarihSaat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AcikMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KoltukNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
