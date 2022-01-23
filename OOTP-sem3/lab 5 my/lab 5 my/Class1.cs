using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5_my
{
    class Printer
    {
        public void IAmPrinting(Controle obj)
        {
            Console.WriteLine($"\nТип: {obj.ToString()}");
        }
    }

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
        public override void square() { Console.WriteLine($"Площадь прямоугольника: {weight*height}"); }
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
    class triangle : figure
    {
       public enum Type
        {
            rs,
            pu,
            rb
        }

        public Info[] infos;
        public struct Info
        {
            public int h ;
            private Type tp;

            public int _h
            {
                get => h;
                set => h = value;
            }
            public Type _tp
            {
                get => tp;
                set => tp = value;
            }
           
        }
        public override void ShowSizes()
        {
            Console.WriteLine($"высота:{2}");
        }
        public override void square() { Console.WriteLine($"Площадь круга: {3.14f * 15 * 2}"); }
        public triangle() 
        {
            infos = new Info[3];
            infos[0]._tp = Type.rb;
            infos[0].h = 15;
            infos[1]._tp = Type.rs;
            infos[1].h = 20;
            infos[2]._tp = Type.pu;
            infos[2].h = 10;
        }


    }


    public abstract class Controle
    {
        public override string ToString()
        {
            return GetType().Name;
        }
        public abstract void Print();
    }

    sealed class button : Controle,IControle {

        public override void Print()
        {
            Console.Write($"использовал абстрактный класс: {ToString()}");
        }
        void IControle.Print()
        {
            Console.Write($"\nиспользовал интерфейс: {ToString()}");
        }
    }
    sealed class textbox : Controle, IControle
    {

        public override void Print()
        {
            Console.Write($"использовал абстрактный класс: {ToString()}");
        }
        void IControle.Print()
        {
            Console.Write($"\nиспользовал интерфейс: {ToString()}");
        }
    }

}
