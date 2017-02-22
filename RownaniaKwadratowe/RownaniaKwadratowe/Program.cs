using System;

namespace RownaniaKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //  informacja
            Intro rozpocznij = new Intro();
            rozpocznij.Introduction();

            //  pokazuję wzór na deltę
            DeltaInfo wzorDelta = new DeltaInfo();
            wzorDelta.deltaInfo();
            
            //WprowadzCzynniki czynniki = new WprowadzCzynniki();
            //czynniki.wprowadzanieCzynnikow();
            
            LiczDelte delta = new LiczDelte();
            //najpierw ładuję czynniki do klasy, w której liczę deltę
            delta.wprowadzanieCzynnikow();
            //teraz liczę deltę
            delta.Delta();
            
            delta.pokazDelte();

            //przekazuję argumenty a, b, c, delta
            NoICoTeraz koniec = new NoICoTeraz(Convert.ToInt32(delta.a), Convert.ToInt32(delta.b), Convert.ToInt32(delta.c), Convert.ToInt32(delta.wynikDelta));
            koniec.coTeraz();
            delta.Delta();
            
   

            Console.ReadKey();
        }
    }
}
