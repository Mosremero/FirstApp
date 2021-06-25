using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Ivan";
            byte age = 33;
            bool have_pet = true;
            double myFootSize = 44;

            Console.WriteLine("My name is {0}", myName);
            Console.WriteLine("MyAge is {0}", age);
            Console.WriteLine("Do i have a pet? {0}", have_pet);
            Console.WriteLine("My shoe size is {0}", myFootSize);
        }
    }
}
