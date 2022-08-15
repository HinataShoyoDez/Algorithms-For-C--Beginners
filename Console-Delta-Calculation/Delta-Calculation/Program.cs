using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-Delta-Calculation\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";
            string numInput2 = "";
            string numInput3 = "";
            double result = 0;
            int delta = 0;


            Console.Write("A değerini Giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }


            Console.Write("B değerini Giriniz: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput2 = Console.ReadLine();
            }



            Console.Write("C değerini Giriniz: ");
            numInput3 = Console.ReadLine();

            double cleanNum3 = 0;
            while (!double.TryParse(numInput3, out cleanNum3))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput3 = Console.ReadLine();
            }

            delta = (int)(cleanNum2 * cleanNum2) - (int)(4 * cleanNum1 * cleanNum3);
            if (delta==0)
            {
                Console.WriteLine("çakışık iki tane kökü vardır");
            }
            else if (delta<0)
            {
                Console.WriteLine("Reel kök yok");
            }
            else
            {
                Console.WriteLine("Reel İki tane kökü vardır");
            }

            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
