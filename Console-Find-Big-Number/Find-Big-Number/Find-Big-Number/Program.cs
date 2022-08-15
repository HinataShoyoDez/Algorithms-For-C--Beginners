
using System;

namespace FindBigNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool endApp = false;
           
            Console.WriteLine("Console-Find-Big-Number\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                
                string numInput1 = "";
                string numInput2 = "";
                int result = 0;

                Console.Write("Birinci Sayıyı Girin: ");
                numInput1 = Console.ReadLine();

                int cleanNum1 = 0;
                while (!int.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput1 = Console.ReadLine();
                }

                
                
                Console.Write("İkinci Sayıyı Girin: ");
                numInput2 = Console.ReadLine();

                int cleanNum2 = 0;
                while (!int.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput2 = Console.ReadLine();
                }

                if (cleanNum1<cleanNum2)
                {
                    Console.WriteLine("Girdiğiniz ikinci sayı büyüktür");
                }
                else if (cleanNum1==cleanNum2)
                {
                    Console.WriteLine("Girdiğiniz sayılar Eşittir");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz birinci sayı büyüktür");
                }

                Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}