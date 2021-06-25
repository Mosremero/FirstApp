using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Ivan";

            Console.WriteLine(MyName + "\n");

            Console.WriteLine("\t  Привет, мир");
            Console.WriteLine("\t  Мне 32 года");
            Console.WriteLine("\t  My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine((char)35);
            Console.ReadKey();
        }
    }
}
