using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    class Persegi : BangunDatar
    {
        
        public override double hitungLuas()
        {
            Hitung = Math.Pow(getSisi(), 2);
            Console.WriteLine("Luas Persegi     : "+Hitung);    
            return Hitung;
        }

        public override double hitungKeliling()
        {
            Hitung = getSisi() * 4;
            Console.WriteLine("Keliling Persegi : "+Hitung);
            return Hitung;
        }
        public virtual void LKPersegi()
        {
            Console.WriteLine("Masukan Nilai Sisi : ");
            setSisi(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" ");
            hitungLuas();
            hitungKeliling();
        }

    }
}
