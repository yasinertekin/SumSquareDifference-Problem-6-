using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            double Karetoplam = 0;
            int ToplamKare = 0;

            for (int i = 0; i < 100; i++)
            {

                sayi++;
                
                //Console.WriteLine(Math.Pow(sayi,2));
                Karetoplam = Karetoplam + Math.Pow(sayi, 2);
                ToplamKare = ToplamKare + sayi;
            }
            //Console.WriteLine(Math.Pow(ToplamKare,2));
            //Console.WriteLine(Karetoplam);

            double sonuc = Math.Pow(ToplamKare,2) - Karetoplam;

            Console.WriteLine(sonuc);
        }
    }
}