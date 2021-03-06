//Вариант 9. Используя паттерн "Абстрактная фабрика",
//реализовать проект "Заводы по производству автомобилей".
//В проекте должна быть реализована возможность создавать
//автомобили различных типов на разных заводах.

namespace AbstractFactoryPattern
{
    public interface IFactory
    {
        public ICarColor CreateCarColor();

        public IEngine CreateEngine();

    }
}