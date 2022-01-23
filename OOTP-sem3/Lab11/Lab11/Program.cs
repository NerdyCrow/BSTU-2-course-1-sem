using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab11
{
    class Car
    {
        public int id;
        public string brand;
        public string model;
        public ushort year;
        public string color;
        public int price;
        public string number;


        public Car(int id, string brand, string model, ushort year, string color, int price, string number)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
            this.number = number;
        }

        public override string ToString()
        {
            return $"ID: {this.id}\n" +
                $"Бренд: {this.brand}\n" +
                $"Модель: {this.model}\n" +
                $"Год выпуска: {this.year}\n" +
                $"Цвет: {this.color}\n" +
                $"Цена: {this.price}$\n" +
                $"Номер машины: {this.number}\n";
        }

    }
    class Person
    {
        public string Name { get; set; }
        public Car Car { get; set; }

        public Person(string Name, Car Car)
        {
            this.Name = Name;
            this.Car = Car;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] ss = new string[] { "Январь","Февраль","Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь","Декабрь" };


            var selIt = (from i in ss where i.Contains("И")||(i.Contains("и")) && (i.Length >= 4) select i).Count();
            var selIt1_2 = ss.Count(i=>i.Contains("И")|| (i.Contains("и")) && (i.Length >= 4));
            Console.Write("Количество месяцев,содержащих букву 'и/И':");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(selIt+"|"+selIt1_2);
            Console.ForegroundColor = ConsoleColor.White;


            
            var selIt2 = (from i in ss where i.Contains("Июль") || i.Contains("Июнь") || i.Contains("Декабрь") || i.Contains("Январь") || i.Contains("Февраль") || i.Contains("Август")select i);
            
            
            Console.Write("Только зимние и летние месяца:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var elem in selIt2)
            {
                Console.Write(" " + elem);

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            var selIt3 = ss.OrderBy(t=>t);
            Console.Write("Алфавитный порядок:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var elem in selIt3)
            {
                Console.Write(" " + elem);

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            var selIt4 = ss.Where(n => n.Length == 4);
            Console.Write("Длина равна 4:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var elem in selIt4)
            {
                Console.Write(" " + elem);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("##########################################################################################");

            List<Car> cars = new List<Car>();
            cars.Add(new Car(65, "BMW", "M4C", 2020, "Red", 125000, "6531-3"));
            cars.Add(new Car(42, "Porche", "Taycan", 2017, "White", 140000, "3215-12"));
            cars.Add(new Car(88, "Audi", "RS6", 2016, "Silver", 100000, "8672-5"));
            cars.Add(new Car(25, "Reno", "Duster", 2013, "Red", 15000, "M948-23F"));
            cars.Add(new Car(133,"Lamborgini","URUS",2018,"Black",400000,"DASD-23V"));
            cars.Add(new Car(12, "Porshe", "Panamera", 2017, "Gold", 150000, "ASD-23V"));
            cars.Add(new Car(65, "BMW", "M8C", 2017, "Red", 75000, "6531-3"));


            var c1 = cars.Where(x => x.brand == "BMW");
            var c2 = cars.Where(x => x.model == "Taycan" && (2021 - x.year) >= 3);
            var c3 = cars.Count(x => x.color == "Red" && x.price >= 15000&&x.price<=100000);
            var c4 = cars.OrderByDescending(x => x.year).TakeLast(1);
            var c5 = cars.OrderByDescending(x => x.year).Take(5);
            var c6 = cars.OrderByDescending(x => x.price).Select(x => x.price) ;

            Console.WriteLine("------------All BMW's-------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var i in c1)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------Cписок автомобилей заданной модели, которые эксплуатируются больше n лет; -------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var i in c2)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------количество автомобильной заданного цвета(Red) и диапазона цены(15 000<price<100 000)-------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(c3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("-----------самый старый автомобиль--------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var i in c4)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------первых пять самых новых автомобилей-------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var i in c5)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------упорядоченный массив по цене--------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var i in c6)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;

            var five = cars.Where(p => p.price > 185000)
                .Where(b => b.brand == "Porsche")
                .OrderBy(m => m.model)
                .Where(c => c.color == "Red")
                .Select(x => x);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var i in five)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;
            Person p1 = new Person("Vika", cars[1]);
            Person p2 = new Person("Vitya", cars[3]);
            Person p3 = new Person("Dima", cars[0]);
            Person p4 = new Person("Makar", cars[6]);
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };
            var last = people.Join(cars,p => p.Car,c => c,(p, c) => new { Name = p.Name, Brand = c.brand, Model = c.model });
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var i in last)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
