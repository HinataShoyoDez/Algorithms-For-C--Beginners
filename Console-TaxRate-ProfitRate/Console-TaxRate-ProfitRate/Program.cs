using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-TaxRate-ProfitRate\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";
            string numInput2 = "";
            string numInput3 = "";
            double result = 0;


            Console.Write("Ürünün Alış Tutarını Giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }


            Console.Write("Vergi Oranını Giriniz: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput2 = Console.ReadLine();
            }



            Console.Write("Kar Oranını Giriniz: ");
            numInput3 = Console.ReadLine();

            double cleanNum3 = 0;
            while (!double.TryParse(numInput3, out cleanNum3))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput3 = Console.ReadLine();
            }

        
            result = cleanNum1 + (cleanNum1 * cleanNum2 / 100) + (cleanNum1 * cleanNum3 / 100);
            Console.WriteLine(result);

            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
