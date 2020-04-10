using System;

namespace Lab_3_4
{
    class Param
    {
        public int Length;
        public int Start;
        public int End;
        int[] Arr;

        public void Cr_arr(int[] Arr, int Length, int Start, int End)
        {
            Random R = new Random();
            for (int i = 0; i < Length; i++)
            {
                Arr[i] = R.Next(Start, End);
                Console.Write("{0} ", Arr[i]);
            }
            Console.WriteLine();
        }
        public void SumArr(int[] a, int[] b)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] += b[i];
                Console.Write("{0} ", a[i]);
            }
        }
        public void SustractArr(int[] a, int[] b)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] -= b[i];
                Console.Write("{0} ", a[i]);
            }
        }
        public void skal_mult(int[] a, int temp)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] *= temp;
                Console.Write("{0} ", a[i]);
            }
        }
        public void skal_del(int[] a, int temp)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] /= temp;
                Console.Write("{0} ", a[i]);
            }
        }
    }

    class Program
    {
        //Задание 6
        static void Main(string[] args)
        {
            Param one = new Param();
            Param two = new Param();

            // задание произвольных целых границ индексов при создании объекта;
            // можно принимать значения введенные пользователем, например:
            // Console.WriteLine("введите размерность массива One[]: ");
            // one.Length = int.Parse(Console.ReadLine());
            one.Length = 10;
            one.Start = 1;
            one.End = 12;

            two.Length = 10;
            two.Start = -3;
            two.End = 9;

            int[] One = new int[one.Length];
            int[] Two = new int[two.Length];

            //вывод на экран всего массива
            Console.WriteLine("Массив-вектор One:");
            one.Cr_arr(One, one.Length, one.Start, one.End);
            Console.WriteLine("Массив-вектор Two:");
            two.Cr_arr(Two, two.Length, two.Start, two.End);
            
            //обращение к отдельному элементу массива с контролем выхода за пределы массива;
            try
            {
                Console.Write("индекс элемента = ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("One[{0}]={1}", i, One[i]);
            }
            catch { Console.WriteLine("индекс элемента выходит за рамки массива"); }

            // выполнение операций поэлементного сложения
            Console.WriteLine("One+Two:");
            one.SumArr(One, Two);
            Console.WriteLine("\nOne-Two:");
            // выполнение операций поэлементного вычитания 
            one.SustractArr(One, Two);
            Console.WriteLine("\nOne*3:");
            //  выполнение операций умножения и деления всех элементов массива на скаляр;
            one.skal_mult(One, 3);
            Console.WriteLine("\nOne/2:");
            one.skal_del(One, 2);

        }
    }
}
