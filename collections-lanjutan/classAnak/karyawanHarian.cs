using System;
using System.Collections.Generic;
using System.Text;
using collections_lanjutan.classInduk;

namespace collections_lanjutan.classAnak
{
    class karyawanHarian : karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
        public override string status()
        {
            return "Karyawan Harian";
        }
    }
}
