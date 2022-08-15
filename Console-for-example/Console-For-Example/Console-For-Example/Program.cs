
using System;

namespace ConsoleFindPositiveNegativeNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console-For-Example\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string result = "";

                Console.Write("Kullanıcı İsminizi Giriniz: ");
                result = Console.ReadLine();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(result);
                }

                Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
