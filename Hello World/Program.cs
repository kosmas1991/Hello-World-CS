using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("To onoma sou einai " + name);
            Console.WriteLine("poso krono eisai?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eisai " + age + " kronwn!!!");
        }
    }
}
