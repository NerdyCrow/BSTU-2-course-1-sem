using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9_13
{
    class ClassPr
    {
        public delegate void Words(List<string> list);
        public event Words AddLang;
        public event Words ReName;

 


        public void ADD(List<string> list)
        {
            Console.WriteLine("\nКакой язык хочешь добавить?");
            string item = Console.ReadLine();
            list.Add(item);

            AddLang?.Invoke(list);
        }
        public void Rename(List<string> list)
        {
            Console.WriteLine("Введи номер языка,который хочешь заменить, и новый язык");
            int ind = int.Parse(Console.ReadLine());
            string item = Console.ReadLine();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == ind) list[i] = item;
            }
            

            ReName?.Invoke(list);
        }


    }
}
