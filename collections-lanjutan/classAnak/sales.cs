using System;
using System.Collections.Generic;
using System.Text;
using collections_lanjutan.classInduk;

namespace collections_lanjutan.classAnak
{
    class sales : karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
        public override string status()
        {
            return "Sales";
        }
    }
}
