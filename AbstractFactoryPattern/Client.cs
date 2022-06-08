//Вариант 9. Используя паттерн "Абстрактная фабрика",
//реализовать проект "Заводы по производству автомобилей".
//В проекте должна быть реализована возможность создавать
//автомобили различных типов на разных заводах.

namespace AbstractFactoryPattern
{
    internal class Client
    {
        public IFactory factory;
        public Client(IFactory abstractFactory)
        {
            factory = abstractFactory;
        }

        public Car ProvideCar()
        {
            return new Car(factory.CreateCarColor(),factory.CreateEngine());
        }
    }
}