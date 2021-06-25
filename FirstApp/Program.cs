using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaphore greenCode = Semaphore.Green;
            Console.WriteLine(greenCode);
            Console.ReadKey();
        }
    }

    enum Semaphore : ushort
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}
