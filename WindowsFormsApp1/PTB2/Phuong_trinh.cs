using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB2
{
    class Phuong_trinh
    {
        private double a;
        private double b;
        private double c;
        private double x1;
        private double x2;
        private double x;
        private double delta;
        //-----------------------------------------
        public Phuong_trinh(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //----------------------------
        public double X
        {
            get { return this.x; }
        }
        public double Delta
        {
            get { return this.delta; }
        }
        public double X1
        {
            get { return this.x1; }
        }
        public double X2
        {
            get { return this.x2; }
        }
        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public double B
        {
            get { return this.b; }
            set { this.b = value; }

        }
        public double C
        {
            get { return this.c; }
            set { this.c = value; }
        }
        //---------------------------------
        public int giai_Pt()
        {
            if (this.a == 0)
                if (this.b == 0)
                    if (this.c == 0) return 0;
                    else return 1;
                else
                {
                    this.x = -this.c / this.b;
                    return 2;
                }
            else
            {
                double delta;
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    this.delta = Math.Sqrt(-delta);
                    return 3;
                }
                else
                    if (delta == 0)
                {
                    this.x1 = this.x2 = -this.b / (2 * this.a);
                    return 4;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return 5;
                }
            }
        }
    }
}
