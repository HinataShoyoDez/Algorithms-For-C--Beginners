using System;

namespace FindBigNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console-Number-Addition-Average\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {


                string numInput1 = "";
                string numInput2 = "";
                string numInput3 = "";
                string numInput4 = "";
                string numInput5 = "";

                double result = 0;

                Console.Write("Birinci Sayıyı  Girin: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput1 = Console.ReadLine();
                }



                Console.Write("İkinci notunuzu girin: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput2 = Console.ReadLine();
                }



                Console.Write("Üçünçü notunuzu girin: ");
                numInput3 = Console.ReadLine();

                double cleanNum3 = 0;
                while (!double.TryParse(numInput3, out cleanNum3))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput3 = Console.ReadLine();
                }




                Console.Write("Dördüncü notunuzu girin: ");
                numInput4 = Console.ReadLine();

                double cleanNum4 = 0;
                while (!double.TryParse(numInput4, out cleanNum4))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput4 = Console.ReadLine();
                }




                Console.Write("Beşinci notunuzu girin: ");
                numInput5 = Console.ReadLine();

                double cleanNum5 = 0;
                while (!double.TryParse(numInput5, out cleanNum5))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput5 = Console.ReadLine();
                }

                double ResultAddition = (cleanNum1 + cleanNum2 + cleanNum3 + cleanNum4 + cleanNum5);
                double ResultAverage = (ResultAddition / 5);

                Console.WriteLine("Girdiğiniz Sayıların Toplamı" + ResultAddition);
                Console.WriteLine("Girdiğiniz Sayıların Ortalaması" + ResultAverage);

                Console.ReadKey();
                Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}