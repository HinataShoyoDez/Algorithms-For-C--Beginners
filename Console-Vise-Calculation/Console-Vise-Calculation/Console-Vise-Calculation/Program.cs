
using System;

namespace FindBigNumber
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
                string numInput2 = "";
                double result = 0;

                Console.Write("Vize notunuzu  Girin: ");
                numInput1 = Console.ReadLine();

                int cleanNum1 = 0;
                while (!int.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput1 = Console.ReadLine();
                }



                Console.Write("Final notunuzu girin: ");
                numInput2 = Console.ReadLine();

                int cleanNum2 = 0;
                while (!int.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput2 = Console.ReadLine();
                }

                 result = ((double)(cleanNum2 * 30) / 100 + (double)(cleanNum1 * 70) / 100);

                if (result<50)
                {
                    Console.WriteLine(result.ToString("0.##") + "Notunuz ortalamanın altında kaldınız");
                }
                else
                {
                    Console.WriteLine(result.ToString("0.##") + "Notunuz ortalamanın üstünge geçtiniz");
                }
                Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}