using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4505
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krywn1 = new Karyawan("211145051", "Ahmad", 2000000);
            Karyawan krywn2 = new Karyawan("211145052", "Fauzi", 3000000);

            Console.WriteLine("No NIK/NAMA\t\tGaji Bulanan");
            CetakHasil(krywn1);
            CetakHasil(krywn2);
            Console.WriteLine();

            Console.WriteLine("Asyiik kenaikan gaji 10% !!");
            Console.WriteLine();

            Console.WriteLine("No NIK/NAMA\t\tGaji Bulanan");
            NaikGaji(krywn1);
            CetakHasil(krywn1);
            NaikGaji(krywn2);
            CetakHasil(krywn2);

            Console.ReadKey();
        }

        static void CetakHasil(Karyawan krywn)
        {
            Console.WriteLine("1. {0} {1}\t{2}", krywn.Nik, krywn.Nama, krywn.GajiBulanan);
        }

        static double NaikGaji(Karyawan krywn)
        {
            krywn.GajiBulanan = krywn.GajiBulanan + (0.1 * krywn.GajiBulanan);
            return krywn.GajiBulanan;
        }


    }
}
