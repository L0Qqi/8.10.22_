using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace Из_Тумакова
{
    internal class Program
    {
        static void Task1(char[] str, out int n1, out int n2)
        {
            n1 = 0;
            n2 = 0;
            char[] c = { 'e', 'y', 'u', 'i', 'o', 'a' };
            foreach (char c2 in str)
            {
                if (c.Contains(c2))
                    n1++;
                else
                    n2++;
            }
            Console.WriteLine("гласные: " + n1);
            Console.WriteLine("согласные: " + n2);
        }


        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        enum months
        {
            January = 1,
            February = 2,
            Marth = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        static void Print1(LinkedList<LinkedList<int>> Mtrx)
        {
            foreach (LinkedList<int> subline in Mtrx)
            {
                Console.WriteLine(string.Join(" ", subline.ToArray()));
            }
        }
        static int[] Task3(int[,] t)
        {
            int[] sr = new int[12];
            for (int i = 0; i < 12; i++)
            {
                int cnt = 0;
                for (int j = 0; j < 30; j++)
                {
                    cnt += t[i, j];
                }
                sr[i] = cnt / 30;
            }
            sr = sr.OrderBy(x => x).ToArray();
            return sr;
        }
        static int[] Task31(Dictionary<string, int[]> t)
        {
            string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] tt = new int[12];
            for (int i = 0; i < month.Length; i++)
            {
                tt[i] = t[month[i]].Sum() / 30;
            }

            foreach (int i in tt)
            {
                Console.Write(" " + i);
            }
            return tt;
        }
        static void MatrixMulti(LinkedList<LinkedList<int>> mat1, LinkedList<LinkedList<int>> mat2, ref LinkedList<LinkedList<int>> multi) //матрица дз
        {
            LinkedList<int> m1 = new LinkedList<int>();
            LinkedList<int> m2 = new LinkedList<int>();
            LinkedList<int> mult = new LinkedList<int>();
            m1.AddFirst(6); m1.AddLast(5); m1.AddLast(9); m1.AddLast(4);
            m2.AddFirst(8); m2.AddLast(1); m2.AddLast(6); m2.AddLast(9);
            mat1.AddFirst(m1);
            mat2.AddFirst(m2);
            var a1 = m1.First; var a2 = a1.Next; var a3 = a2.Next; var a4 = a3.Next;
            var b1 = m2.First; var b2 = b1.Next; var b3 = b2.Next; var b4 = b3.Next;
            var c0 = a1.Value * b1.Value + a2.Value * b3.Value;
            var c1 = a1.Value * b2.Value + a2.Value * b4.Value;
            var c2 = a3.Value * b1.Value + a4.Value * b3.Value;
            var c3 = a3.Value * b2.Value + a4.Value * b4.Value;
            mult.AddFirst(c0); mult.AddLast(c1); mult.AddLast(c2); mult.AddLast(c3);
            multi.AddFirst(mult);
            var item = mult.First;
            int i = 0;
            Console.WriteLine("Произведение матриц:");
            while (item != null)
            {
                Console.Write(item.Value + " ");
                item = item.Next;
                i++;
                if (i == 2)
                {
                    Console.WriteLine();
                }
            }
        }
        static int srtemp(int[] array, ref int[] sr_znach) //темпа дз
        {
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum = ++array[i];
            }
            Array.Sort(sr_znach);
            return (int)Math.Round(sum / 12);
        }
        static void Main(string[] args)
        {
            char[] bukvi = File.ReadAllText("C:\\Users\\loqi\\source\\repos\\8.10.22\\Тумаков\\TextFile1.txt").ToArray<char>();
            Task1(bukvi, out _, out _);

            Console.WriteLine("Task2");
            Console.WriteLine("Введите размерность первой матрицы: ");
            int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите размерность второй матрицы: ");
            int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМатрица A:");
            Print(A);
            Console.WriteLine("\nМатрица B:");
            Print(B);
            Console.WriteLine("\nМатрица C = A * B:");
            int[,] C = Multiplication(A, B);
            Print(C);


            Console.WriteLine("Task3");
            int[,] temp = new int[12, 30];
            Random r = new Random();
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = r.Next(-10, 30);
                }
            }
            Console.WriteLine(string.Join(",", Task3(temp)));

            Console.WriteLine("Task1.1");
            List<char[]> syms = new List<char[]>();
            syms.Add(bukvi);
            Task1(syms[0], out _, out _);


            Console.WriteLine("Task 3.2");
            LinkedList<LinkedList<int>> mat1 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> mat2 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> multimatrix = new LinkedList<LinkedList<int>>();
            MatrixMulti(mat1, mat2, ref multimatrix);
            Console.WriteLine();

            Console.WriteLine("ДЗ 6.3");
            Random temp1 = new Random();
            int[] temper = new int[30];
            int[] AllTemps = new int[12];
            Dictionary<months, int[]> weather = new Dictionary<months, int[]>();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temper[j] = temp1.Next(-30, 30);
                }
                Console.WriteLine($"Средняя температура в {(months)(i + 1)} - {srtemp(temper, ref AllTemps)}");
                weather.Add((months)(i + 1), temper);
                AllTemps[i] = srtemp(temper, ref AllTemps);
            }
            Console.WriteLine("Отсортированный массив средних температур: ");
            foreach (int a in AllTemps)
            {
                Console.Write(a + " ");
            }
        }
    }
}
