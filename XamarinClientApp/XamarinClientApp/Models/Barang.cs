using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClientApp.Models
{
    public class Barang
    {
        public int KodeBarang { get; set; }
        public string IdJenisMotor { get; set; }
        public string KategoriId { get; set; }
        public string Nama { get; set; }
        public string Stok { get; set; }
        public string HargaBeli { get; set; }
        public string HargaJual { get; set;}
        public DateTime TanggalBeli { get; set; }
    }
}
