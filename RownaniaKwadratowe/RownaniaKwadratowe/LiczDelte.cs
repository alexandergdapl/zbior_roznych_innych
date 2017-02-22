using System;

namespace RownaniaKwadratowe
{
    internal class LiczDelte : WprowadzCzynniki, IPokazDelte
    {
        //inicjuję zmienną zanim ją zwrócę w metodzie jako wynik wyliczeń
        public double wynikDelta;
        public double Delta()
        {
            //przed wyliczeniem delty wywołuję wprowadzenie czynników
            //przeniosłem jednak do Program.cs tę metodę 
            //dla czytelności kolejności jako delta.wprowadzanieCzynnikow()
            
            //wprowadzanieCzynnikow();
            
            wynikDelta = b*b - (4*a*c);
            return wynikDelta;
        }

        public void pokazDelte()
        {
            Console.WriteLine($"Delta wynosi: {wynikDelta:#.####}");
        }
    }
}
