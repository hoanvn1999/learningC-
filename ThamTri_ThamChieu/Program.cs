using System;

namespace ThamTri_ThamChieu
{
    class Program
    {
        /*static void Sub(int x, out int y)
        {
            y = x - 2;
        } 
        static void Main(string[] args)
        {
            int x = 15, y;
            Sub(x, out y);
            Console.WriteLine("y= " +y);
            Console.ReadKey();
        }
    }*/
        /*static void SumArr(out int result, params int[] Arr)
        {
            result = 0;
            for (int i = 0; i < Arr.Length; i++) result += Arr[i];
        }
        static void Main(string[] args)
        {
            int result;
            SumArr(out result, 1, 2, 3);
            Console.WriteLine("result= " + result);
            SumArr(out result, 1, 2, 3, 4, 5, 6);
            Console.WriteLine("result = " + result);
            Console.ReadKey();
        }*/
        // const int size = 10;
        // static int n = 3;
        // static int [][] M = new int [n][];
        // static void CreateMjag(int[][] M, int n)
        // {
        //     for (int i = 0; i < n; i++)
        //     {
        //         int m = 0;
        //     loop_m:
        //         try
        //         {
        //             Console.Out.Write("m= ");
        //             m = int.Parse(Console.ReadLine());
        //             M[i] = new int[m];
        //             for (int j = 0; j < m; j++)
        //             {
        //                 try
        //                 {
        //                     Console.Write("M[" + i + "][" + j + "]=");
        //                     M[i][j] = int.Parse(Console.ReadLine());
        //                 }
        //                 catch (FormatException) { Console.Out.Write("Invalid data !!!"); j--; }
        //             }
        //         }
        //         catch (FormatException)
        //         {
        //             Console.Out.Write("Invalid data");
        //             i--;
        //         }
        //         if (m == 0) goto loop_m;
        //     }
        // }
        // //------------------------------------------------------------//
        // static void ViewMjag(int[][] M)
        // {
        //     for(int i=0; i<M.GetLength(0); i++){
        //         for (int j = 0; j < M[i].Length; j++)
        //             Console.Write(M[i][j] + " ");
        //         Console.WriteLine();
        //     }
        // }

        // //-----------------------------------------------------------------------//
        // static void ViewMjag_foreach(int[][] M)
        // {
        //     foreach (int[] list in M)
        //     {
        //         foreach (int item in list)
        //             Console.Write(item + " ");
        //         Console.WriteLine();
        //     }
        // }
        // //--------------------------------------------------------------------------//

        //Lưu mảng
        static int n = 0;
        static oNho[] M;
        struct oNho
        {
            int value;
            int cot;
            int hang;
            public oNho(int v, int c, int h)
            {
                this.cot = c;
                this.hang = h;
                this.value = v;
            }
        }
        static void luuMang()
        {
        loop_n:
            try
            {
                Console.Out.Write("Nhap so phan tu co gia tri trong ma tran: ");
                n = int.Parse(Console.ReadLine());
                M = new oNho[n];
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        Console.Write("Nhap gia tri: ");
                        int v = int.Parse(Console.ReadLine());
                        Console.Write("Nhap hang: ");
                        int h = int.Parse(Console.ReadLine());
                        Console.Write("Nhap cot: ");
                        int c = int.Parse(Console.ReadLine());
                        M[j] = new oNho(v,c,h);
                    }
                    catch (FormatException) { Console.Out.Write("Invalid data !!!"); j--; }
                }
            }
            catch (FormatException)
            {
                Console.Out.Write("Invalid data");
            }
            if (n == 0) goto loop_n;
        }


        static void Main(string[] args)
        {
            // CreateMjag(M, n);
            // ViewMjag_foreach(M);
            luuMang();
            Console.ReadKey();
        }
    }
}
