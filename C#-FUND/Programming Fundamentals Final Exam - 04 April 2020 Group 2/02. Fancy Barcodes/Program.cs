using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            Regex regex = new Regex(pattern);
            bool enter = false;

            for (int i = 0; i < n; i++)
            {
                string barcodeInput = Console.ReadLine();
                Match match=regex.Match(barcodeInput);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string barcode = match.Groups["barcode"].Value;
                StringBuilder group = new StringBuilder();

                for (int j = 0; j < barcode.Length; j++)
                {
                    if (Char.IsDigit(barcode[j]))
                    {
                        group.Append(barcode[j]);
                        enter = true;
                    }
                    
                }
                if (String.IsNullOrEmpty(group.ToString()))
                {
                    group.Append("00");
                }
                Console.WriteLine($"Product group: {group}");
               
            }
        }
    }
}
