// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleFindPositiveNegativeNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console-Vise-Calculation\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string numInput1 = "";

                double result = 0;

                Console.Write("Değer  Giriniz: ");
                numInput1 = Console.ReadLine();

                int cleanNum1 = 0;
                while (!int.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput1 = Console.ReadLine();
                }

                if (cleanNum1 < 0)
                {
                    Console.WriteLine("Girdiğiniz değer negatiftir");
                }
                else if (cleanNum1 == 0)
                {
                    Console.WriteLine("Girdiğiniz sayı sıfıra eşittir");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı pozitiftir");
                }

                Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}