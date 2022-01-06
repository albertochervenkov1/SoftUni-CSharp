using System;

namespace tailoringWorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectab = int.Parse(Console.ReadLine());
            double wrectabm = double.Parse(Console.ReadLine());//dulzhina
            double hrectabm = double.Parse(Console.ReadLine());//chirichina

            double totareapok = rectab * (wrectabm + 2 * 0.30) * (hrectabm + 2 * 0.30);
            double totareakare = rectab * (wrectabm / 2) * (wrectabm/ 2);

            double pusd = totareapok * 7 + totareakare * 9;
            double pbgn = pusd * 1.85;

            Console.WriteLine($"{pusd:F2} USD");
            Console.WriteLine($"{pbgn:F2} BGN");

        }
    }
}
