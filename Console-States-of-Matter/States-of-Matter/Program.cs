using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-States-of-Matter\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";

            Console.Write("Öğrenmek istediğiniz Değeri Giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }

            if (cleanNum1>0 && cleanNum1 < 100)
            {
                Console.WriteLine("Girdiğiniz değere göre madde sıvıdır");
            }
            else if (cleanNum1<=0)
            {
                Console.WriteLine("Girdiğiniz değere göre madde katıdır");
            }
            else
            {
                Console.WriteLine("Girdiğiniz değere göre madde gazdır");
            }


            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
