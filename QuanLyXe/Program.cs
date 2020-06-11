using System;
using System.Collections.Generic;

namespace QuanLyXe
{
    class Program
    {
        class Xe{
            private string bien_so;
            private string ten_xe;
            private int trong_tai;
            private DateTime ngay_dang_kiem = new DateTime();
            private int tieu_chuan;
            public Xe (){ }
            public Xe(string bien_so, string ten_xe, int trong_tai, DateTime ngay_dang_kiem, int tieu_chuan){
                this.bien_so = bien_so;
                this.ten_xe = ten_xe;
                this.trong_tai = trong_tai;
                this.ngay_dang_kiem = ngay_dang_kiem;
                this.tieu_chuan = tieu_chuan;
            }
            public string B{
                get {return this.bien_so;}
                set {this.bien_so = value;}
            }
            public virtual void In(){
                Console.WriteLine("Bien so:\t\t",this.bien_so,"\nTen Xe:\t\t",this.ten_xe,"\nTrong tai:\t\t",this.trong_tai,"\nNgay dang kiem:\t\t",this.ngay_dang_kiem.Day," - ",this.ngay_dang_kiem.Month, " - ",this.ngay_dang_kiem.Year, "Tieu chuan hang: ", this.tieu_chuan);
            }
        }
        class Xe_Du_Lich : Xe{
            private int so_cho_ngoi;
            public Xe_Du_Lich(){}
            public Xe_Du_Lich(string bien_so, string ten_xe, int trong_tai, DateTime ngay_dang_kiem, int tieu_chuan, int so_cho_ngoi):base(bien_so, ten_xe,trong_tai,ngay_dang_kiem,tieu_chuan){
                this.so_cho_ngoi = so_cho_ngoi;
            }
            public override void In(){
                base.In();
                Console.WriteLine("So cho ngoi: ",this.so_cho_ngoi);
            }
            public int Cho_Ngoi{
                get {return this.so_cho_ngoi;}
                set {this.so_cho_ngoi = value;}
            }
        }
        class Xe_Cho_Hang : Xe{
            private double so_tan;
            public Xe_Cho_Hang(){}
            public Xe_Cho_Hang(string bien_so, string ten_xe, int trong_tai, DateTime ngay_dang_kiem, int tieu_chuan, double so_tan):base(bien_so,ten_xe,trong_tai,ngay_dang_kiem,tieu_chuan){
                this.so_tan = so_tan;
            }
             public override void In(){
                base.In();
                Console.WriteLine("So tan: ",this.so_tan);
            }
            public int So_Tan{
                get {return this.so_tan;}
                set {this.so_tan = value;}
            }
        }
        class QuanLyXe {
            private Dictionary<string, Object> list = new Dictionary<string, object>();
            int yyyy, mm, dd;
            public void YYYY_MM_DD(string yy_mm_dd, ref int yyyy, ref int mm, ref int dd){
                int k=0;
                for(int i=0; i<yy_mm_dd; i++){
                    if(yy_mm_dd[i]=' ' || (i==yy_mm_dd -1)){
                        if(k==0) dd = int.Parse(yy_mm_dd.Substring(k,i-k+1).Trim());
                        else if(i<yy_mm_dd-1)   mm = int.Parse(yy_mm_dd.Substring(k,i-k+1).Trim());
                        else yyyy = int.Parse(yy_mm_dd.Substring(k,i-k+1).Trim());
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}   
