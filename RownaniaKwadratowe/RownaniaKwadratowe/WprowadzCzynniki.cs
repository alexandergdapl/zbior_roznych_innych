using System;

namespace RownaniaKwadratowe
{
    class WprowadzCzynniki : IWprowadzCzynniki
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        
        public void OtoCzynniki(double a, double b, double c)
        {

            if (this.a <= 0)
            {
                throw new Exception("a musi być > 0");
            }
            if (this.a == a)
            {
                return;
            }
            //! włączyć spradzanie

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void wprowadzanieCzynnikow() //int a, int b, int c)
        {
            Console.Write("podaj a: ");
            a = double.Parse(Console.ReadLine());
            
            Console.Write("podaj b: ");
            b = double.Parse(Console.ReadLine());
            
            Console.Write("podaj c: ");
            c = double.Parse(Console.ReadLine());
        }

        
    }
}
