//Вариант 9. Используя паттерн "Абстрактная фабрика",
//реализовать проект "Заводы по производству автомобилей".
//В проекте должна быть реализована возможность создавать
//автомобили различных типов на разных заводах.

namespace AbstractFactoryPattern;
class Program
{
    public static void Main(string[] args)
    {
        Client client = new Client(new Factory1());
        Console.WriteLine(client.ProvideCar());
        client.factory = new Factory2();
        Console.WriteLine(client.ProvideCar());
    }
}