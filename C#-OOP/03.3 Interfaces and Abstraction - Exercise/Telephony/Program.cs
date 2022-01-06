using System;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            foreach (var number in phoneNumbers)
            {
                try
                {
                    string result = number.Length == 10
                   ? smartphone.Call(number)
                   : stationaryPhone.Call(number);
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
            foreach (var url in sites)
            {
                try
                {
                    var result=smartphone.Browse(url);
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
