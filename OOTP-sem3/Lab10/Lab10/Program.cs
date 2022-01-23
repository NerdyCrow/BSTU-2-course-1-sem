using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


namespace Lab10
{
    class Sweets
    {
        public string _Name;
       
        public string Name
        {
            get => _Name;
            set => _Name=value;
        }
      

        public Sweets(string name)
        {
            this._Name = name;
            
        }

    
    }

    class Comparer: IComparer<Sweets>
    {
        public int Compare(Sweets x, Sweets y)
        {
            return x.Name.CompareTo(y.Name);
        }
      

    }

    class ResColl : ISet<Sweets> 
    {
        private int _count;
        public SortedSet<Sweets> sweets;
        public Queue<Sweets> qsweet;
        public ResColl()
        {
            _count = 0;
            sweets = new SortedSet<Sweets>(new Comparer());
        }

        public int Count => _count;


      public Queue<Sweets> Change()
        {
            Queue<Sweets> q1 = new Queue<Sweets>();
            foreach (var Sweets in sweets)
            {
                var word =Sweets.Name as string ;
                
                q1.Enqueue(new Sweets(word));

            }
            
            return q1;
        }




        public void Show()
        {
            Console.Write("Set:   ");
            foreach (var Sweets in sweets)
            {
                Console.Write(Sweets.Name + "   ");
            }
            Console.WriteLine();
        }

        public bool Add(Sweets item)
        {
            return sweets.Add(item);
        }

        public void Clear()
        {
            sweets.Clear();
        }

        public bool Contains(Sweets item)
        {
            return sweets.Contains(item);
        }

        public void CopyTo(Sweets[] array, int arrayIndex)
        {
            sweets.CopyTo(array, arrayIndex);
        }

        public void ExceptWith(IEnumerable<Sweets> other)
        {
            sweets.ExceptWith(other);
        }

        public IEnumerator<Sweets> GetEnumerator()
        {
            return sweets.GetEnumerator();
        }

        public void IntersectWith(IEnumerable<Sweets> other)
        {
            sweets.IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<Sweets> other)
        {
            return sweets.IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<Sweets> other)
        {
            return sweets.IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<Sweets> other)
        {
            return sweets.IsProperSupersetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<Sweets> other)
        {
            return sweets.IsProperSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<Sweets> other)
        {
            return sweets.IsProperSupersetOf(other);
        }

        public bool Remove(Sweets item)
        {
            return sweets.Remove(item);
        }

        public bool SetEquals(IEnumerable<Sweets> other)
        {
            return sweets.SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<Sweets> other)
        {
            sweets.SymmetricExceptWith(other);
        }

        public void UnionWith(IEnumerable<Sweets> other)
        {
            sweets.UnionWith(other);
        }
        public bool IsReadOnly => false;

        void ICollection<Sweets>.Add(Sweets item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Random rnd = new Random();

            list.Add(rnd.Next(1, 5)); // заносим в список объект типа int
            list.Add(rnd.Next(6, 10)); // заносим в список объект типа int
            list.Add(rnd.Next(11, 15)); // заносим в список объект типа int
            list.Add(rnd.Next(6, 20)); // заносим в список объект типа int
            list.Add(rnd.Next(21, 25)); // заносим в список объект типа int

            list.AddRange(new string[] { "Hello", "world" }); // заносим в список строковый массив

            foreach (var elem in list)
            {
                Console.Write(elem + " ");
            }

            list.RemoveAt(3); // удаляем 4 элемент
            list.Remove("Hello"); // удаление заданного 
            Console.WriteLine();
            foreach (var elem in list)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine("\nКоличество элементов:" + list.Count);

            Console.WriteLine($"Элемент 'world' присутствует в коллекции: {list.Contains("world")}");
            Console.WriteLine($"Элемент '26' присутствует в коллекции: {list.Contains(26)}");


            Console.WriteLine("\n\n-------------------------------Обобщённая коллекция---------------------------------------------");
            SortedSet<float> SS = new SortedSet<float>();
            // добавляем элементы
            SS.Add(2.3f);
            SS.Add(1.8f);
            SS.Add(66.53f);

            // Перебираем все элементы с помощью foreach и выводим на экран
            foreach (float elem in SS)
                Console.Write(" " + elem);


            Console.WriteLine("\nУдаление элементов");
            SS.RemoveWhere(item => item == 2.3f || item == 1.8f || item == 66.53f);

            SS.Add(21.432f);
            SS.Add(13.321415f);
            SS.Add(0.34f);

            Console.WriteLine("\n SS:");
            foreach (float elem in SS)
                Console.Write(" " + elem);


            SortedSet<float> SS2 = new SortedSet<float>() { 0.34f, 43.2f };
            SS2.UnionWith(SS);


            Console.WriteLine("\nОбъединение:");


            Console.WriteLine("\n SS2:");
            foreach (var elem in SS2)
                Console.Write(" " + elem);


            Queue<float> QQ = new Queue<float>();
            float[] ff = new float[SS2.Count];
            SS2.CopyTo(ff);
            for (int i = 0; i < ff.Length; i++)
            {
                QQ.Enqueue(ff[i]);
            }

            Console.WriteLine("\nОчередь:");
            foreach (var elem in QQ)
            {
                Console.Write(" " + elem);
            }


            Console.WriteLine("\nВведите число:");
            float value = float.Parse(Console.ReadLine());
            bool fl = Contain(QQ, value);
            Console.WriteLine($"Число есть в очереди:{fl}");



            Console.WriteLine("\n\n-------------------------------Пользовательский тип---------------------------------------------");

            ResColl ss = new ResColl();
            ss.Add(new Sweets("Roshen"));
            ss.Add(new Sweets("Кислинка"));
            ss.Add(new Sweets("Шипучка"));
            ss.Show();
            ss.Remove(new Sweets("Шипучка"));
            ss.Show();

            Queue<Sweets> qs = new Queue<Sweets>();
            qs = ss.Change() ;
            Console.Write("ОЧЕРЕДЬ, заполненная элементами пользовательского типа:");
            foreach (var elem in qs)
            {
                Console.Write(elem.Name + " ");
            }
            Console.WriteLine();
          
            bool f = Contain(qs, new Sweets("Roshen"));
            Console.WriteLine($"Элемент есть в очереди:{f}");

            ObservableCollection<Sweets> item = new ObservableCollection<Sweets> { new Sweets("Кислинка"), new Sweets("Шипучка"), new Sweets("Roshen") };
            item.CollectionChanged += Sweets_CollectionChanged;

            item.Add(new Sweets("Коммунарка"));
            item.RemoveAt(1);
            item[0] = new Sweets("Крокант");

            Console.Write("ObsColl.:");
            foreach (Sweets user in item)
            {
                Console.Write(user.Name+" ");
            }
            Console.WriteLine();
        }

        private static void Sweets_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Sweets newSweets = e.NewItems[0] as Sweets;
                    Console.WriteLine($"Добавлен новый объект: {newSweets.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Sweets oldSweets = e.OldItems[0] as Sweets;
                    Console.WriteLine($"Удален объект: {oldSweets.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Sweets replacedSweets = e.OldItems[0] as Sweets;
                    Sweets replacingSweets = e.NewItems[0] as Sweets;
                    Console.WriteLine($"Объект {replacedSweets.Name} заменен объектом {replacingSweets.Name}");
                    break;
            }
        }

        static bool Contain(Queue<float> QQ, float value)
        {
            bool flag = false;
            foreach (var elem in QQ)
            {
                if (elem == value) flag = true;
            }

            return flag;
        }

        static bool Contain(Queue<Sweets> QQ, Sweets value)
        {
            bool flag = false;
            foreach (var elem in QQ)
            {
                if (elem.Name == value.Name) flag = true;
            }

            return flag;
        }
    }
}

