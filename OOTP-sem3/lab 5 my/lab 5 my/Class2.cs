using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5_my
{
   public class PS<T>:IEnumerable<T> where T:Controle
    {
        public int countt = 0;
        public int countl = 0;

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public PS()
        {
            list = new List<T>();
        }
        public List<T> list;
        public void Add(T item)
        {
            if (item.ToString()=="button")
            {
                countt++;
            }
            else
            {
                countl++;
            }
            list.Add(item);

        }
        public void Add(T item,int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(item);
                if (item.ToString() == "button")
                {
                    countt++;
                }
                else
                {
                    countl++;
                }
                

            }

        }
        public void Delete(int id)
        {
            list.RemoveAt(id);
        }
       public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Название элемента списка : {item.ToString()}");
            }
        }
        public void ShowCountText()
        {   if (countl != 0)
                Console.WriteLine($"кол-во текстбоксов : {countl}");
            else throw new Exception1("Текстбоксов не существует.");
          
        }   
        public void ShowCountBut()
        {
            if (countt != 0)
                Console.WriteLine($"кол-во Баттонов : {countt}");
            else throw new Exception2("Баттонов нет");

        }
    }
}
