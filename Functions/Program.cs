using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta oma vanus.");
            int userAge = Convert.ToInt32(Console.ReadLine());
            SayHello(username,userAge);
        }

    private static void SayHello(string somename, int someNumber)
        {
            Console.WriteLine($"Hi There! {somename}");
            Console.WriteLine($"Oled sündinud aastal {2021 - someNumber}.");
        }


    }
}
