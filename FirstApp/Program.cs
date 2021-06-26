using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут: ");
            var name = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            var age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ваше имя {0} и ваш возраст {1}", name, age);
            Console.Write("Введите вашу дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.Write("Ваша дата рождения {0}", birthdate);

        }
    }
}
