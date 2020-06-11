using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra1
{

    class Program
    {
        static int[,] arr1 = new int[100, 100];
        static int[,] arr2 = new int[100, 100];
        static int[,] arr3 = new int[100, 100];
        static int cot1, cot2, hang1, hang2;
        static void input_ma_tran_1()
        {
            String input = File.ReadAllText(@"TextFile1.txt");

            int i = 0, j = 0;
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    arr1[i, j] = Int16.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            cot1 = i;
            hang1 = j;
        }
        static void input_ma_tran_2()
        {
            String input = File.ReadAllText(@"TextFile2.txt");

            int i = 0, j = 0;
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    arr2[i, j] = Int16.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            cot2 = i;
            hang2 = j;
        }

        static void output_1()
        {
            Console.WriteLine("Ma tran: ");
            for (int i = 0; i < cot1; i++)
            {
                for (int j = 0; j < hang1; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void output_2()
        {
            Console.WriteLine("Ma tran: ");
            for (int i = 0; i < cot2; i++)
            {
                for (int j = 0; j < hang2; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void tong()
        {
            if (cot1 != cot2 && hang1 != hang2)
                Console.WriteLine("Khong the cong 2 ma tran. Ma tran phai cung cap");
            else
            {

                Console.WriteLine("Ma tran tong: ");
                for (int i = 0; i < cot2; i++)
                {
                    for (int j = 0; j < hang2; j++)
                    {
                        arr3[i, j] = arr1[i, j] + arr2[i, j];
                        Console.Write(arr3[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void chuyenvi()
        {
            Console.WriteLine("Ma tran da chuyen vi: ");
            for (int i = 0; i < hang1; i++)
            {
                for (int j = 0; j < cot1; j++)
                {
                    arr3[i, j] = arr1[j, i];
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void tich()
        {
            if (cot2 != hang1)
            {
                Console.WriteLine("Khong the thuc hien tinh tich 2 ma tran");
            }
            else
            {
                Console.WriteLine("Ma tran tich: ");
                for (int i = 0; i < hang1; i++)
                {
                    for (int j = 0; j < cot1; j++)
                    {
                        arr3[i, j] = 0;
                        for (int k = 0; k < cot2; k++)
                        {
                            arr3[i, j] += arr1[i, j] * arr2[i, j];
                            Console.Write(arr3[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            input_ma_tran_1();
            output_1();
            input_ma_tran_2();
            output_2();
            tong();
            chuyenvi();
            tich();
            Console.ReadKey();

        }
    }

}
