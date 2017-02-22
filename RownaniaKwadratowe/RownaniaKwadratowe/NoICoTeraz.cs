using System;

namespace RownaniaKwadratowe
{
    class NoICoTeraz : LiczDelte
    {
        public NoICoTeraz(double a, double b, double c, double wynikDelta)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.wynikDelta = wynikDelta;
        }


        public void deltaWiekszaOdZero()
        {
            double x1, x2;
            double pierwZDelty = Math.Sqrt(wynikDelta);
            x1 = ((-1 * b) - pierwZDelty) / 2 * a;
            x2 = ((-1 * b) + pierwZDelty) / 2 * a;
            Console.WriteLine("\nWynikiem są dwa pierwiastki:\n" +
                              $"x1 = {x1:#.####}  ({x1:#.#})\n" +
                              $"x2 = {x2:#.####}  ({x2:#.#})");
        }

        public void deltaMniejszaOdZero()
        {
            Console.WriteLine("Delta jest mniejsza od 0.\nNie ma pierwiastków dla tego równania.");
        }

        public void deltaZero()
        {
            double x1;
            x1 = (-1 * b) / 2 * a;
            Console.WriteLine("\nWynikiem jest jeden (podwójny) pierwiastek " +
                              $"x1 = {x1:#.####}");
        }


        public void coTeraz()
        {
            //Console.WriteLine("****"+a + b + c);

            if (wynikDelta > 0)
                deltaWiekszaOdZero();

            if (wynikDelta < 0)
                deltaMniejszaOdZero();

            if (wynikDelta == 0)
                deltaZero();
        }

        //public void ddd()
        //{
        //    Console.WriteLine(wynikDelta);
        //}


    }
}
