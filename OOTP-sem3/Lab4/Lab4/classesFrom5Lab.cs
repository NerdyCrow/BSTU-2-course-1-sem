using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public abstract class figure
    {
        public abstract void square();
        public abstract void ShowSizes();
        public override string ToString()
        {
            return GetType().Name;
        }

    }

    class rectangle : figure
    {
        private int weight = 20;
        private int height = 10;
        public override void square() { Console.WriteLine($"Площадь прямоугольника: {weight * height}"); }
        public override void ShowSizes()
        {
            Console.WriteLine($"Ширина равна:{weight}\nВысота равна:{height}");
        }


    }
    class circle : figure
    {
        private int R = 20;

        public override void ShowSizes()
        {
            Console.WriteLine($"Радиус равен:{R}");
        }
        public override void square() { Console.WriteLine($"Площадь круга: {3.14f * R * R}"); }


    }
}
