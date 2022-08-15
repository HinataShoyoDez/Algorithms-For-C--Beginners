using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-Worker-Salary-Calculation\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string Salary = "";
            string Kids = "";
            double result = 0;


            Console.Write("Maaş giriniz: ");
            Salary = Console.ReadLine();

            double cleanSalary = 0;
            while (!double.TryParse(Salary, out cleanSalary))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                Salary = Console.ReadLine();
            }


            Console.Write("Çocuk sayısı giriniz: ");
            Kids = Console.ReadLine();

            int cleankids = 0;
            while (!int.TryParse(Kids, out cleankids))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                Kids = Console.ReadLine();
            }

            if (cleankids==0)
            {
                Console.WriteLine("aldığınız ücret : " + Salary);
            }
            else if (cleankids==1)
            {
               result = cleanSalary + (cleanSalary * 5 / 100);
               Console.WriteLine("aldığınız ücret : " + result);
            }
            else if (cleankids==2)
            {
                result = cleanSalary + (cleanSalary * 10 / 100);
                Console.WriteLine("aldığınız ücret : " + result);
            }
            else if (cleankids>=3)
            {
                result = cleanSalary + (cleanSalary * 15 / 100);
                Console.WriteLine("aldığınız ücret : " + result);
            }


            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}

