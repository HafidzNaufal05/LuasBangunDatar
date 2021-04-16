using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    abstract class BangunDatar
    {
        private double sisi, panjang, lebar, alas, tinggi, miring, jari2, hitung;

        //Setter
        public void setSisi(double s)
        {
            this.sisi = s;
        }
        public void setPanjang(double p)
        {
            this.panjang = p;
        }
        public void setLebar(double l)
        {
            this.lebar = l;
        }
        public void setAlas(double a)
        {
            this.alas = a;
        }
        public void setTinggi(double t)
        {
            this.tinggi = t;
        }
        public void setMiring(double m)
        {
            this.miring = m;
        }
        public void setJari2(double r)
        {
            this.jari2 = r;
        }
        public double getSisi()
        {
            return sisi;
        }
        
        //Getter
        public double getPanjang()
        {
            return panjang;
        }
        public double getLebar()
        {
            return lebar;
        }
        public double getAlas()
        {
            return alas;
        }
        public double getTinggi()
        {
            return tinggi;
        }
        public double getMiring()
        {
            return miring;
        }

        public double getJari2()
        {
            return jari2;
        }

        //Getter dan Setter
        public double Hitung
        {
            get { return hitung; }
            set { hitung = value; }
        }

        //Method
        public abstract double hitungLuas();
        public abstract double hitungKeliling();
    }
}
