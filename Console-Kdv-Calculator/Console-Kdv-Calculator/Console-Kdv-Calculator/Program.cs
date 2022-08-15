
using System;

namespace FindBigNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console-Kdv-Calculation\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string numInput1 = "";
                
                double result = 0;

                Console.Write("Ürünün Fiyatını Giriniz: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput1 = Console.ReadLine();
                }




                double KdvCalculator = (cleanNum1 * 18) / 100;


                result = cleanNum1 + KdvCalculator;

                Console.WriteLine(result);

                Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}