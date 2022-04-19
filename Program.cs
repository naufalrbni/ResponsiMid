using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4281
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karyawan Karyawan = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan Karyawan2 = new Karyawan(190302124, "Jono", 2000000);

            Console.WriteLine("NIK/Nama \t Gaji Bulanan");
            Console.WriteLine("--------------------------------");
            Karyawan.ShowKaryawan();
            Karyawan2.ShowKaryawan();

            Console.WriteLine("\n\nAsyiiiiik kenaikan gaji 10%!!");
            Console.WriteLine();

            Console.WriteLine("NIK/Nama \t Gaji Bulanan");
            Console.WriteLine("--------------------------------");
            Karyawan.NaikGaji();
            Karyawan2.NaikGaji();

            Console.ReadKey();
        }
    }
}
