using System;

namespace Class
{
    class Program
    {
        public class PointP
        {
            private double x;
            private double y;
            public PointP()
            {
                this.x = 0;
                this.y = 0;
            }
            //-------------------------------
            public PointP(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            ~PointP()
            {
                this.x = 0;
                this.y = 0;
            }
            public virtual double X
            {
                get { return this.x; }
                set { this.x = value; }
            }
            public virtual double Y
            {
                get { return this.y; }
                set { this.y = 0; }
            }
            public void View()
            {
                Console.WriteLine("x:{0}  \ny:{1}", this.x, this.y);
            }
        }
        static PointP p = new PointP(4, 5);
        //----------------------------------
        class Cycle : PointP
        {
            private double r;
            public Cycle(double x, double y, double r)
                : base(x, y)
            {
                this.r = r;
            }
            public override double X
            {
                get{return this.X;}
                set{ base.X = value;}
            }
            public override double Y
            {
                get{ return this.Y;}
                set{ base.Y = value;}
            }
            //------------------------------
            public double Circumference()
            {
                return 2 * r * Math.PI;
            }
            //------------------------------
            public double Area()
            {
                return Math.Pow(r, 2) * Math.PI;
            }
            //------------------------------
            public new void View()
            {
                base.View();
                Console.Out.Write("r:{0}\n", this.r);
            }
            //------------------------------
            public double Line()
            {
                return Math.Sqrt(Math.Pow(base.X, 2) + Math.Pow(base.Y, 2));
            }
            //------------------------------
            public void Move(int new_x, int new_y)
            {
                base.X = new_x;
                base.Y = new_y;
            }
        }
        //----------------------------------
        public static void Input(ref double x, ref double y)
        {
            try
            {
                Console.Write("To input x: ");
                x = double.Parse(Console.ReadLine());
            }
            catch(Exception e){Console.WriteLine(e);}
            try
            {
                Console.Write("To input y: ");
                y = double.Parse(Console.ReadLine());
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        //----------------------------------
        static void Main(string[] args)
        {
            double x = 0, y = 0, r = 0;
            Console.WriteLine("To input co-ordinate:");
            Input(ref x, ref y);
            try
            {
                do
                {
                    Console.Write("To input r: ");
                    r = double.Parse(Console.ReadLine());
                } while (r < 0);
            }
            catch (Exception e) { Console.WriteLine(e); }
            Cycle c = new Cycle(x, y, r);
            c.View();
            Console.Write("Chu vi: {0:F3}\nDien tich: {1:F3}\nKhoang cach tam giac den goc toa do: {2:F3}\n",c.Circumference(),c.Area(),c.Line());
            Console.ReadKey();
        }
    }
}
