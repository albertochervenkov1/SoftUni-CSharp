using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string products = "";            
            double coinscounter = 0;
           

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);


                if (coins == 0.1)
                {
                    coinscounter += coins;
                }
                else if (coins==0.2)
                {
                    coinscounter += coins;
                }
                else if (coins==0.5)
                {
                    coinscounter += coins;
                }
                else if (coins==1)
                {
                    coinscounter += coins;
                }
                else if (coins==2)
                {
                    coinscounter += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                

            }

            
            while (products!="End")
            {
                products = Console.ReadLine();
                if (products!="Nuts"&&products!="Water"&&products!="Crisps"&&products!="Soda"&&products!="Coke"&&products!="End")
                {
                    Console.WriteLine("Invalid product");
                }
                if (products=="Nuts")
                {
                   // productPrice = 2.0;
                    
                    if (coinscounter<2.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    Console.WriteLine($"Purchased {products.ToLower()}");
                    coinscounter -= 2.0;
                }
                else if (products=="Water")
                {
                    //productPrice = 0.7;
                    
                    
                    if (coinscounter <0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    Console.WriteLine($"Purchased {products.ToLower()}");
                    coinscounter -= 0.7;
                }
                else if (products=="Crisps")
                {
                    //productPrice = 1.5;
                    
                    if (coinscounter <1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    Console.WriteLine($"Purchased {products.ToLower()}");
                    coinscounter -= 1.5;
                }
                else if (products=="Soda")
                {
                    //productPrice = 0.8;
                    
                    
                    if (coinscounter <0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    Console.WriteLine($"Purchased {products.ToLower()}");
                    coinscounter -= 0.8;
                }
                else if (products=="Coke")
                {
                    //productPrice = 1.0;
                   
                    
                    if (coinscounter < 1.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    Console.WriteLine($"Purchased {products.ToLower()}");
                    coinscounter -= 1.0;
                }
            }
            Console.WriteLine($"Change: {coinscounter:F2}");
        }
    }
}
