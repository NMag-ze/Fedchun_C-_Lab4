using System;

namespace Lab_3_1
{
    class Arrs
    {
        private static Random rnd;
        static Arrs()
        {
            rnd = new Random();
        }



        public static void CreateOneDimAr(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0,50);
            }
        }
        public static void CreateAr2(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(0,50);
                }
        }

        public static void CreateAr3(int[][] mnog)
        {

            for (int i = 0; i < mnog.Length; i++)
                for (int j = 0; j < mnog[i].Length; j++)
                {
                    mnog[i][j] = rnd.Next(0,50);
                }

        }

        public static void PrintArr1(string name, int[] mas2)
        {
            Console.WriteLine("Массив {0}", name);
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }
            Console.Write("\n");
        }
        public static void PrintArr2(string name, int[,] matr3)
        {
            int rows = matr3.GetUpperBound(0) + 1;
            int cols = matr3.Length / rows;

            Console.WriteLine("Матрица {0}", name);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matr3[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void PrintArr3(string name, int[][] mm)
        {
            Console.WriteLine("Массив массивов {0}", name);
            for (int i = 0; i < mm.Length; i++)
            {
                for (int j = 0; j < mm[i].Length; j++)
                {
                    Console.Write(mm[i][j] + " ");
                }
                Console.Write("\n");
            }
        }

        public static void PrintAnyArr(string name, Array univ)
        {
            Console.WriteLine(name);
            int n = univ.Rank;
            if (n == 1)// одномерный массив
            {
                var en = univ.GetEnumerator();

                en.MoveNext();
                if (en.Current.GetType() == Type.GetType("System.Int32"))
                    for (int i = 0; i < univ.GetLength(0); i++)
                        Console.Write(univ.GetValue(i) + " ");
                else
                    foreach (int[] mas in univ)
                    {
                        for (int i = 0; i < mas.GetLength(0); i++)
                            Console.Write(mas.GetValue(i) + " ");
                        Console.WriteLine();
                    }
            }
            if (n == 2) //матрица
            {
                for (int i = 0; i < univ.GetLength(0); i++)
                {
                    for (int j = 0; j < univ.GetLength(1); j++)
                    {
                        Console.Write(univ.GetValue(i, j) + " ");
                    }
                    Console.WriteLine();
                }
            }

        }

        public static void PrintAnyArr2(string name, Array univ)
        {
            Console.WriteLine(name);
            if (univ.Rank == 1)// одномерный массив
            {
                var en = univ.GetEnumerator();
                en.MoveNext();
                if (en.Current.GetType() == Type.GetType("System.Int32"))
                    foreach (int elem in univ) Console.Write(elem + " ");
                else
                    foreach (int[] mas in univ)
                    {
                        foreach (int elem2 in mas) Console.Write(elem2 + " ");
                        Console.WriteLine();
                    }
            }
            if (univ.Rank == 2) //матрица
            {
                int i = 1;
                foreach (int x in univ)
                    if (i++ % univ.GetLength(1) == 0)
                        Console.WriteLine(x);
                    else
                        Console.Write(x + " ");
            }
        }

        public static void PrintAnyArr3(Object A, params int[] coef)
        {
            Array arr = A as Array;
            foreach (int elem in arr) Console.Write(elem + " ");
            Console.WriteLine();
            if (arr == null)
            {
                Console.WriteLine("Объект пуст");
            }
        }

        public static void PrintArObj(string name, object[] A)
        {
            Console.WriteLine(name);
            foreach (object item in A)
                Console.Write("\t {0}", item);
            Console.WriteLine();
        }

        public static int[,] MultMatr(int[,] mat1, int[,] mat2)
        {
            int rows1 = mat1.GetUpperBound(0) + 1;
            int cols1 = mat1.Length / rows1;
            int rows2 = mat2.GetUpperBound(0) + 1;
            int cols2 = mat2.Length / rows2;
            int[,] matmul = new int[cols1, rows2];
            if (cols1 == rows2)
            {
                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols2; j++)
                    {
                        matmul[i, j] = 0;
                        for (int k = 0; k < cols1; k++)
                        {
                            matmul[i, j] += mat1[i, k] * mat2[k, j];
                        }
                    }
                }
            }
            else Console.WriteLine("Умножение матриц невозможно");
            return matmul;
        }

        public static void ArrayMethods(Array m)
        {
            int[] arr2 = new int [m.Length];
            Console.Write("Введите элемент массива:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Индекс первого вхождения элемента в массив: "+Array.IndexOf(m,i));
            Console.Write("Введите элемент массива:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Индекс последнего вхождения элемента в массив: " + Array.LastIndexOf(m, i));
            Console.WriteLine("Массив до копирования:");
            foreach (int elem2 in arr2) Console.Write(elem2 + " ");
            Console.WriteLine();
            Console.WriteLine("Массив после копирования из массива m:");
            Array.Copy(m, arr2, m.Length);
            foreach (int elem2 in arr2) Console.Write(elem2 + " ");
            Console.WriteLine();
            Console.WriteLine("Элементы массива в обратном порядке: ");
            Array.Reverse(m);
            foreach (int elem in m) Console.Write(elem+" ");
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив: ");
            Array.Sort(m);
            foreach (int elem3 in m) Console.Write(elem3 + " ");
            Console.WriteLine();
            Console.WriteLine("Индекс первого вхождения элемента: "+Array.BinarySearch(m,i));
        }


        ~Arrs()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] A = new int[5], B = new int[5], C = new int[5];
            Arrs.CreateOneDimAr(A);
            Arrs.CreateOneDimAr(B);
            int[,] dm1 = new int[3, 3];
            int[,] dm2 = new int[3, 3];
            Arrs.CreateAr2(dm1);
            Arrs.CreateAr2(dm2);
            for (int i = 0; i < 5; i++)
            {
                C[i] = A[i] + B[i];
            }

            int[] Z = { 1, 5, 2, 5, 2, 7, 2, 9, 1, 3 };
            //Задание 1
            Arrs.PrintAnyArr("Массив A",A);
            Console.WriteLine();
            Arrs.PrintAnyArr("Матрица dm1", dm1);
            //Задание 2
            Arrs.ArrayMethods(Z);

            //Задание 3
            //Различие между GetLength() и Length
            int[,] M = new int[10, 15];
            Console.WriteLine(M.GetLength(0)); //выводит кол-во элементов в 1-ом измерении
            Console.WriteLine(M.GetLength(1)); //выводит кол-во элементов во 2-ом измерении
            Console.WriteLine(M.Length); //выводит общее кол-во элементов
            //Параметр функции PrintAnyArr3 типа Object
            Arrs.PrintAnyArr3(Z);

            //Задание 5
            string[] winames = { "Т. Хоар", "Н. Вирт", "Э. Дейкстра" };
            Arrs.PrintArObj("winames", winames);
            object[] cur = new object[5];
            cur = winames;
            Arrs.PrintArObj("cur", cur);
            winames = (string[])cur;
            Arrs.PrintArObj("winames", winames);
        }
    }
}

