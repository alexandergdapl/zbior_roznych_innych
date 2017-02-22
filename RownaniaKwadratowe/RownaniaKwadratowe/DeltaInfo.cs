using System;

namespace RownaniaKwadratowe
{
    class DeltaInfo : Intro
    {
        public void deltaInfo()
        {
            Console.WriteLine("Wzór na Deltę:\n");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"b{potega}2 - 4ac\n");

            Console.ResetColor();
        }
    }
}
