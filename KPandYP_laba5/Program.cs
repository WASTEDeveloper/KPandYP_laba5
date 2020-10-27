using System;

namespace KPandYP_laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box korobka = new Box();

            korobka.Width = double.Parse(Console.ReadLine());
            korobka.Height = double.Parse(Console.ReadLine());
            korobka.Depth = double.Parse(Console.ReadLine());

            korobka.Square();
            korobka.Volume();
            korobka.Diagonal();
            korobka.CheckVolume();
        }
    }
}
