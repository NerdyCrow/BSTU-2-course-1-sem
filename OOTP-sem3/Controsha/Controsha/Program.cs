using System;

namespace Controsha
{
    public sealed class Button:IEvent,IAction
    {
        public int weight;
        public int height;
       


        public static string color="red";

        public int _weigth
        {
            get => weight;
            set => weight = value;
        }
        public int _height
        {
            get => height;
            set => height = value;
        }
        public Button(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }
     
        
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Button m = obj as Button;           // возвращает null если объект нельзя привести к типу Money
            if (m as Button == null)
                return false;

            return m.height==this.height;
        }
    }
    

    public static class rashir
    {
        public static int square(this Button bt)
        {
            int square;
            square = bt.height*bt.weight;
            return square;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            /*ulong max = ulong.MaxValue;
            Console.WriteLine(max);
            string a = "asdfnmogf";
            int i = a.IndexOf("o");
            Console.WriteLine(i);*/


            ////Задание 2
            Button b1 = new Button(25,42);
            Button b2 = new Button(55, 42);
          Console.WriteLine(b1.Equals(b2));
        
            int i = b1.square();
           Console.WriteLine(i);
            IEvent b3 = new Button(25, 42);
            b3.Click();
            IAction b4 = new Button(25, 42);
            b4.Click();




            ///

        }
    }
}
