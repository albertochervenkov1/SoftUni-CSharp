using System;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command!="Done")
            {
                if (command.Contains("TakeOdd"))
                {
                    string newRawPassword = "";
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        newRawPassword += password[i];
                    }
                    password = newRawPassword;
                    Console.WriteLine(password);
                }
                else if (command.Contains("Cut"))
                {
                    string[] splittedCommand = command.Split();
                    int index = int.Parse(splittedCommand[1]);
                    int length = int.Parse(splittedCommand[2]);
                    password=password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (command.Contains("Substitute"))
                {
                    string[] splittedCommand = command.Split();
                    var substring = splittedCommand[1];
                    var substitute = splittedCommand[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");

        }
    }
}
