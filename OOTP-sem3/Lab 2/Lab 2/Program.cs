using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world";
            bool flag = true;
            byte bit = 1; //0-255
            sbyte bit1 = -101;//-128  - 127
            short sh = 1;// -32768 - 32767
            ushort ush = 253;//0 - 65535
            int a = 10;//-2147483648 
            int b = 0b101;  // бинарная форма b =5
            int c = 0xFF;   // шестнадцатеричная форма c = 255
            uint uit = 10; //0 до 4294967295
            long lg = -10;//–9 223 372 036 854 775 808
            ulong ulg = 10;//от 0 до ,,,
            float fl = 1.25f;//4b
            double db = 25454.6d; //8b
            decimal myMoney = 3000.5m;
            char ch = 'A';//2
            object a1 = 22;//4
            object b2 = 3.14;
            object c3 = "hello code";
            int con = Convert.ToInt32(fl);

            Console.WriteLine($"string  : {str}");
            Console.WriteLine($"byte    : {bit}");
            Console.WriteLine($"sbyte   : {bit1}");
            Console.WriteLine($"short   : {sh}");
            Console.WriteLine($"ushort  : {ush}");
            Console.WriteLine($"int     : {a}");
            Console.WriteLine($"uint    : {uit}");
            Console.WriteLine($"long    : {lg}");
            Console.WriteLine($"ulong   : {ulg}");
            Console.WriteLine($"float   : {fl}");
            Console.WriteLine($"double  : {db}");
            Console.WriteLine($"dencimal: {myMoney}");
            Console.WriteLine($"char    : {ch}");




            //Типизация 
            //явная типизация
            int a2 = 255;

            byte b1 = (byte)a2;
            int c1 = (int)b1;
            long d1 = (long)a2;

            long e1 = 255;

            byte f1 = (byte)e1;
            //неявная типизация 
            byte aa = 255;

            long ab = aa;
            int ac = aa;
            short ad = aa;
            double af = aa;
            ushort ag = aa;



            //упаковка и распаковка
            int x = 255;
            Object obj = x;
            x = (int)obj;


            //работа с неявно типизированной переменной
            var flag1 = true;
            if (flag1) Console.WriteLine("hi");



            //nullable
            int? nul = null;
            //Есть ли реальное значение nul.HasValue, само значение NUllable переменной:nul.Value;
            var vr = 5;
            //vr = 5.5;

            //Строковые литералы
            string st1 = "hello";
            string st2 = "my";
            string st3 = "friend";


            Console.WriteLine(st1 == st2);//false

            st1 += st2;//сцепление

            string st4 = st1;//  копирование

            string substr = st1.Substring(0, 5);//выделение подсроки

            string phrase = "вышел заяц на крыльцо";
            string[] words = phrase.Split(' ');//разделение строки на слова


            string nst = "dog cat";
            string nst1 = "mouse";

            Console.WriteLine(nst.Insert(4, nst1));

            // удаление
            string nst2 = "dog cat mouse";

            Console.WriteLine(nst2.Remove(0, 4));//cat mouse

            //интерполяция строк
            Console.WriteLine($"int a = {a}; string: {str}");

            //Строка null
            string nst3 = null;
            string emp = String.Empty;
            if (String.IsNullOrEmpty(nst3)) Console.WriteLine("Строка null");
            else Console.WriteLine("Строка пустая");


            //StringBuilder
            var sb = new System.Text.StringBuilder("Прекрасная погода");

            sb.Append("!");

            sb.Insert(17, ",Влад");
            Console.WriteLine(sb.ToString());
            sb.Remove(17, 5);
            Console.WriteLine(sb.ToString());

            //Массивы


            int[,] arr = { { 1, 2, 3 }, { 33, 34, 35 }, { 8, 9, 10 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.Write("\n\n");
            }

            //Массив строк
            string[] mstr = { "u", "S", "S", "R" };
            /* Console.WriteLine("Масив:");
             for (int i = 0; i < mstr.Length; i++)
                 Console.WriteLine($"{i}-ая строка: {mstr[i]}");

             Console.WriteLine("Введите номер строки, которую хотите заменить: ");
             int num = System.Convert.ToInt32(Console.ReadLine());

             if (num < mstr.Length)
             {
                 Console.WriteLine("Новая строка: ");
                 string ff = Console.ReadLine();
                 mstr[num] = ff;
                 for (int i = 0; i < mstr.Length; i++)
                     Console.WriteLine($"{i}-ая строка: {mstr[i]}");
             }
             else Console.WriteLine("Строки с таким номером не найдено");*/

            //Ступенчатый массив

            int[][] myArr = new int[3][];
            /*myArr[0] = new float[2];
            myArr[1] = new float[3];
            myArr[2] = new float[4];*/
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = new int[i + 2];
                Console.WriteLine($"Введите элементы {i + 1}-ого массива");
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    myArr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    Console.Write(myArr[i][j] + " | ");
                }
                Console.WriteLine();
            }

            //Неявно типиз массив
            var vrr = new[] { 22, 54, 154, 84 };
            var vst = new[] { "Hello", "My", "Dear", "Friend" };


            //КОРТЕЖИ
            (int, string, char, string, ulong) car = (250, "mercedes", 'S', "benz", 520);
            Console.WriteLine(car);
            Console.WriteLine($"speed:{car.Item1}\nName:{car.Item2}");

            string kor;
            int kor2;

            (string kor, ushort kor2) ha = ("Hello", 11);

            kor = ha.kor;
            kor2 = ha.kor2;

            (kor, _, _) = tuplesReturn();

            Console.WriteLine(ha == ("Hello", 11)); // true
            Console.WriteLine(ha == ("Hello", 22)); // false


            static (string, ushort, char) tuplesReturn()
            {
                return ("Hello", 33, 'a');
            }


            (int, int, int, string) tsk()
            {
                int[] ar = new int[] { 3, 2, 11, 9, 1, 8, 5 };
                string strk = "car";
                int min = ar[0];
                int max = ar[0];
                int sumarr = 0;
                string firstlit;
                for (int nu = 0; nu < ar.Length; nu++)
                {
                    sumarr += ar[nu];
                    if (min > ar[nu])
                        min = ar[nu];
                    if (max < ar[nu])
                        max = ar[nu];
                }
                firstlit = strk.Remove(1);
                var Korteg = (min, max, sumarr, firstlit);
                return Korteg;
            }
            static void task6_checked()
            {
                checked
                {
                    int i = int.MaxValue;
                }
            }
            //проверка арифметического переполнения
            static void task6_unchecked()
            {
                unchecked
                {
                    int i = int.MaxValue + 1;
                }
            }
            Console.WriteLine(tsk());
           
        }
        

      


    }
}

