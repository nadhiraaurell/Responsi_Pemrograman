using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_4399
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan


        static List<Penjualan> daftarPenjualan = new List<Penjualan>();
        
        static void Main(string[] args)
        {
             Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                Console.Clear();
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");

            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            string nota, tanggal, customer, tipe1;
            string tipe2 = "salah";
            int total;

            Console.WriteLine("Tambah Data Penjualan\n");

            Console.Write("Nota: ");
            nota = Console.ReadLine();

            Console.Write("Tanggal: ");
            tanggal = Console.ReadLine();

            Console.Write("Customer: ");
            customer = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            tipe1 = Console.ReadLine();
            if (tipe1 == "T" || tipe1 == "t")
            {
                tipe2 = "Tunai";
            }
            if (tipe1 == "K" || tipe1 == "k")
            {
                tipe2 = "Kredit";
            }
            Console.Write("Total Nota: ");
            total = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() { note = nota, Date = tanggal, Customer = customer, type = tipe2, Total = total });


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("Data Penjualan\n");

            int no = 1;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, daftar.note, daftar.Date, daftar.Customer, daftar.type, daftar.Total);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
