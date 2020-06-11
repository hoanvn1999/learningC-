using System;
using System.Collections.Generic;

namespace KiemTra2
{
    class Program
    {
        class Nguoi{
            private string ho_ten;
            private long cmnd;
            private DateTime ngay_sinh = new DateTime();
            private string dia_chi;
            public Nguoi(){ }
            public Nguoi(string ho_ten, long cmnd, DateTime ngay_sinh, string dia_chi){
                this.ho_ten = ho_ten;
                this.cmnd = cmnd;
                this.ngay_sinh = ngay_sinh;
                this.dia_chi = dia_chi;
            }
        }
        class NhanVien:Nguoi{
            private string ma_nv;
            private long luong;
            private string phong_ban;
            NhanVien (){}
            NhanVien (string ho_ten, long cmnd, DateTime ngay_sinh, string dia_chi, string ma_nv, long luong, string phong_ban):base(ho_ten, cmnd, ngay_sinh, dia_chi){
                this.ma_nv = ma_nv;
                this.luong = luong;
                this.phong_ban = phong_ban;
            }
            public string getMa(){
                return ma_nv;
            }
        }
        
        static int n = 0;
        static Dictionary<string, NhanVien> list_nv = new Dictionary<string, NhanVien>();

        static Boolean checkExist(string id){
            for(int i=0; i<n; i++){
                if(id == list_nv[i].getMa())
                    return false;
            }
            return true;
        }

        static void input()
        {
            try
            {
                string line = "";
                n=0;
                using (StreamReader sr = new StreamReader("nhanvien.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string ho_ten = line;
                        long cmnd = long.Parse(line);
                        DateTime ngay_sinh = new DateTime(line);
                        string dia_chi = line;
                        string ma = line;
                        long luong = long.Parse(line);
                        string phong_ban = Double.Parse(line);
                        sv.Add(new NhanVien(ho_ten, cmnd, ngay_sinh, dia_chi, ma, luong, phong_ban));
                        n++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Khong the doc file");
            }
        }

        static void Main(string[] args)
        {
            input();
        }
    }
}
