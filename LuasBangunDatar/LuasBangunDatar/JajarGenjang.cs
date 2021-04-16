using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class JajarGenjang : BangunDatar
    {
        private double alas, tinggi, miring;
        
        public override double hitungLuas()
        {
            Hitung = getAlas() * getTinggi();
            Console.WriteLine("Luas Jajar Genjang     : " + Hitung);
            return Hitung;
        }
        public override double hitungKeliling()
        {
            Hitung = (2 * (getAlas() + getMiring()));
            Console.WriteLine("Keliling Jajar Genjang : " + Hitung);
            return Hitung;
        }


        public virtual void LKJajarGenjang()
        {
            Console.WriteLine("Masukan Nilai Alas : ");
            setAlas(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Nilai Tinggi : ");
            setTinggi(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Nilai Sisi Miring : ");
            setMiring(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" ");
            hitungLuas();
            hitungKeliling();
        }
    }
}
