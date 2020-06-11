// using System;
// using System.Collections;
// using System.Collections.Generic;

// namespace QL_SinhVien
// {
//     class Program
//     {
//         static int n = 0;
//         // static List<SinhVien> sv = new List<SinhVien>();
//         static Dictionary<string, SinhVien> sv = new Dictionary<string, SinhVien>();
//         struct SinhVien
//         {
//             // string maSV;
//             string tenSV;
//             double diem;

//             public SinhVien(/*string ma,*/ string ten, double diem)
//             {
//                 // this.maSV = ma;
//                 this.tenSV = ten;
//                 this.diem = diem;
//             }

//             public string toString()
//             {
//                 return "Ho va ten: " + tenSV + "\nDiem: " + diem + "\n";
//             }
//         }

        
//         static void addSV()
//         {
//             Console.Write("Nhap ma sinh vien: ");
//             string ma = Console.ReadLine();
//             Console.Write("Nhap ho va ten sinh vien: ");
//             string ten = Console.ReadLine();
//             double diem;
//             do
//             {
//                 Console.Write("Nhap diem: ");
//                 diem = Double.Parse(Console.ReadLine());
//                 if (diem < 0 || diem > 10)
//                     Console.WriteLine("Vui long nhap lai.");
//             } while (diem < 0 || diem > 10);
//             sv.Add(ma,new SinhVien(ten,diem));
//         }

        

//         static void input()
//         {
//             do
//             {
//                 Console.Write("Nhap so luong sinh vien: ");
//                 n = Int16.Parse(Console.ReadLine());
//                 if (n < 0)
//                     Console.WriteLine("Nhap lai: ");
//             } while (n < 0);
//             for(int i = 0; i<n; i++){
//                 Console.WriteLine("-----------------------------\nNhap sinh vien thu "+(i+1));
//                 addSV();
//             }
//         }

//         struct Key{
//             string maSV;
//             SinhVien s;
//         }

//         static void output(){
//             if(n>0)
//                 // for(int i=0; i<n; i++){
//                 //     Console.WriteLine(sv[i].toString()+"\n-----------------------------");
//                 // }
//                 foreach(Key i in sv){
                    
//                     Console.WriteLine(i);
//                 }
//             else{
//                 Console.WriteLine("Ban chua nhap du lieu sinh vien, vui long nhap.");
//                 input();
//             }
//         }

//         static void Main(string[] args)
//         {
//             //Dòng này để bỏ cảnh báo while(true/false)
//             #pragma warning disable
//             do{
//                 Console.Write("Nhap 1 de them sinh vien.\nNhap 2 de xuat thong tin sinh vien.\nNhap 3 de dung chuong trinh\nNhap: ");
//                 int check = Int16.Parse(Console.ReadLine());
//                 switch(check){
//                     case 1: 
//                         input();
//                         break;
//                     case 2: 
//                         output();
//                         break;
//                     case 3:
//                         Console.WriteLine("Cam on ban da su dung san pham cu chuoi cua Hoan. Hi vong ban khong thay no cu chuoi :))");
//                         Environment.Exit(0);
//                         Console.ReadKey();
//                         break;
//                     default:
//                         Console.WriteLine("Nhap sai, vui long nhap lai theo huong dan.");
//                         break;
//                 } 
//             }while(true);
//             Console.ReadKey();
//         }
//     }
// }
