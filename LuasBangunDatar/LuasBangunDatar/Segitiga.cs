using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Segitiga : BangunDatar
    {
        public override double hitungLuas()
        {
            Hitung = 0.5 * (getAlas() * getTinggi());
            Console.WriteLine("Luas Segitiga     : " + Hitung);
            return Hitung;
        }
        public override double hitungKeliling()
        {
            Hitung = getAlas() + getTinggi() + getSisi();
            Console.WriteLine("Keliling Segitiga : " + Hitung);
            return Hitung;
        }

        public virtual void LKSegitiga()
        {
            Console.WriteLine("Masukan Nilai Alas : ");
            setAlas(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Nilai Tinggi : ");
            setTinggi(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Nilai Sisi : ");
            setSisi(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" ");
            hitungLuas();
            hitungKeliling();
        }


    }
}
