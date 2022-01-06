using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            List<string> towndata = firstTupleData.ToList().Skip(3).ToList();
            string town = string.Join(" ", towndata);
            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(fullName, firstTupleData[2], town);

            string[] secondTupleData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool isDrunk = secondTupleData[2] == "drunk" ? true : false;
            
            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>(secondTupleData[0], int.Parse(secondTupleData[1]),isDrunk);

            string[] threeTupleData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            List<string> bankData = threeTupleData.ToList().Skip(1).ToList();
            string bankName = string.Join(" ", towndata);
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(threeTupleData[0], double.Parse(threeTupleData[1]), threeTupleData[2]);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
            


        }
    }
}
