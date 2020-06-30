using System;
using System.Collections.Generic;
using System.Text;
using collections_lanjutan.classInduk;

namespace collections_lanjutan.classAnak
{
    class karyawanTetap : karyawan
    {
        public double GajiBulanan { get; set; }

        public override double Gaji()
        {
            return GajiBulanan;
        }
        public override string status()
        {
            return "Karyawan Tetap";
        }
    }
}
