using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4505
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public double GajiBulanan { get; set; }

        public Karyawan()
        {
        }

        public Karyawan(string nik, string nama, double gajiBulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajiBulanan;
        }
    }
}
