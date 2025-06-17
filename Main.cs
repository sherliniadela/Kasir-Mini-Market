using System;

class Program
{
    // Fungsi untuk input data barang belanjaan
    static int InputBarang(string[] nama, int[] jumlah, int[] harga)
    {
        Console.Write("Jumlah barang yang dibeli: ");
        int n = int.Parse(Console.ReadLine());  // Membaca jumlah barang

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nama barang ke-{i + 1}: ");
            nama[i] = Console.ReadLine(); // Simpan nama barang

            Console.Write("Harga: ");
            harga[i] = int.Parse(Console.ReadLine()); // Simpan harga satuan

            Console.Write("Jumlah beli: ");
            jumlah[i] = int.Parse(Console.ReadLine()); // Simpan jumlah beli
        }

        return n; // Kembalikan jumlah barang yang diinput
    }

    // Fungsi untuk menampilkan daftar belanja dan menghitung total harga
    static int TampilkanDanHitungTotal(string[] nama, int[] jumlah, int[] harga, int n)
    {
        int total = 0; // Variabel penampung total harga

        Console.WriteLine("\n--- Daftar Belanja ---");
        for (int i = 0; i < n; i++)
        {
            int subtotal = jumlah[i] * harga[i]; // Harga total per barang
            Console.WriteLine($"{i + 1}. {nama[i]} x{jumlah[i]} = {subtotal}");
            total += subtotal; // Tambahkan ke total belanja
        }

        Console.WriteLine($"Total belanja: {total}");
        return total; // Kembalikan total belanja ke fungsi pemanggil
    }

    // Fungsi untuk menghitung dan menampilkan kembalian
    static void HitungKembalian(int total)
    {
        Console.Write("Uang dibayarkan: ");
        int bayar = int.Parse(Console.ReadLine()); // Input uang dari pembeli

        if (bayar < total)
        {
            Console.WriteLine("Uang tidak cukup!"); // Jika kurang
        }
        else
        {
            int kembalian = bayar - total;
            Console.WriteLine($"Kembalian: {kembalian}"); // Tampilkan kembalian
        }
    }

    // Fungsi utama program
    static void Main()
    {
        string ulang;
        do
        {
            // Siapkan array untuk menyimpan data barang maksimal 100
            string[] namaBarang = new string[100];
            int[] jumlahBarang = new int[100];
            int[] hargaBarang = new int[100];

            // Panggil fungsi input, tampilkan total, dan hitung kembalian
            int jumlah = InputBarang(namaBarang, jumlahBarang, hargaBarang);
            int total = TampilkanDanHitungTotal(namaBarang, jumlahBarang, hargaBarang, jumlah);
            HitungKembalian(total);

            // Tanya apakah ingin transaksi baru
            Console.Write("Transaksi baru? (y/n): ");
            ulang = Console.ReadLine();

        } while (ulang.ToLower() == "y"); // Ulangi jika user mengetik 'y'
    }
}
