using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class PersegiPanjang : BangunDatar
    {
        public override double hitungLuas()
        {
            
            Hitung = getPanjang() * getLebar();
            Console.WriteLine("Luas Persegi Panjang     : " + Hitung);
            return Hitung;
        }

        public override double hitungKeliling()
        {
            Hitung = (2 * (getPanjang() * getLebar()));
            Console.WriteLine("Keliling Persegi Panjang : " + Hitung);
            return Hitung;

        }
        public virtual void LKPersegiPanjang()
        {
            Console.WriteLine("Masukan Nilai Panjang : ");
            setPanjang(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukkan Nilai Lebar : ");
            setLebar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" ");
            hitungLuas();
            hitungKeliling();
        }
        
    }
}
