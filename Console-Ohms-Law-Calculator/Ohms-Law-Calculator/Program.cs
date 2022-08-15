using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Ohms-Law-Calculator\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";
            string numInput2 = "";
            string numInput3 = "";
            double result = 0;


            Console.Write("Devrenin direnç(R) değerini Giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }


            Console.Write("Devrenin amper(I) değerini Giriniz: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput2 = Console.ReadLine();
            }






            result = cleanNum1 * cleanNum2;
            Console.WriteLine("Devrenin voltaj(V) değeri: " + result);

            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
