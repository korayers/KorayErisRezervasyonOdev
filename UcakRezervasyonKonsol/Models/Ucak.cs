using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakRezervasyonKonsol.Interfaces;

namespace UcakRezervasyonKonsol.Models
{
    public class Ucak : IUcak
    {
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SeriNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BakimTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KoltukKapasitesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
