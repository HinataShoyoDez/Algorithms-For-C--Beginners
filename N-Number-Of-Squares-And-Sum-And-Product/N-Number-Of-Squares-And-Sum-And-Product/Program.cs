using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-N-Number-Of-Squares-And-Sum-And-Product\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";
            
            double result = 0;
            double result2 = 1;
            double result3= 1;
            Console.Write("Sayıyı Giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }

            for (int i = 1; i <= cleanNum1; i++)
            {
                if (i%2==1)
                {
                    result += i;
                    result2 *= i;
                }
                else
                {
                    result3 *= i;
                }
                
            }
            Console.WriteLine("Tek sayıların toplamı : " + result);
            Console.WriteLine("Tek sayıların Çarpımı : " + result2);
            Console.WriteLine("Çift sayıların çarpımı : " + result3);

            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
