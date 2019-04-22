# Лабораторная работа №1
_Подготовил студент группы TI-164, Дрегля Дмитрий_
## Задание 
Целью данной лабораторной работы было имплементировать 5 порождающих шабловнов

## Использованные порождающие шаблоны
1. _Abstract Factory_
2. _Factory Method_
3. _Singleton_
4. _Prototype_
5. _Builder_

## _Abstract Factory_
Абстрактная фабрика — это порождающий паттерн проектирования, который позволяет создавать семейства связанных объектов, не привязываясь к конкретным классам создаваемых объектов.

![alt text](https://refactoring.guru/images/patterns/content/abstract-factory/abstract-factory.png "Logo Title Text 1")

## _Factory Method_
Фабричный метод — это порождающий паттерн проектирования, который определяет общий интерфейс для создания объектов в суперклассе, позволяя подклассам изменять тип создаваемых объектов.

![alt text](https://refactoring.guru/images/patterns/content/factory-method/factory-method.png "Logo Title Text 1")

## _Singleton_
Singleton — это порождающий паттерн проектирования, который гарантирует, что у класса есть только один экземпляр, и предоставляет к нему глобальную точку доступа.

![alt text](https://refactoring.guru/images/patterns/content/singleton/singleton.png "Logo Title Text 1")

## _Prototype_
Prototype - это порождающий паттерн проектирования, который позволяет копировать объекты, не вдаваясь в подробности их реализации.

![alt text](https://refactoring.guru/images/patterns/content/prototype/prototype.png "Logo Title Text 1")

## _Builder_
Builder - это порождающий паттерн проектирования, который позволяет создавать сложные объекты пошагово. Строитель даёт возможность использовать один и тот же код строительства для получения разных представлений объектов.

![alt text](https://refactoring.guru/images/patterns/content/builder/builder.png "Logo Title Text 1")


## Реализация 
Для того, чтобы продемонстрировать реализацию паттернов, я использовал несколько классов в моём проекте :

# Lab1_TMPS_AbstractFactory


Создаем классы, использующиеся в данном проекте : AbstractBottle, AbstractFactory, AbstractWater, Client:

```C#
    public class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + "Interact with" + water);
        }
    }
```	

Создаем абстрактный класс, чтобы получить фабрики для созданных выше классов:

```C#
    public abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
    }
```

Создаем класс - генератор фабрики:

```C#
    public abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractWater CreateWater();
    }
```

Используем класс - генератор фабрик, чтобы получить фабрики конкретных классов

``` C#        
	    Client client = null;
            client = new Client(new CocaColaFactory());
            client.Run();
            client = new Client(new PepsiFactory());
            client.Run();
        Console.ReadKey();
```

Получаем:

```C#
AbstractFactory.ConcreteClass.CocaColaBottleInteract withAbstractFactory.ConcreteClass.CocaColaWater
AbstractFactory.ConcreteClass.PepsiBottleInteract withAbstractFactory.ConcreteClass.PepsiWater

```

# Lab1_TMPS_Prototype

Подобно примеру выше с AbstractFactory создаем класс и наследуем от него классы :

```C#
    class Prototype
    {
        public string Class { get; set; }
        public string State { get; set; }
        public Prototype Clone()
        {
            return MemberwiseClone() as Prototype;
        }
    }
```

И присваиваем классам определенные идентификаторы:

```C#
            Prototype human = prototype.Clone() as Prototype;
            human.Class = "human";
            human.State += " Common signs of a person";
            Console.WriteLine(human.Class + " " + human.State);
```

Затем вызываем базу классов и достаем оттуда объект нужного класса:

```C#
            var adam = human.Clone();
            adam.State = "Adam";
            Console.WriteLine(adam.State+" "+ adam.Class);
```

В результате получим вывод : 

```C#
human  Common signs of a person
Adam human
```

# Lab1_TMPS Builder + Factory method

Создаем модель данных машина , в которой может быть : Мультимедиа система , колёса , двигатель , кузов , степень роскошности , система безопасности при аварии.

```C#
    abstract class CarBuilderBase
    {
        protected Car Car;

        protected CarBuilderBase()
        {
            Car = new Car();
        }

        public Car GetCar()
        {
            return Car;
        }

        public abstract void BuildMultimedia();
        public abstract void BuildWheels();
        public abstract void BuildEngine();
        public abstract void BuildFrames();
        public abstract void BuildLuxury();
        public abstract void BuildSafety();
    }
```

Информация добавляется следующим образом:

```C#
    class Car
    {
        public string Engine { get; set; }
        public string Frame { get; set; }
        public string Wheels { get; set; }
        public string Luxury { get; set; }
        public string Multimedia { get; set; }
        public string Safety { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Frame: {0}\n", Frame);
            sb.AppendFormat("Engine: {0}\n", Engine);
            sb.AppendFormat("Wheels: {0}\n", Wheels);
            sb.AppendFormat("Multimedia: {0}\n", Multimedia);
            sb.AppendFormat("Safety: {0}\n", Safety);
            sb.AppendFormat("Luxury: {0}\n", Luxury);

            return sb.ToString();
        }
    }
```

При сборке данные для каждой марки машины берутся из соответствующих классов AudiBuilder и VolkswagenBuilder которые наследуются от главного класа строителя:

```C#
class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder() : base()
        {
        }

        public override void BuildMultimedia()
        {
            Car.Multimedia = "Audi MMI Multimedia";
        }

        public override void BuildWheels()
        {
            Car.Wheels += " 18\" Audi Wheel";
        }

        public override void BuildEngine()
        {
            Car.Engine = "2.0 TFSI";
        }

        public override void BuildFrames()
        {
            Car.Frame = "Audi frame";
        }

        public override void BuildLuxury()
        {
            Car.Luxury = "Audi Exclusive Interior";
        }

        public override void BuildSafety()
        {
            Car.Safety = "Side Assist";
        }
    }
```

Однако возможно такая ситуация что машину изначально нужно собрать по самой дешёвой комплектации, а уже после добавить какие-нибудь вещи, для этого будем использовать паттерн Factory, создадим класс CarFactoryBase

```C#
    abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase CarBuilder;

        protected CarFactoryBase(CarBuilderBase builder)
        {
            CarBuilder = builder;
        }

        public abstract Car Construct();
    }
```

Сделаем две возможных сборки машины дешёвую(cheap) и максимальную(luxury):
Примеру классов максимальной и минимальной комплектации :

```C#
    class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder) : base(builder)
        {
        }

        public override Car Construct()
        {
            CarBuilder.BuildFrames();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();
            CarBuilder.BuildMultimedia();
            CarBuilder.BuildLuxury();

            return CarBuilder.GetCar();
        }
    }
```

```C#
    class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder) : base(builder)
        {
        }

        public override Car Construct()
        {
            CarBuilder.BuildFrames();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();

            return CarBuilder.GetCar();
        }
    }
```
Вызывать методы сборки машины будем следующим образом, сначало соберём минимальную сборку а после этого добавим к примеру Multimedia и Luxury пакет: 

```C#
            Console.WriteLine("Cheap Volkswagen:");
            CarFactoryBase constructor = new CheapCarFactory(new VolkswagenBuilder());
            var car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury Volkswagen:");
            constructor = new LuxuryCarFactory(new VolkswagenBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);
```

#Lab1_TMPS_Singleton

SingleObject класс будет иметь свой статичный экземпляр и приватный конструктор. В этом классе есть статичный метод, чтобы получить этот экземпляр. Для проверки создадим два экземпляра этого класса и если он реализован правильно то полученная ХЭШ-сумма должна быть одинакова

```C#
    public sealed class Hash
    {
       private static Hash bellConnection;
        private Hash ()
        {
        }
        public static Hash Instance()
        {
            if (bellConnection == null)
            {
                bellConnection = new Hash();
            }

            return bellConnection;
        }

```

Создадим два экземпляра и сверим ХЭШ-сумму: 
```C#
        static void Main(string[] args)
        {

            Hash s1 = Hash.Instance();
            Hash s2 = Hash.Instance();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            Console.ReadKey();
        }
```
Хэш сумма совпала.


## Вывод
В ходе данной лабораторной работы мы изучили и реализовали порождающие паттерны, они упрощают структурный код программы и помогают избежать нежелательных последствий в работе программного продукта.
