using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace QL_SinhVien
{
    class Program
    {
        static int n = 0;
        static List<SinhVien> sv = new List<SinhVien>();
        // struct SinhVien
        // {
        //     string maSV;
        //     string tenSV;
        //     double diem;

        //     public SinhVien(string ma, string ten, double diem)
        //     {
        //         this.maSV = ma;
        //         this.tenSV = ten;
        //         this.diem = diem;
        //     }

        //     public string toString()
        //     {
        //         return "Ho va ten: " + tenSV + "\nMa sinh vien: " + maSV + "\nDiem: " + diem + "\n";
        //     }
        // }
        static Boolean checkExist(string id){
            for(int i=0; i<n; i++){
                if(id == sv[i].getID())
                    return false;
            }
            return true;
        }
        public class SinhVien{
            private string maSV, tenSV; 
            private double diem;
            public SinhVien(string ma, string ten, double diem){
                this.maSV = ma;
                this.tenSV = ten;
                this.diem = diem;
            }

            public string getID(){
                return this.maSV;
            }

            public string toString()
            {
                return "Ho va ten: " + tenSV + "\nMa sinh vien: " + maSV + "\nDiem: " + diem + "\n";
            }
        }

        static void addSV()
        {
            string ma;
            do{
                Console.Write("Nhap ma sinh vien: ");
                ma = Console.ReadLine();
                if(checkExist(ma))
                    Console.WriteLine("ID da ton tai, vui long nhap lai");
            }while(checkExist(ma));
            Console.Write("Nhap ho va ten sinh vien: ");
            string ten = Console.ReadLine();
            double diem;
            do
            {
                Console.Write("Nhap diem: ");
                diem = Double.Parse(Console.ReadLine());
                if (diem < 0 || diem > 10)
                    Console.WriteLine("Vui long nhap lai.");
            } while (diem < 0 || diem > 10);
            using (StreamWriter sw = new StreamWriter("sinhvien.txt"))
            {
                sw.WriteLine(ma);
                sw.WriteLine(ten);
                sw.WriteLine(diem);
            }
        }

        static void input()
        {
            do
            {
                Console.Write("Nhap so luong sinh vien: ");
                n = Int16.Parse(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine("Nhap lai: ");
            } while (n < 0);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-----------------------------\nNhap sinh vien thu " + (i + 1));
                addSV();
            }
        }

        static void output()
        {
            try
            {
                string line = "";
                n=0;
                using (StreamReader sr = new StreamReader("sinhvien.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string ma = line;
                        string ten = line;
                        double diem = Double.Parse(line);
                        sv.Add(new SinhVien(ma, ten, diem));
                        n++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Khong the doc file");
            }
            if (n > 0)
                for (int i = 0; i < n; i++)
                    Console.WriteLine(sv[i].toString() + "\n-----------------------------");
            else
            {
                Console.WriteLine("Ban chua nhap du lieu sinh vien, vui long nhap.");
                input();
            }
        }

        static void Main(string[] args)
        {
            //Dòng này để bỏ cảnh báo while(true/false)
            #pragma warning disable
            do
            {
                Console.Write("Nhap 1 de them sinh vien.\nNhap 2 de xuat thong tin sinh vien.\nNhap 3 de dung chuong trinh\nNhap: ");
                int check = Int16.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        input();
                        break;
                    case 2:
                        output();
                        break;
                    case 3:
                        Console.WriteLine("Cam on ban da su dung san pham cu chuoi cua Hoan. Hi vong ban khong thay no cu chuoi :))");
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Nhap sai, vui long nhap lai theo huong dan.");
                        break;
                }
            } while (true);
            Console.ReadKey();
        }
    }
}

