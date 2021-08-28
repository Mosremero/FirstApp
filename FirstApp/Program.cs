using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.Write("Как вас зовут: ");
            anketa.name = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            anketa.age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ваше имя {0} и ваш возраст {1}", anketa.name, anketa.age);
            Console.Write("Введите вашу дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.Write("Ваша дата рождения {0}", birthdate);

        }
    }
}
