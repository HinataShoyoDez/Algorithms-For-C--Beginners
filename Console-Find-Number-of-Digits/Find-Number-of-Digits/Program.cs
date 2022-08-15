using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-Find-Number-of-Digits\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";
          
            double result = 0;


            Console.Write("Basamak sayısını öğrenmek için sayıyı giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }
           
            if ((cleanNum1 >= 0 && cleanNum1 <= 9))
            {
                Console.WriteLine("Sayı bir basamaklı");
            }
            else if (cleanNum1 >= 10 && cleanNum1 <= 99)
            {
                Console.WriteLine("Sayı iki basamaklı");
            }
            else if (cleanNum1 >= 100 && cleanNum1 <= 999)
            {
                Console.WriteLine("Sayı üç basamaklı");
            }
            else if (cleanNum1 >= 1000 && cleanNum1 <= 9999)
            {
                Console.WriteLine("Sayı dört basamaklı");
            }
            else if (cleanNum1 >= 10000 && cleanNum1 <= 99999)
            {
                Console.WriteLine("Sayı beş basamaklı");
            }
           

            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
