using System;

 

namespace Lab_3
{
    public partial class Array
    {
        public int[] IntArr;
        int size = 0;
        int maxSize = 20;
        private static int count = 0;


        public int Count
        {
            get
            {
                return count;
            }
        }

        public int this[int index]
        {

            get
            {
                return IntArr[index];
            }
            set
            {
                IntArr[index] = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value < maxSize)
                {
                    size = value;
                    IntArr = new int[size];

                }
                else
                {
                    Console.WriteLine("Превышен размер массива ");

                }

            }

        }
        //конструктор*****************************************

        public Array(int size)
        {
            this.size = size;
            IntArr = new int[size];

            Array.count++;
        }
        public Array()
        {
            size = 10;
            IntArr = new int[size];
            Array.count++;
        }
        /*public void Even(Array[] c)
        {
            for (int i = 0; i < c.count ; i++)
            {

            }
        }*/

        //************************************************


        public void InputArr()
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < IntArr.Length; i++)
            {
                Console.WriteLine($"Arr[{i}] = ");
                IntArr[i] = int.Parse(Console.ReadLine());

            }
        }

        public void OutArr()
        {
            for (int i = 0; i < IntArr.Length; i++)
            {
                Console.Write($"Arr[{i + 1}] = {IntArr[i]} \n");
            }
            Console.WriteLine();
        }
        public void Sum(Array b)
        {
            if (this.size == b.size)
            {

                Array sum = new Array(this.size);

                for (int i = 0; i < this.size; i++)
                {
                    sum[i] = this[i] + b[i];
                    Console.Write(sum[i] + "  ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Массивы разынх размеров");
            }

        }
        public void Change(ref int A,int percent=2)
        {
            A = A * percent;

        }


        public void Change2(out int A, int p)
        { 
            A =  p;

        }

        public void Deff(Array b)
        {
            if (this.size == b.size)
            {

                Array deff = new Array(this.size);

                for (int i = 0; i < this.size; i++)
                {
                    deff[i] = this[i] - b[i];
                    Console.Write(deff[i] + "  ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Массивы разынх размеров");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*     Array A = new Array(3);
                   A.Size = 3;
                   A.InputArr();
                   A.OutArr();
                   Console.WriteLine(A[2]);
                   Array B = new Array(3);
                   B.InputArr();
                   A.Sum(B);
                   A.Deff(B);*/


            Array[] C = new Array[2];
            C[0] = new Array(3);
            C[1] = new Array(3);

            C[0].InputArr();
            C[1].InputArr();



            foreach (Array elem in C)
            {
                bool flag = true;
                for (int i = 0; i < elem.Size; i++)
                {

                    if (elem[i] % 2 == 0)
                    {

                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Четный массив: ");
                    elem.OutArr();
                }
                else
                {
                    Console.WriteLine("Нечетный массив: ");
                    elem.OutArr();
                }
            }
            int sum = 0, max = 0;
            int cc = 0;
            foreach (Array elem in C)
            {

                for (int i = 0; i < elem.Size; i++)
                {
                    sum += elem[i];
                }
                if (sum > max)
                {
                    cc++;
                    max = sum;
                }
            }
            Console.WriteLine($"Массив с наибольшей суммой элементов({sum}) : ");
            C[cc - 1].OutArr();

            if (C[0].Equals(C[1])) Console.WriteLine("Размеры массивов идентичны");

            Array Hz = C[0];
            int A = Hz.IntArr[0];
            Hz.OutArr();
            Hz.Change(ref A);
            Hz.IntArr[0] = A;
            Hz.OutArr();

            int B;
            Hz.Change2(out B, 10);
            Hz.IntArr[1]= B;
            Hz.OutArr();


        }
    }
}
