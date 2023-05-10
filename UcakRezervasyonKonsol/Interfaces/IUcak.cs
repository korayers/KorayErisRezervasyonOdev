using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonKonsol.Interfaces
{
    public interface IUcak
    {
        string Model { get; set; }
        string SeriNo { get; set; }
        DateTime BakimTarihi { get; set; }
        int KoltukKapasitesi { get; set; }
    }
}
