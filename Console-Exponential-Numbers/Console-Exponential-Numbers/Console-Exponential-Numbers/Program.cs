
using System;

    class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console-Exponential-Numbers\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string numInput1 = "";
                string numInput2 = "";
                int result = 1;

                Console.Write("Alt sayıyı Girin: ");
                numInput1 = Console.ReadLine();

                int cleanNum1 = 0;
                while (!int.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput1 = Console.ReadLine();
                }



                Console.Write("Üstü girin: ");
                numInput2 = Console.ReadLine();

                int cleanNum2 = 0;
                while (!int.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Girdiğiniz sayı tam sayı değil: ");
                    numInput2 = Console.ReadLine();
                }

               for (int i = 1; i <= cleanNum2; i++)
               {
                result = result * cleanNum1;
               }

            Console.WriteLine(result);
                Console.ReadKey();
                Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }

