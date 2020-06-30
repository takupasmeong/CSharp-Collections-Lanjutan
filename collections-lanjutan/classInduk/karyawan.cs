using System;
using System.Collections.Generic;
using System.Text;

namespace collections_lanjutan.classInduk
{
    public abstract class karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
        public abstract string status();
    }
}
