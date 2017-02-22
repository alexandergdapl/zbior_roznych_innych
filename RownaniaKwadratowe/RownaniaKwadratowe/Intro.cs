using System;

namespace RownaniaKwadratowe
{
    class Intro
    {
        protected char potega  {get; } = (char)94;

        public void Introduction()
        {
            Console.WriteLine($"Przykład równania kwadratowego: \n");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"ax{potega}2 + bx + c = 0  ale a! = 0\n");

            Console.ResetColor();
        }
    }
}
