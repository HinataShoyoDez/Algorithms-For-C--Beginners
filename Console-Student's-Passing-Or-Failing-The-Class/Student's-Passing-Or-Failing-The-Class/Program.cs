using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-Student's-Passing-Or-Failing-The-Class\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";
           
        


            Console.Write("Öğrencinin Notunu  Giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }

            if (cleanNum1<50)
            {
                Console.WriteLine("Öğrencinin notu 50 ortalamanın altında olduğu için kalmıştır aldığı not : " + cleanNum1);
            }
            else
            {
                Console.WriteLine("Öğrencinin notu 50 ortalamanın üstünde olduğu için geçmiştir aldığı not : " + cleanNum1);
            }
            
            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
