using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    //public class Node<T>
    //{


    //    public Node(T data)
    //    {
    //        Data = data;
    //    }
    //    public Node(T data, Node<T> next)
    //    {
    //        Data = data;
    //        Next = next;
    //    }
    //    public T Data { get; set; }
    //    public Node<T> Next { get; set; }
    //    public Node<T> SetNextNode(Node<T> node) => Next = node;
    //}

    //public class Owner
    //{
    //    private string _name;
    //    private string _organization;
    //    private static int Id;

    //    public Owner(string name, string organization)
    //    {
    //        this._name = name;
    //        this._organization = organization;
    //        Id++;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine($"ID: {Id}\n" +
    //            $"Name: {_name}\n" +
    //            $"Organization: {_organization}");
    //    }
    //}

    //public class Date
    //{
    //    private DateTime _time;

    //    public Date()
    //    {
    //        _time = DateTime.Now;
    //    }

    //    public void ShowDate()
    //    {
    //        Console.WriteLine(_time);
    //    }
    //}


    //public class LinkedList<T> //: IEnumerable<T>
    //{
    //   public Node<T> head;
    //   public Node<T> tail;
    //    int count;





    //    public void Add(T data)// добавление элемента
    //    {
    //        Node<T> node = new Node<T>(data);

    //        if (head == null)
    //            head = node;
    //        else
    //            tail.Next = node;
    //        tail = node;

    //        count++;
    //    }

    //    public void ShowInfo() //Вывод списка
    //    {
    //        Node<T> node = head;
    //        while (node.Next != null)
    //        {
    //            Console.Write(node.Data + " --> ");
    //            node = node.Next;
    //        }
    //        Console.WriteLine(node.Data + "\n");
    //    }

    //    public bool Remove(T data) //Удаление по элементу
    //    {
    //        Node<T> current = head;
    //        Node<T> previous = null;

    //        while (current != null)
    //        {
    //            if (current.Data.Equals(data))
    //            {
    //                // Если узел в середине или в конце
    //                if (previous != null)
    //                {

    //                    // убираем узел current, теперь previous ссылается не на current, а на current.Next
    //                    previous.Next = current.Next;

    //                    // Если current.Next не установлен, значит узел последний,
    //                    // изменяем переменную tail
    //                    if (current.Next == null)
    //                        tail = previous;
    //                }
    //                else
    //                {
    //                    // если удаляется первый элемент
    //                    // переустанавливаем значение head

    //                    head = head.Next;
    //                    // если после удаления список пуст, сбрасываем tail
    //                    if (head == null)
    //                        tail = null;
    //                }
    //                count--;
    //                return true;
    //            }
    //            previous = current;
    //            current = current.Next;
    //        }
    //        return false;
    //    }

    //    public void Remove(int index)//Удаление по индексу 
    //    {
    //        if (this.count == 0)
    //        {
    //            Console.WriteLine("Список пуст!");
    //        }
    //        if (this.count == 1)
    //        {
    //            head = null;
    //        }
    //        if (index == 1)
    //        {
    //            Console.WriteLine($"Узел {head.Data} удалён!");
    //            head = head.Next;
    //            return;
    //        }

    //        Node<T> node = head;
    //        Node<T> nextNode = head.Next;

    //        for (int i = 0; i < index - 2; i++)
    //        {
    //            node = node.Next;
    //            nextNode = nextNode.Next;
    //        }
    //        Console.WriteLine($"Узел {nextNode.Data} удалён!");
    //        node.SetNextNode(nextNode.Next);
    //    }




    //    public override string ToString()
    //    {
    //        var res = "";
    //        for (Node<T> pA = head; pA != null; pA = pA.Next)
    //        {
    //            res += pA.Data + " ";
    //        }
    //        return res;
    //    }



    //    #region Перегрузки
    //    public static LinkedList<T> operator +(LinkedList<T> A, LinkedList<T> B)
    //    {
    //        LinkedList<T> list = new LinkedList<T>();

    //        for (Node<T> p = A.head; p != null; p = p.Next)
    //            list.Add(p.Data);
    //        for (Node<T> p = B.head; p != null; p = p.Next)
    //            list.Add(p.Data);
    //        return list;
    //    }


    //    public static LinkedList<string> operator !(LinkedList<T> A)
    //    {

    //        string test = A.ToString();
    //        var strArr = test.Split(" ");
    //        string[] strArr2 = new string[strArr.Length - 1];
    //        Array.Copy(strArr, strArr2, strArr.Length - 1);
    //        LinkedList<string> list0 = new LinkedList<string>();
    //        for (int i = strArr2.Length - 1; i > -1; i--)
    //        {

    //            string temp = strArr2[i];
    //            //strArr2[i] = null;
    //            list0.Add(temp);
    //        }



    //        return list0;
    //    }

    //    //public static LinkedList<T> operator --(LinkedList<T> A)
    //    //{

    //    //    A.Remove(1);

    //    //    return A;
    //    //}


    //    public static bool operator !=(LinkedList<T> A, LinkedList<T> B)
    //    {

    //        return A.ToString() != B.ToString();
    //    }
    //    public static bool operator ==(LinkedList<T> A, LinkedList<T> B)
    //    {
    //        return A.ToString() == B.ToString();
    //    }

    //    public static LinkedList<T> operator <(LinkedList<T> A, LinkedList<T> B)
    //    {
    //        return A + B;
    //    }

    //    public static LinkedList<T> operator >(LinkedList<T> A, LinkedList<T> B)
    //    {
    //        return B + A;
    //    }


    //    //public static bool operator true(LinkedList<T> A)
    //    //{
    //    //    return A.head == null;
    //    //}
    //    //public static bool operator false(LinkedList<T> A)
    //    //{
    //    //    return A.head != null;
    //    //}
    //    #endregion



    //    public class Owner
    //    {
    //        string id;
    //        string name;
    //        string edition;

    //        public Owner(string _ID, string _NAME, string _EDITION)
    //        {
    //            id = _ID;
    //            name = _NAME;
    //            edition = _EDITION;
    //        }
    //    }
    //    public class Date
    //    {
    //        DateTime time = new DateTime();

    //        public DateTime Time { get { return time; } set { this.time = value; } }
    //        public Date(DateTime time)
    //        {
    //            if (time != null)

    //                this.time = time;
    //            else
    //                this.time = DateTime.Now;
    //        }
    //    }




    //    //IEnumerator IEnumerable.GetEnumerator()
    //    //{
    //    //    return ((IEnumerable)this).GetEnumerator();
    //    //}

    //    //    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    //    //    {
    //    //        Node<T> current = head;
    //    //        while (current != null)
    //    //        {
    //    //            yield return current.Data;
    //    //            current = current.Next;
    //    //        }
    //    //    }
    //}

    public class Owner
    {
        private string _name;
        private string _organization;
        private static int Id;

        public Owner(string name, string organization)
        {
            this._name = name;
            this._organization = organization;
            Id++;
        }
        public void Print()
        {
            Console.WriteLine($"ID: {Id}\n" +
                $"Name: {_name}\n" +
                $"Organization: {_organization}");
        }
    }

    public class Date
    {
        private DateTime _time;

        public Date()
        {
            _time = DateTime.Now;
        }

        public void ShowDate()
        {
            Console.WriteLine(_time);
        }
    }
    public class Str<T>:IGen<T> where T:class //ограничение на ссылочные типы 
    {
        private string str;
        private static int count;



        public char this[int index]
        {
            get
            {
                if (index > count - 1 || index < 0) throw new WrongIndexException("ERROR: индекс");

               char temp='\0';

                for (int i = 0; i < index; i++)
                {
                    temp = this.STr[i];
                }

                return temp;
            }
            set
            {
                if (index > count - 1 || index < 0) throw new WrongIndexException("ERROR: индекс");

                char temp = '\0';

                for (int i = 0; i < index; i++)
                {
                    temp = this.STr[i];
                }

                temp = value;
            }
        }



        public string STr
        {
            get => str;

            set
            {
                str = value;
            }
        }
        

      
        public void RemoveInd(int ind)
        {
           
            for (int i = 0; i < this.STr.Length; i++)
            {
                if(i==ind) this.STr = this.STr.Remove(i,1);
            }
            Str<T>.count--;
           
        }
        //перегрузка
        public static Str<T> operator <(Str<T> A, char B)
        {
            
            for (int i = 0; i < A.STr.Length; i++)
            {
                if (A.STr[i] == B) A.RemoveInd(i); 
            }

            return A;
        }
        public static Str<T> operator >(Str<T> A, char B)
        {
            for (int i = 0; i < A.STr.Length; i++)
            {
                if (A.STr[i] == B) A.RemoveInd(i);
            }

            return A;
        }

        public static Str<T> operator +(Str<T> A)
        {
            for (int i = 0; i < A.STr.Length+1; i++)
            {
                if (i+1 % 2 != 0) A.RemoveInd(i);
            }
            return A;
        }

        public static bool operator !=(Str<T> A, Str<T> B)
        {

            return A.STr.Length != B.STr.Length;
        }
        public static bool operator ==(Str<T> A, Str<T> B)
        {
            return A.STr.Length == B.STr.Length;
        }


        public static bool operator true(Str<T> A)
        { int x = 0;
            for (int i = 0; i < A.STr.Length; i++)
            {
                if (A.STr[i] == ',' || A.STr[i] == '.' || A.STr[i] == ':' || A.STr[i] == ';') x++;
            }

            return x>0;
        }
        public static bool operator false(Str<T> A)
        {
            int x = 0;
            for (int i = 0; i < A.STr.Length; i++)
            {
                if (A.STr[i] == ',' || A.STr[i] == '.' || A.STr[i] == ':' || A.STr[i] == ';') x++;
            }

            return x < 0;
        }


        //------------------
        public void Add(T data)
        {
          
            this.str += data.ToString();
            Str<T>.count++;

           
        }

        public void Contains(char data) 
        {
            for (int i = 0; i < this.STr.Length; i++)
            {
                if (this.STr[i] == data) this.STr.Remove(i, 1);
            }
        }

        public void Print()
        {
            Console.WriteLine(this.str);
        }





        public class Owner
        {
            string id;
            string name;
            string edition;

            public Owner(string _ID, string _NAME, string _EDITION)
            {
                id = _ID;
                name = _NAME;
                edition = _EDITION;
            }
        }
        public class Date
        {
            DateTime time = new DateTime();

            public DateTime Time { get { return time; } set { this.time = value; } }
            public Date(DateTime time)
            {
                if (time != null)

                    this.time = time;
                else
                    this.time = DateTime.Now;
            }
        }



    }


    class Program
    {

    
        static void Main(string[] args)
        {
            try
            { 
                Str<figure> fig = new Str<figure>();//класс из 5й лабы в ккачестве типа 
                fig.Add(new rectangle());
                fig.Add(new circle());
                fig.Print();

               


                Str<string> Item1 = new Str<string>();
                Item1.Add("worwld dwdwdw dw");
                Item1.Print();
                INFILE.WriteToFile(Item1);

                Str<string> iiii = new Str<string>();
                INFILE.ReadFromFile(ref iiii);
                iiii.Print();

                Console.WriteLine("Введите символ:");
                char a = Char.Parse(Console.ReadLine());
                Str<string> Item2 = new Str<string>();
                Item2 = Item1 > a;
                Item2.Print();


                Str<string> Item3 = new Str<string>();
                Item3.Add("12345678910");
                Item3.Print();
                Console.WriteLine("Удаление нечётных символов:");
                Item3 = +Item3;
                Item3.Print();


                Str<string> Item4 = new Str<string>();
                Item4.Add("1234daw");
                Str<string> Item5 = new Str<string>();
                Item5.Add("1234swa");
                Console.WriteLine($"Сравнение строк:");
                Console.WriteLine(Convert.ToString(Item4 != Item5));


                if (Item5) Console.WriteLine(true);


                Console.WriteLine("Введите символ:");
                char b = Char.Parse(Console.ReadLine());
                Console.WriteLine($"Входит ли символ в строку:{Item5.Contain(b)}"); ;

                Item5.DelNumb();
                Item5.Add(" dsa");
                Console.WriteLine(Item5.Sum());



                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Owner own = new Owner("Victor", "BSTU");
                own.Print();

                Date d = new Date();
                d.ShowDate();
            }
            catch(WrongIndexException ex)
            {
                Console.WriteLine(ex);
            }
            finally { Console.WriteLine("HUI"); }
            //Console.ForegroundColor = ConsoleColor.Cyan;

            //LinkedList<string> list1 = new LinkedList<string>();
            //Console.Write("1й список: ");
            //list1.Add("word1");
            //list1.Add("word2");
            //list1.Add("word3");
            //list1.Add("word4");
            //list1.ShowInfo();


            //LinkedList<string> list01 = new LinkedList<string>();
            //Console.WriteLine("Реверсивный 1й список:");
            //list01 = !list1;
            //list01.ShowInfo();


            //Console.Write("\n\n\n");
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //LinkedList<string> list2 = new LinkedList<string>();
            //Console.Write("2й список: ");
            //list2.Add("word5");
            //list2.Add("word6");
            //list2.Add("word7");
            //list2.Add("word8");
            //list2.ShowInfo();



            //Console.Write("\n\n\n");
            //Console.ForegroundColor = ConsoleColor.Green;
            //LinkedList<string> list12 = new LinkedList<string>();
            //Console.Write("\nОбъединение 1 и 2 списков(2й + 1й): ");
            //list12 = list1 > list2;
            //list12.ShowInfo();
            //LinkedList<string> list012 = new LinkedList<string>();
            //Console.Write("\nОбъединение 1 и 2 списков(1й + 2й): ");
            //list012 = list1 < list2;
            //list012.ShowInfo();

            ////Console.ForegroundColor = ConsoleColor.Gray;
            ////Console.WriteLine("\nУдаление первого элемента(перегрузка) и 4 выбором:");
            ////--list012;
            ////list012.Remove("word4");
            ////list012.ShowInfo();



            //Console.Write("\n\n\n");
            //Console.ForegroundColor = ConsoleColor.Red;
            //if (list1 == list2) Console.WriteLine("\nРавенство 1 и 2 списков:\n------Списки равны------\n"); else if (list1 != list2) Console.WriteLine("\nРавенство 1 и 2 списков:\n------Списки не равны------\n");
            //LinkedList<string> list11 = new LinkedList<string>();
            //Console.Write("Список для сравнения с 1м: ");
            //list11.Add("word1");
            //list11.Add("word2");
            //list11.Add("word3");
            //list11.Add("word4");
            //list11.ShowInfo();
            //if (list1 == list11) Console.WriteLine("Равенство 1 и идентичного ему списков:\n------Списки равны------"); else if (list1 != list11) Console.WriteLine("\nРавенство 1 и 2 списков:\n------Списки не равны------");




            ////LinkedList<string> emptyList = new LinkedList<string>();
            ////if (emptyList)
            ////    Console.WriteLine("\nСписок пустой!\n");




            //Console.ForegroundColor = ConsoleColor.Yellow;
            //LinkedList<string> list3 = new LinkedList<string>();
            //Console.Write("\n\n\n3й список: ");
            //list3.Add("Hello");
            //list3.Add("Hell");
            //list3.Add("DontBe3Sad");
            //list3.Add("HaveAGoodTime51");
            //list3.ShowInfo();
            //Console.WriteLine($"Общая длина элементов списка:{list3.Sum()}");
            //Console.WriteLine($"Разница между длинами максимальной и минимальной строк: {list3.Difference()}");
            //Console.WriteLine($"В списке {list3.CountOfS()} элементов(a)");
            ////Console.WriteLine($"Последнее число в списке {list3.LastNumb()} \n");


            //Console.Write("\n\n\n");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;

            //Owner own = new Owner("Dmitry", "BSTU" );
            //own.Print();

            //Date d = new Date();
            //d.ShowDate();

            //Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            //Console.Write("\n\n\n");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.Write(list3.ToString()+"\t\t"+list3.Tostring2());
            //Console.ForegroundColor = ConsoleColor.Black;




            ;
        }
    }
}