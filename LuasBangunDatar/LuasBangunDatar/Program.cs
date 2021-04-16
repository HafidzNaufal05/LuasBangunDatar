using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Program
    {
        static void Menu()
        {
            Persegi persegi = new Persegi();
            PersegiPanjang persegiPanjang = new PersegiPanjang();
            JajarGenjang jajarGenjang = new JajarGenjang();
            Segitiga segitiga = new Segitiga();
            Lingkaran lingkaran = new Lingkaran();
            try
            {
                Console.WriteLine("Aplikasi Menghitung Luas dan Keliling Bangun Datar");
                Console.WriteLine(" ");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Jajar Genjang");
                Console.WriteLine("4. Segitiga");
                Console.WriteLine("5. Lingkaran");
                Console.WriteLine(" ");
                Console.WriteLine("Masukan Angka 1-5 untuk memilih Menu : ");
                int menu = Convert.ToInt16(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        persegi.LKPersegi();
                        break;
                    case 2:
                        persegiPanjang.LKPersegiPanjang();
                        break;
                    case 3:
                        jajarGenjang.LKJajarGenjang();
                        break;
                    case 4:
                        segitiga.LKSegitiga();
                        break;
                    case 5:
                        lingkaran.LKLingkaran();
                        break;
                    default:
                        Console.WriteLine("Masukkan Angka Hanya dari 1-5");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Masukkan Angka bukan Huruf/Kata");
            }
            
        }
        static void Main(string[] args)
        {
            try
            {
                Menu();
                int i = 1;
                while (i > 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Apakah Akan Kembali Ke Menu Utama (yes/no)");
                    string jwb = Console.ReadLine();
                    if (jwb.ToLower() == "yes")
                    {
                        Menu();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Tulis jawaban sesuai petunjuk");
            }
            
        }
    }
}
