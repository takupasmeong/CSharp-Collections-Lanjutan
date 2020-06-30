using System;
using System.Collections.Generic;
using collections_lanjutan.classInduk;
using collections_lanjutan.classAnak;

namespace collections_lanjutan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<karyawan> listKaryawan = new List<karyawan>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("menu :\n1. Tambah Data\n2. Hapus Data\n3. Tampilkan Data\n4. Keluar\n");
                reinput:
                Console.Write("pilih [1..4] : ");
                string pilih = Console.ReadLine();
                switch (pilih)
                {
                    case "1":
                        Tambahdata(listKaryawan);
                        break;
                    case "2":
                        HapusData(listKaryawan);
                        break;
                    case "3":
                        TampilData(listKaryawan);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("opsi tidak tersedia");
                        goto reinput;
                }
            }
        }

        static void Tambahdata(List<karyawan> listKaryawan)
        {
            Console.Clear();
            Console.Write("jenis karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
            string pilih = Console.ReadLine();

            if (pilih == "1")
            {
                karyawanTetap karyawanTetap = new karyawanTetap();
                Console.Write("nik : ");
                karyawanTetap.Nik = Console.ReadLine();
                Console.Write("nama : ");
                karyawanTetap.Nama = Console.ReadLine();
                Console.Write("gaji bulanan : ");
                karyawanTetap.GajiBulanan = Convert.ToInt32(Console.ReadLine());

                listKaryawan.Add(karyawanTetap);
                Console.WriteLine("\ndata berhasil ditambahkan\n");
            }
            else if (pilih == "2")
            {
                karyawanHarian karyawanHarian = new karyawanHarian();
                Console.Write("nik : ");
                karyawanHarian.Nik = Console.ReadLine();
                Console.Write("nama : ");
                karyawanHarian.Nama = Console.ReadLine();
                Console.Write("jumlah jam kerja : ");
                karyawanHarian.JumlahJamKerja = Convert.ToInt32(Console.ReadLine());
                Console.Write("upah perjam : ");
                karyawanHarian.UpahPerJam = Convert.ToInt32(Console.ReadLine());

                listKaryawan.Add(karyawanHarian);
                Console.WriteLine("\ndata berhasil ditambahkan\n");
            }
            else if (pilih == "3")
            {
                sales sales = new sales();
                Console.Write("nik : ");
                sales.Nik = Console.ReadLine();
                Console.Write("nama : ");
                sales.Nama = Console.ReadLine();
                Console.Write("jumlah penjualan : ");
                sales.JumlahPenjualan = Convert.ToInt32(Console.ReadLine());
                Console.Write("komisi : ");
                sales.Komisi = Convert.ToInt32(Console.ReadLine());

                listKaryawan.Add(sales);
                Console.WriteLine("\ndata berhasil ditambahkan\n");
            }
            else
            {
                Console.WriteLine("\nopsi tidak tersedia\n");
            }
            Console.WriteLine("tekan sembarang untuk kembali ke menu awal...");
            Console.ReadKey();
        }

        static void HapusData(List<karyawan> listKaryawan)
        {
            Console.Clear();
            string nik;

            Console.Write("nik : ");
            nik = Console.ReadLine();

            for (int i = 0; i < listKaryawan.Count; i++)
            {
                if (nik == listKaryawan[0].Nik)
                {
                    listKaryawan.Remove(listKaryawan[i]);
                    Console.WriteLine("data karyawan berhasil dihapus\n");
                }
                else
                {
                    Console.WriteLine("data karyawan tidak ditemukan\n");
                }
            }
            Console.WriteLine("tekan sembarang untuk kembali ke menu awal...");
            Console.ReadKey();
        }

        static void TampilData(List<karyawan> listKaryawan)
        {
            Console.Clear();

            int noUrut = 1;

            foreach (karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3}, {4}", noUrut, karyawan.Nik, karyawan.Nama, string.Format("{0:n0}",karyawan.Gaji()), karyawan.status());
                noUrut++;
            }

            Console.WriteLine("\ntekan sembarang untuk kembali ke menu awal...");
            Console.ReadKey();
        }
    }
}
