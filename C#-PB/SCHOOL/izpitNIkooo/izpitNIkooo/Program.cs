using System;

namespace izpitNIkooo
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = -5;
            int j = 5;
            int c = 0;
            int n = 5;
            for (int i = 3; i < 12; i+=3)
            {
                n += i;
                c++;
            }


            Console.WriteLine(c);
            //Console.WriteLine(j);
            //Console.WriteLine(c);

        }
    }
}
