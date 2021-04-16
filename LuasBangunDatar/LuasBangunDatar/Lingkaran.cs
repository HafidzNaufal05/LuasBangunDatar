using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Lingkaran : BangunDatar
    {
        const double phi = 3.14;
        
        public override double hitungLuas()
        {
            Hitung = phi * (Math.Pow(getJari2(), 2));
            Console.WriteLine("Luas Lingkaran     : " + Hitung);
            return Hitung;
        }
        public override double hitungKeliling()
        {
            Hitung = phi * 2 * getJari2();
            Console.WriteLine("Keliling Lingkaran : " +Hitung);
            return Hitung;
        }

        public virtual void LKLingkaran()
        {
            Console.WriteLine("Masukan Nilai Jari-Jari : ");
            setJari2(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" ");
            hitungLuas();
            hitungKeliling();
        }
       
    }
}
